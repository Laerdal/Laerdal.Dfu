using Laerdal.Dfu.Enums;
using Laerdal.Dfu.EventArgs;

using System;

namespace Laerdal.Dfu
{
    public static class DfuEvents
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