using Laerdal.Dfu.Enums;
using Laerdal.Dfu.EventArgs;

using Laerdal.Dfu.Helpers;

namespace Laerdal.Dfu
{
    public abstract class SharedDfuInstallation : IDisposable
    {
        public string DeviceId { get; set; }

        public string FileUrl{ get; set; }

        private Laerdal.Dfu.Helpers.TaskCompletionSource ProgressTaskCompletionSource { get; }

        protected SharedDfuInstallation()
        {
            ProgressTaskCompletionSource = new Laerdal.Dfu.Helpers.TaskCompletionSource();
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
        public string AlternativeAdvertisingName { get; set; }

        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetPrepareDataObjectDelay(long delay)
        /// iOS :
        ///     public double DataObjectPreparationDelay {get; set;}
        /// </summary>
        public double? DataObjectPreparationDelay { get; set; }
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator DisableResume()
        /// iOS :
        ///     public bool DisableResume {get; set;}
        /// </summary>
        public bool? DisableResume { get; set; }

        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetUnsafeExperimentalButtonlessServiceInSecureDfuEnabled(bool enable)
        /// iOS :
        ///     public bool EnableUnsafeExperimentalButtonlessServiceInSecureDfu {get; set;}
        /// </summary>
        public bool? EnableUnsafeExperimentalButtonlessServiceInSecureDfu { get; set; }

        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetForceDfu(bool force)
        /// iOS :
        ///     public bool ForceDfu {get; set;}
        /// </summary>
        public bool? ForceDfu { get; set; }

        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetForceScanningForNewAddressInLegacyDfu(bool force)
        /// iOS :
        ///     public bool ForceScanningForNewAddressInLegacyDfu {get; set;}
        /// </summary>
        public bool? ForceScanningForNewAddressInLegacyDfu { get; set; }

        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetPacketsReceiptNotificationsEnabled(bool enabled)
        ///     public DfuServiceInitiator SetPacketsReceiptNotificationsValue(int number)
        /// iOS :
        ///     public ushort PacketReceiptNotificationParameter {get; set;}
        /// </summary>
        public ushort? PacketReceiptNotificationParameter { get; set; }
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator DisableMtuRequest()
        /// </summary>
        public bool? DisableMtuRequest { get; set; }
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetDisableNotification(bool disableNotification)
        /// </summary>
        public bool? DisableNotification { get; set; }
        
        /// <summary>
        /// Android :
        ///     public const int DefaultMbrSize = 4096;
        ///     public DfuServiceInitiator SetMbrSize(int mbrSize)
        /// </summary>
        public int? MbrSize { get; set; }
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetScope(int scope)
        ///     public const int ScopeApplication = 2;
        ///     public const int ScopeSystemComponents = 1;
        /// </summary>
        public DfuServiceScope? Scope { get; set; }
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetForeground(bool foreground)
        /// </summary>
        public bool? Foreground { get; set; }
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetKeepBond(bool keepBond)
        /// </summary>
        public bool? KeepBond { get; set; }
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetRestoreBond(bool keepBond)
        /// </summary>
        public bool? RestoreBond { get; set; }
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetMtu(int mtu)
        /// </summary>
        public int? Mtu { get; set; }
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetNumberOfRetries(int max)
        /// </summary>
        public int? NumberOfRetries { get; set; }
        
        /// <summary>
        /// iOS :
        ///     public double ConnectionTimeout {get; set;}
        /// </summary>
        public long? ConnectionTimeout { get; set; }
        
        // TODO : CustomUuids
        
        #endregion
        
        #region Progress

        public DateTime StartTime { get; set; }

        public TimeSpan EstimatedTimeLeft { get; set; }

        public TimeSpan Duration { get; set; }

        public double Progress { get; set; }

        public double CurrentSpeedBytesPerSecond { get; set; }

        public double AvgSpeedBytesPerSecond { get; set; }

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
                StartTime = StartTime == default ? DateTime.UtcNow : StartTime;
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

        private DfuState _state = DfuState.Connecting;
        public DfuState State
        {
            get => _state;
            set
            {
                _state = value;
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

        public DfuError Error { get; set; }

        public string ErrorMessage { get; set; }

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