using Laerdal.Dfu.Enums;
using Laerdal.Dfu.EventArgs;

using System;

namespace Laerdal.Dfu
{
    public static class DfuEvents
    {
        public static event EventHandler<DfuErrorReceivedEventArgs> DfuErrorReceived; 
        
        internal static void OnDfuErrorReceived(DfuError error, string message)
        {
            DfuErrorReceived?.Invoke(null, new DfuErrorReceivedEventArgs(error, message));
        }
        
        
        public static event EventHandler<DfuLogReceivedEventArgs> DfuLogReceived;

        internal static void OnDfuLogReceived(DfuLogLevel logLevel, string logMessage)
        {
            DfuLogReceived?.Invoke(null, new DfuLogReceivedEventArgs(logLevel, logMessage));
        }

    }
}