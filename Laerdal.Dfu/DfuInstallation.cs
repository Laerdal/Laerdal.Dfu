using Laerdal.Dfu.Enums;
using Laerdal.Dfu.EventArgs;
using System;
using System.Threading.Tasks;

namespace Laerdal.Dfu
{
    public abstract class SharedDfuInstallation : IDisposable
    {
        public string DeviceId { get; protected set; }
        public string FileUrl { get; protected set; }

        private Helpers.TaskCompletionSource ProgressTaskCompletionSource { get; }
        
        protected SharedDfuInstallation(string deviceId, string fileUrl)
        {
            DeviceId = deviceId;
            FileUrl = fileUrl;
            ProgressTaskCompletionSource = new Helpers.TaskCompletionSource();
        }



        public abstract void Start();

        public abstract void Pause();

        public abstract void Resume();

        public abstract void Abort();

        public Task Task
        {
            get => ProgressTaskCompletionSource.Task;
        }

        #region DfuInitiator Shared Configuration

        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetDeviceName(string name)
        /// iOS :
        ///     public string? AlternativeAdvertisingName {get; set;}
        ///     public bool AlternativeAdvertisingNameEnabled {get; set;}
        /// </summary>
        public string AlternativeAdvertisingName {get; set;}

        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetPrepareDataObjectDelay(long delay)
        /// iOS :
        ///     public double DataObjectPreparationDelay {get; set;}
        /// </summary>
        public double? DataObjectPreparationDelay {get; set;}
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator DisableResume()
        /// iOS :
        ///     public bool DisableResume {get; set;}
        /// </summary>
        public bool? DisableResume {get; set;}

        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetUnsafeExperimentalButtonlessServiceInSecureDfuEnabled(bool enable)
        /// iOS :
        ///     public bool EnableUnsafeExperimentalButtonlessServiceInSecureDfu {get; set;}
        /// </summary>
        public bool? EnableUnsafeExperimentalButtonlessServiceInSecureDfu {get; set;}

        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetForceDfu(bool force)
        /// iOS :
        ///     public bool ForceDfu {get; set;}
        /// </summary>
        public bool? ForceDfu {get; set;}

        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetForceScanningForNewAddressInLegacyDfu(bool force)
        /// iOS :
        ///     public bool ForceScanningForNewAddressInLegacyDfu {get; set;}
        /// </summary>
        public bool? ForceScanningForNewAddressInLegacyDfu {get; set;}

        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetPacketsReceiptNotificationsEnabled(bool enabled)
        ///     public DfuServiceInitiator SetPacketsReceiptNotificationsValue(int number)
        /// iOS :
        ///     public ushort PacketReceiptNotificationParameter {get; set;}
        /// </summary>
        public ushort? PacketReceiptNotificationParameter {get; set;}
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator DisableMtuRequest()
        /// </summary>
        public bool? DisableMtuRequest {get; set;}
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetDisableNotification(bool disableNotification)
        /// </summary>
        public bool? DisableNotification {get; set;}
        
        /// <summary>
        /// Android :
        ///     public const int DefaultMbrSize = 4096;
        ///     public DfuServiceInitiator SetMbrSize(int mbrSize)
        /// </summary>
        public int? MbrSize {get; set;}
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetScope(int scope)
        ///     public const int ScopeApplication = 2;
        ///     public const int ScopeSystemComponents = 1;
        /// </summary>
        public DfuServiceScope? Scope {get; set;}
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetForeground(bool foreground)
        /// </summary>
        public bool? Foreground {get; set;}
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetKeepBond(bool keepBond)
        /// </summary>
        public bool? KeepBond {get; set;}
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetRestoreBond(bool keepBond)
        /// </summary>
        public bool? RestoreBond {get; set;}
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetMtu(int mtu)
        /// </summary>
        public int? Mtu {get; set;}
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetNumberOfRetries(int max)
        /// </summary>
        public int? NumberOfRetries {get; set;}
        
        /// <summary>
        /// iOS :
        ///     public double ConnectionTimeout {get; set;}
        /// </summary>
        public long? ConnectionTimeout {get; set;}
        
        // TODO : CustomUuids
        
        #endregion
        
        #region Progress

        public DateTime? StartTime {get; private set;}
        public DateTime? EndTime {get; private set;}

        internal void OnProgressChanged(double progress, double currentSpeedBytesPerSecond, double avgSpeedBytesPerSecond)
        {
            StartTime ??= DateTime.UtcNow;
            TimeSpan estimatedTimeLeft;
            TimeSpan duration;
            if (progress >= 1 || State == DfuState.Aborted || State == DfuState.Error) // Done or Error
            {
                EndTime ??= DateTime.UtcNow;
                duration = EndTime.Value - StartTime.Value;
                estimatedTimeLeft = TimeSpan.Zero;
            }
            else if (progress <= 0) // Not started
            {
                duration = TimeSpan.Zero;
                estimatedTimeLeft = TimeSpan.Zero;
            }
            else // Running
            {
                duration = DateTime.UtcNow - StartTime.Value;
                var ticksPerProgressPercent = duration.Ticks / (long) Math.Round(progress * 100);
                var ticksTotal = ticksPerProgressPercent * 100;
                var ticksLeft = ticksTotal - duration.Ticks;
                estimatedTimeLeft = TimeSpan.FromTicks(ticksLeft);
            }

            ProgressChanged?.Invoke(this, new DfuProgressChangedEventArgs(progress, currentSpeedBytesPerSecond, avgSpeedBytesPerSecond, duration, estimatedTimeLeft));
        }

        public event EventHandler<DfuProgressChangedEventArgs> ProgressChanged;

        #endregion

        #region State

        public DfuState State {get; private set;}

        internal void OnDfuStateChanged(DfuState state)
        {
            State = state;
            if (state == DfuState.Completed)
            {
                ProgressTaskCompletionSource.TrySetCompleted();
            }
            else if (state == DfuState.Aborted)
            {
                ProgressTaskCompletionSource.TrySetCompleted();
            }
            else if (state == DfuState.Error)
            {
                ProgressTaskCompletionSource.TrySetCompleted();
            }

            StateChanged?.Invoke(this, state);
        }
        
        public event EventHandler<DfuState> StateChanged;

        #endregion

        #region Error

        internal void OnDfuError(DfuError error, string message)
        {
            DfuEvents.OnDfuError(error, message);
            ErrorOccured?.Invoke(this, new DfuErrorEventArgs(error, message));
            ProgressTaskCompletionSource.TrySetException(new DfuException(error, message));
        }

        public event EventHandler<DfuErrorEventArgs> ErrorOccured;

        #endregion

        public override string ToString()
        {
            return $"DFU Installation {State} on '{DeviceId}'";
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing) { }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

    public partial class DfuInstallation : SharedDfuInstallation { }
}