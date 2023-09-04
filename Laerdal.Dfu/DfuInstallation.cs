using Laerdal.Dfu.Enums;
using Laerdal.Dfu.EventArgs;

using System;
using System.Threading.Tasks;

namespace Laerdal.Dfu
{

    public abstract class SharedDfuInstallation : IDisposable
    {
        public string DeviceId { get; private set; }
        public string FileUrl { get; protected set; }

        private Helpers.TaskCompletionSource ProgressTaskCompletionSource { get; }
        
        protected SharedDfuInstallation(string deviceId, string fileUrl)
        {
            DeviceId = deviceId;
            FileUrl = fileUrl;
            ProgressTaskCompletionSource = new Helpers.TaskCompletionSource();
        }

        public abstract void Start(DfuConfiguration configuration = null);

        public abstract void Pause();

        public abstract void Resume();

        public abstract void Abort();

        public Task Task
        {
            get => ProgressTaskCompletionSource.Task;
        }

        
        #region Progress

        public double Progress {get; private set;}
        public double CurrentSpeedBytesPerSecond {get; private set;}
        public double AvgSpeedBytesPerSecond {get; private set;}
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

            Progress = progress;
            CurrentSpeedBytesPerSecond = currentSpeedBytesPerSecond;
            AvgSpeedBytesPerSecond = avgSpeedBytesPerSecond;
            DfuProgressChanged?.Invoke(this, new DfuProgressChangedEventArgs(progress, currentSpeedBytesPerSecond, avgSpeedBytesPerSecond, duration, estimatedTimeLeft));
            DfuEvents.OnDfuProgressChanged(this, progress, currentSpeedBytesPerSecond, avgSpeedBytesPerSecond, duration, estimatedTimeLeft);
        }

        public event EventHandler<DfuProgressChangedEventArgs> DfuProgressChanged;

        #endregion

        #region State

        public DfuState State {get; private set;}

        internal void OnDfuStateChanged(DfuState state)
        {
            var olsState = State;
            State = state;

            DfuStateChanged?.Invoke(this, new DfuStateChangedEventArgs(olsState, state));
            
            DfuEvents.OnDfuStateChanged(this, olsState, state);
            switch (state)
            {
                case DfuState.Completed:
                case DfuState.Aborted:
                case DfuState.Error:
                    ProgressTaskCompletionSource.TrySetCompleted();
                    break;
            }
        }
        
        public event EventHandler<DfuStateChangedEventArgs> DfuStateChanged;

        #endregion

        #region Error

        internal void OnDfuErrorReceived(DfuError error, string message)
        {
            DfuErrorReceived?.Invoke(this, new DfuErrorReceivedEventArgs(error, message));
            DfuEvents.OnDfuErrorReceived(this, error, message);
            ProgressTaskCompletionSource.TrySetException(new DfuException(error, message));
        }

        public event EventHandler<DfuErrorReceivedEventArgs> DfuErrorReceived;
 
        #endregion
        
        #region Log

        internal void OnDfuLogReceived(DfuLogLevel logLevel, string message)
        {
            DfuLogReceived?.Invoke(this, new DfuLogReceivedEventArgs(logLevel, message));
            DfuEvents.OnDfuLogReceived(this, logLevel, message);
        }

        public event EventHandler<DfuLogReceivedEventArgs> DfuLogReceived;

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