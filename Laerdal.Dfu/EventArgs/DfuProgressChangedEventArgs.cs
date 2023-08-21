using System;

namespace Laerdal.Dfu.EventArgs
{
    public class DfuProgressChangedEventArgs : System.EventArgs
    {
        public TimeSpan EstimatedTimeLeft {get; }

        public TimeSpan Duration {get; }
        
        public double Progress { get; }

        public double CurrentSpeedBytesPerSecond { get; }

        public double AvgSpeedBytesPerSecond { get; }


        internal DfuProgressChangedEventArgs(double progress, in double currentSpeedBytesPerSecond, in double avgSpeedBytesPerSecond, TimeSpan duration,
            TimeSpan estimatedTimeLeft)
        {
            Progress = progress;
            CurrentSpeedBytesPerSecond = currentSpeedBytesPerSecond;
            AvgSpeedBytesPerSecond = avgSpeedBytesPerSecond;
            Duration = duration;
            EstimatedTimeLeft = estimatedTimeLeft;
        }
    }
}