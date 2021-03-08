using Laerdal.Dfu.Enums;

using System;
using System.Threading.Tasks;
using System.Timers;
using Laerdal.Dfu.Helpers;

namespace Laerdal.Dfu
{
    public abstract class SharedDfuInstallation : BindableObject, IDisposable
    {
        public string DeviceId { get; }

        public string FileUrl { get; }
        
        private TaskCompletionSource ProgressTaskCompletionSource { get; }
        private System.Timers.Timer RefreshBindingValues { get; } = new System.Timers.Timer(1000);

        protected SharedDfuInstallation(string deviceId, string fileUrl)
        {
            RefreshBindingValues.Start();
            RefreshBindingValues.Elapsed += RefreshBindingValuesOnElapsed;
            ProgressTaskCompletionSource = new TaskCompletionSource();

            DeviceId = deviceId;
            FileUrl = fileUrl;
        }

        public abstract void Start();
        public abstract void Pause();
        public abstract void Resume();
        public abstract void Abort();
        
        public Task Task => ProgressTaskCompletionSource.Task;

        private void RefreshBindingValuesOnElapsed(object sender, ElapsedEventArgs e)
        {
            if (StartTime != null)
            {
                Duration = DateTime.UtcNow - StartTime.Value;

                if (Progress >= 1 || State == DfuState.Aborted || Error != DfuError.NoError) // Done or Error
                {
                    EstimatedTimeLeft = TimeSpan.Zero;
                    RefreshBindingValues?.Stop();
                    RefreshBindingValues?.Dispose();
                }
                else if (Progress <= 0) // Not started
                {
                    EstimatedTimeLeft = null;
                }
                else // Running
                {
                    StartTime ??= DateTime.UtcNow;
                    Duration = DateTime.UtcNow - StartTime.Value;
                    var ticksPerProgressPercent = Duration.Ticks / (long) Math.Round(Progress * 100);
                    var ticksTotal = ticksPerProgressPercent * 100;
                    var ticksLeft = ticksTotal - ticksPerProgressPercent;
                    EstimatedTimeLeft = TimeSpan.FromTicks(ticksLeft);
                }
            }
        }
        
        public DateTime? StartTime
        {
            get => GetValue<DateTime?>(null);
            set => SetValue(value);
        }
        
        public DateTime? EndTime
        {
            get => GetValue<DateTime?>(null);
            set => SetValue(value);
        }
        
        public TimeSpan? EstimatedTimeLeft
        {
            get => GetValue(new TimeSpan(0));
            set => SetValue(value);
        }
        
        public TimeSpan Duration
        {
            get => GetValue(new TimeSpan(0));
            set => SetValue(value);
        }

        public double Progress
        {
            get => GetValue(0);
            set => SetValue(value);
        }

        public double CurrentSpeedBytesPerSecond
        {
            get => GetValue(0);
            set => SetValue(value);
        }

        public double AvgSpeedBytesPerSecond
        {
            get => GetValue(0);
            set => SetValue(value);
        }

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
            }
        }

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
            ProgressTaskCompletionSource.TrySetException(new DfuException(error, message));
        }

        #endregion

        public override string ToString()
        {
            return $"DFU Installation on '{DeviceId}'";
        }

        public virtual void Dispose()
        {
            RefreshBindingValues?.Dispose();
        }
    }

    public partial class DfuInstallation : SharedDfuInstallation { }
}