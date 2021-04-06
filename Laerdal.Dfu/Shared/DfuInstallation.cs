using Laerdal.Dfu.Enums;
using Laerdal.Dfu.EventArgs;

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

        protected SharedDfuInstallation(string deviceId, string fileUrl)
        {
            ProgressTaskCompletionSource = new TaskCompletionSource();

            DeviceId = deviceId;
            FileUrl = fileUrl;
        }

        public abstract void Start();

        public abstract void Pause();

        public abstract void Resume();

        public abstract void Abort();

        public Task Task => ProgressTaskCompletionSource.Task;

        #region Progress

        public DateTime StartTime
        {
            get => GetValue<DateTime>(DateTime.UtcNow);
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
                EstimatedTimeLeft = null;
            }
            else // Running
            {
                Duration = DateTime.UtcNow - StartTime;
                var ticksPerProgressPercent = Duration.Ticks / (long) Math.Round(Progress * 100);
                var ticksTotal = ticksPerProgressPercent * 100;
                var ticksLeft = ticksTotal - ticksPerProgressPercent;
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