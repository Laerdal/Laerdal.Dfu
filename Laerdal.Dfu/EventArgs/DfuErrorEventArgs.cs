using Laerdal.Dfu.Enums;

namespace Laerdal.Dfu.EventArgs
{
    public class DfuErrorEventArgs : System.EventArgs
    {
        public DfuError Error { get; }

        public string Message { get; }

        internal DfuErrorEventArgs(DfuError error, string message)
        {
            Error = error;
            Message = message;
        }
    }
}