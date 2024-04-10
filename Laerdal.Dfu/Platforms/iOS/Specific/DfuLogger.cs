namespace Laerdal.Dfu.Specific
{
    public class DfuLogger : Laerdal.Dfu.Bindings.iOS.LoggerDelegate
    {
        public override void Message(Laerdal.Dfu.Bindings.iOS.LogLevel level, string message)
        {
            Events.OnDfuMessageReceived((Laerdal.Dfu.Enums.DfuLogLevel) level, message);
        }
    }
    
}