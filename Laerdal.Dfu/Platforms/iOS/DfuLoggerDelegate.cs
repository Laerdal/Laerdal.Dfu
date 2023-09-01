using Laerdal.Dfu.Bindings.iOS;

namespace Laerdal.Dfu
{
    public class DfuLoggerDelegate : LoggerDelegate
    {
        private DfuInstallation DfuInstallation { get; }

        public DfuLoggerDelegate(DfuInstallation dfuInstallation)
        {
            DfuInstallation = dfuInstallation;
        }
        
        public override void Message(LogLevel level, string message)
        {
            DfuInstallation.OnDfuLogReceived((Laerdal.Dfu.Enums.DfuLogLevel) level, message);
        }
    }
    
}