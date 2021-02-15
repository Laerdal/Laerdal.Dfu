using Laerdal.Xamarin.Dfu.Enums;

using System;
using System.Threading.Tasks;
using System.Timers;
using Laerdal.Xamarin.Dfu.Helpers;

namespace Laerdal.Xamarin.Dfu
{
    public abstract class SharedDfuInstallation : BindableObject, IDisposable
    {
        public string DeviceId { get; }

        public string FileUrl { get; }

        public DateTime StartTime { get; }

        private TaskCompletionSource ProgressTaskCompletionSource { get; }

        protected SharedDfuInstallation(string deviceId, string fileUrl)
        {
            RefreshBindingValues.Elapsed += RefreshBindingValuesOnElapsed;
            RefreshBindingValues.Start();

            ProgressTaskCompletionSource = new TaskCompletionSource();

            DeviceId = deviceId;
            FileUrl = fileUrl;
            StartTime = DateTime.UtcNow;
        }

        public abstract void Start();
        public abstract void Pause();
        public abstract void Resume();
        public abstract void Abort();

        public TimeSpan Duration => DateTime.UtcNow - StartTime;

        public TimeSpan? EstimatedTimeLeft => GetEstimatedTimeLeft();

        public Task Task => ProgressTaskCompletionSource.Task;

        private TimeSpan? GetEstimatedTimeLeft()
        {
            if (Progress >= 1 || Error != DfuError.NoError)
                return TimeSpan.Zero;
            if (Progress <= 0)
                return null;

            var ticksPerProgressPercent = Duration.Ticks / (long) Math.Round(Progress * 100);
            var ticksTotal = ticksPerProgressPercent * 100;
            var ticksLeft = ticksTotal - ticksPerProgressPercent;
            return TimeSpan.FromTicks(ticksLeft);
        }

        public virtual void Dispose()
        {
            RefreshBindingValues?.Stop();
            RefreshBindingValues?.Dispose();
        }

        private System.Timers.Timer RefreshBindingValues { get; } = new System.Timers.Timer(1000);

        private void RefreshBindingValuesOnElapsed(object sender, ElapsedEventArgs e)
        {
            RaisePropertyChanged(nameof(Duration));
            RaisePropertyChanged(nameof(EstimatedTimeLeft));
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
    }

    public partial class DfuInstallation : SharedDfuInstallation { }
}