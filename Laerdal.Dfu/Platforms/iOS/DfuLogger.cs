using Laerdal.Dfu.Bindings.iOS;

namespace Laerdal.Dfu
{
    public class DfuLogger : LoggerDelegate
    {
        public override void Message(LogLevel level, string message)
        {
            DfuEvents.OnDfuMessageReceived((Laerdal.Dfu.Enums.DfuLogLevel) level, message);
        }
    }
    
}