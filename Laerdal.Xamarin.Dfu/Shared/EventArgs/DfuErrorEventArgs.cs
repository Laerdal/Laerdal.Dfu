using Laerdal.Xamarin.Dfu.Enums;

namespace Laerdal.Xamarin.Dfu.EventArgs
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