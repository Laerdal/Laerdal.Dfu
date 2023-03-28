using Laerdal.Dfu.Enums;
using Laerdal.Dfu.EventArgs;

using System;
using System.Threading.Tasks;

using Laerdal.Dfu.Helpers;

namespace Laerdal.Dfu
{
    public abstract class SharedDfuInstallation : BindableObject, IDisposable
    {
        public string DeviceId
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        public string FileUrl
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        private TaskCompletionSource ProgressTaskCompletionSource { get; }

        protected SharedDfuInstallation()
        {
            ProgressTaskCompletionSource = new TaskCompletionSource();
        }

        protected SharedDfuInstallation(string deviceId, string fileUrl) : this()
        {
            DeviceId = deviceId;
            FileUrl = fileUrl;
        }

        public abstract void Start();

        public abstract void Pause();

        public abstract void Resume();

        public abstract void Abort();

        public Task Task => ProgressTaskCompletionSource.Task;

        #region DfuInitiator Shared Configuration

        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetDeviceName(string name)
        /// iOS :
        ///     public string? AlternativeAdvertisingName {get; set;}
        ///     public bool AlternativeAdvertisingNameEnabled {get; set;}
        /// </summary>
        public string AlternativeAdvertisingName
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetPrepareDataObjectDelay(long delay)
        /// iOS :
        ///     public double DataObjectPreparationDelay {get; set;}
        /// </summary>
        public double? DataObjectPreparationDelay
        {
            get => GetValue<double?>();
            set => SetValue(value);
        }
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator DisableResume()
        /// iOS :
        ///     public bool DisableResume {get; set;}
        /// </summary>
        public bool? DisableResume
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }

        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetUnsafeExperimentalButtonlessServiceInSecureDfuEnabled(bool enable)
        /// iOS :
        ///     public bool EnableUnsafeExperimentalButtonlessServiceInSecureDfu {get; set;}
        /// </summary>
        public bool? EnableUnsafeExperimentalButtonlessServiceInSecureDfu
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }

        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetForceDfu(bool force)
        /// iOS :
        ///     public bool ForceDfu {get; set;}
        /// </summary>
        public bool? ForceDfu
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }

        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetForceScanningForNewAddressInLegacyDfu(bool force)
        /// iOS :
        ///     public bool ForceScanningForNewAddressInLegacyDfu {get; set;}
        /// </summary>
        public bool? ForceScanningForNewAddressInLegacyDfu
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }

        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetPacketsReceiptNotificationsEnabled(bool enabled)
        ///     public DfuServiceInitiator SetPacketsReceiptNotificationsValue(int number)
        /// iOS :
        ///     public ushort PacketReceiptNotificationParameter {get; set;}
        /// </summary>
        public ushort? PacketReceiptNotificationParameter
        {
            get => GetValue<ushort?>();
            set => SetValue(value);
        }
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator DisableMtuRequest()
        /// </summary>
        public bool? DisableMtuRequest
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetDisableNotification(bool disableNotification)
        /// </summary>
        public bool? DisableNotification
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }
        
        /// <summary>
        /// Android :
        ///     public const int DefaultMbrSize = 4096;
        ///     public DfuServiceInitiator SetMbrSize(int mbrSize)
        /// </summary>
        public int? MbrSize
        {
            get => GetValue<int?>();
            set => SetValue(value);
        }
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetScope(int scope)
        ///     public const int ScopeApplication = 2;
        ///     public const int ScopeSystemComponents = 1;
        /// </summary>
        public DfuServiceScope? Scope
        {
            get => GetValue<DfuServiceScope?>();
            set => SetValue(value);
        }
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetForeground(bool foreground)
        /// </summary>
        public bool? Foreground
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetKeepBond(bool keepBond)
        /// </summary>
        public bool? KeepBond
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetRestoreBond(bool keepBond)
        /// </summary>
        public bool? RestoreBond
        {
            get => GetValue<bool?>();
            set => SetValue(value);
        }
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetMtu(int mtu)
        /// </summary>
        public int? Mtu
        {
            get => GetValue<int?>();
            set => SetValue(value);
        }

        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetPhy(int phy)
        /// </summary>
        public int? Phy
        {
            get => GetValue<int?>();
            set => SetValue(value);
        }
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetNumberOfRetries(int max)
        /// </summary>
        public int? NumberOfRetries
        {
            get => GetValue<int?>();
            set => SetValue(value);
        }
        
        /// <summary>
        /// iOS :
        ///     public double ConnectionTimeout {get; set;}
        /// </summary>
        public long? ConnectionTimeout
        {
            get => GetValue<long?>();
            set => SetValue(value);
        }
        
        // TODO : CustomUuids
        
        #endregion
        
        #region Progress

        public DateTime StartTime
        {
            get => GetValue<DateTime>(DateTime.UtcNow);
            set => SetValue(value);
        }

        public TimeSpan EstimatedTimeLeft
        {
            get => GetValue(TimeSpan.Zero);
            set => SetValue(value);
        }

        public TimeSpan Duration
        {
            get => GetValue(TimeSpan.Zero);
            set => SetValue(value);
        }

        public double Progress
        {
            get => GetValue(0d);
            set => SetValue(value);
        }

        public double CurrentSpeedBytesPerSecond
        {
            get => GetValue(0d);
            set => SetValue(value);
        }

        public double AvgSpeedBytesPerSecond
        {
            get => GetValue(0d);
            set => SetValue(value);
        }

        internal void OnProgressChanged(double progress, double currentSpeedBytesPerSecond, double avgSpeedBytesPerSecond)
        {
            Progress = progress;
            CurrentSpeedBytesPerSecond = currentSpeedBytesPerSecond;
            AvgSpeedBytesPerSecond = avgSpeedBytesPerSecond;

            if (Progress >= 1 || State == DfuState.Aborted || Error != DfuError.NoError) // Done or Error
            {
                EstimatedTimeLeft = TimeSpan.Zero;
            }
            else if (Progress <= 0) // Not started
            {
                EstimatedTimeLeft = TimeSpan.Zero;
            }
            else // Running
            {
                var startTime = StartTime; // Force initialization of field by calling Get
                Duration = DateTime.UtcNow - startTime;
                var ticksPerProgressPercent = Duration.Ticks / (long) Math.Round(Progress * 100);
                var ticksTotal = ticksPerProgressPercent * 100;
                var ticksLeft = ticksTotal - Duration.Ticks;
                EstimatedTimeLeft = TimeSpan.FromTicks(ticksLeft);
            }

            ProgressChanged?.Invoke(this, new DfuProgressChangedEventArgs(progress, currentSpeedBytesPerSecond, avgSpeedBytesPerSecond));
        }

        public event EventHandler<DfuProgressChangedEventArgs> ProgressChanged;

        #endregion

        #region State

        public DfuState State
        {
            get => GetValue(DfuState.Connecting);
            set
            {
                SetValue(value);
                if (value == DfuState.Completed)
                {
                    ProgressTaskCompletionSource.TrySetCompleted();
                }
                else if (value == DfuState.Aborted)
                {
                    ProgressTaskCompletionSource.TrySetCompleted();
                }
                else if (value == DfuState.Error)
                {
                    ProgressTaskCompletionSource.TrySetCompleted();
                }

                StateChanged?.Invoke(this, value);
            }
        }

        public event EventHandler<DfuState> StateChanged;

        #endregion

        #region Error

        public DfuError Error
        {
            get => GetValue(DfuError.NoError);
            set => SetValue(value);
        }

        public string ErrorMessage
        {
            get => GetValue<string>();
            set => SetValue(value);
        }

        internal void OnDfuError(DfuError error, string message)
        {
            Error = error;
            ErrorMessage = message;
            Events.OnDfuError(error, message);
            ErrorOccured?.Invoke(this, new DfuErrorEventArgs(error, message));
            ProgressTaskCompletionSource.TrySetException(new DfuException(error, message));
        }

        public event EventHandler<DfuErrorEventArgs> ErrorOccured;

        #endregion

        public override string ToString()
        {
            return $"DFU Installation {State} on '{DeviceId}', {Progress:P}, {Error} / {ErrorMessage}";
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