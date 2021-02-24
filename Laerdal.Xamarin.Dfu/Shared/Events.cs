using Laerdal.Xamarin.Dfu.Enums;
using Laerdal.Xamarin.Dfu.EventArgs;

using System;

namespace Laerdal.Xamarin.Dfu
{
    public static class Events
    {
        public static event EventHandler<DfuErrorEventArgs> DfuErrorOccured; 
        
        internal static void OnDfuError(DfuError error, string message)
        {
            DfuErrorOccured?.Invoke(null, new DfuErrorEventArgs(error, message));
        }
        
        
        public static event EventHandler<DfuMessageReceivedEventArgs> DfuMessageReceived;

        internal static void OnDfuMessageReceived(DfuLogLevel logLevel, string logMessage)
        {
            DfuMessageReceived?.Invoke(null, new DfuMessageReceivedEventArgs(logLevel, logMessage));
        }

    }
}