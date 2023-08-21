using Laerdal.Dfu.Enums;

using Microsoft.Extensions.Logging;

namespace Laerdal.Dfu.EventArgs
{
    public class DfuMessageReceivedEventArgs : System.EventArgs
    {
        public LogLevel LogLevel { get; }

        public string Message { get; }

        internal DfuMessageReceivedEventArgs(DfuLogLevel logLevel, string message)
        {
            LogLevel = logLevel.ToLogLevel();
            Message = message;
        }
    }
}