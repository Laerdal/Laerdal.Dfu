using Laerdal.Dfu.Enums;
using Laerdal.Dfu.EventArgs;

using System;

namespace Laerdal.Dfu
{
    public static class DfuEvents
    {
        public static event EventHandler<DfuErrorReceivedEventArgs> DfuErrorReceived; 
        
        internal static void OnDfuErrorReceived(SharedDfuInstallation sharedDfuInstallation, DfuError error, string message)
        {
            DfuErrorReceived?.Invoke(sharedDfuInstallation, new DfuErrorReceivedEventArgs(error, message));
        }
        
        public static event EventHandler<DfuLogReceivedEventArgs> DfuLogReceived;

        internal static void OnDfuLogReceived(SharedDfuInstallation sharedDfuInstallation, DfuLogLevel logLevel, string logMessage)
        {
            DfuLogReceived?.Invoke(sharedDfuInstallation, new DfuLogReceivedEventArgs(logLevel, logMessage));
        }

        public static event EventHandler<DfuProgressChangedEventArgs> DfuProgressChanged;

        public static void OnDfuProgressChanged(SharedDfuInstallation sharedDfuInstallation,
            double progress,
            double currentSpeedBytesPerSecond,
            double avgSpeedBytesPerSecond,
            TimeSpan duration,
            TimeSpan estimatedTimeLeft)
        {
            DfuProgressChanged?.Invoke(sharedDfuInstallation, new DfuProgressChangedEventArgs(progress, currentSpeedBytesPerSecond, avgSpeedBytesPerSecond, duration, estimatedTimeLeft));
        }
        
        public static event EventHandler<DfuStateChangedEventArgs> DfuStateChanged;
        
        public static void OnDfuStateChanged(SharedDfuInstallation sharedDfuInstallation, DfuState olsState, DfuState state)
        {
            DfuStateChanged?.Invoke(sharedDfuInstallation, new DfuStateChangedEventArgs(olsState, state));
        }
    }
}