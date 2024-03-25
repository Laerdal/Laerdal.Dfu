using Laerdal.Dfu.Enums;

namespace Laerdal.Dfu.EventArgs
{
    public class DfuLogReceivedEventArgs : System.EventArgs
    {
        public DfuLogLevel LogLevel { get; }

        public string Message { get; }

        internal DfuLogReceivedEventArgs(DfuLogLevel logLevel, string message)
        {
            LogLevel = logLevel;
            Message = message;
        }
    }
}