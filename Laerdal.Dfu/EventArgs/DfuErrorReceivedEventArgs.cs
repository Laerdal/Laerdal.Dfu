using Laerdal.Dfu.Enums;

namespace Laerdal.Dfu.EventArgs
{

    public class DfuErrorReceivedEventArgs : System.EventArgs
    {
        public DfuError Error { get; }

        public string Message { get; }

        internal DfuErrorReceivedEventArgs(DfuError error, string message)
        {
            Error = error;
            Message = message;
        }
    }
}