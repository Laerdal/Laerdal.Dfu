namespace Laerdal.Dfu.Specific
{
    public class DfuLogger : Laerdal.Dfu.iOS.LoggerDelegate
    {
        public override void Message(Laerdal.Dfu.iOS.LogLevel level, string message)
        {
            Events.OnDfuMessageReceived((Laerdal.Dfu.Enums.DfuLogLevel) level, message);
        }
    }
}
