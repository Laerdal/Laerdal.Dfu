using Laerdal.Dfu.Enums;

using Microsoft.Extensions.Logging;

namespace Laerdal.Dfu.EventArgs
{
    public class DfuLogReceivedEventArgs : System.EventArgs
    {
        public LogLevel LogLevel { get; }

        public string Message { get; }

        internal DfuLogReceivedEventArgs(DfuLogLevel logLevel, string message) : this(logLevel.ToLogLevel(), message)
        {
        }
        
        internal DfuLogReceivedEventArgs(LogLevel logLevel, string message)
        {
            LogLevel = logLevel;
            Message = message;
        }
    }
}