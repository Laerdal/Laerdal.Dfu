using Laerdal.Xamarin.Dfu.Enums;

namespace Laerdal.Xamarin.Dfu.EventArgs
{
    public class DfuMessageReceivedEventArgs : System.EventArgs
    {
        public DfuLogLevel LogLevel { get; }

        public string Message { get; }

        internal DfuMessageReceivedEventArgs(DfuLogLevel logLevel, string message)
        {
            LogLevel = logLevel;
            Message = message;
        }
    }
}