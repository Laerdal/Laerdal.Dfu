namespace Laerdal.Dfu.EventArgs
{
    public class DfuProgressChangedEventArgs : System.EventArgs
    {
        public double Progress { get; }

        public double CurrentSpeedBytesPerSecond { get; }

        public double AvgSpeedBytesPerSecond { get; }

        internal DfuProgressChangedEventArgs(double progress, in double currentSpeedBytesPerSecond, in double avgSpeedBytesPerSecond)
        {
            Progress = progress;
            CurrentSpeedBytesPerSecond = currentSpeedBytesPerSecond;
            AvgSpeedBytesPerSecond = avgSpeedBytesPerSecond;
        }
    }
}