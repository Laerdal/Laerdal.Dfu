namespace Laerdal.Xamarin.Dfu.Specific
{
    public class DfuLogger : Laerdal.Xamarin.Dfu.iOS.LoggerDelegate
    {
        public override void Message(Laerdal.Xamarin.Dfu.iOS.LogLevel level, string message)
        {
            Events.OnDfuMessageReceived((Laerdal.Xamarin.Dfu.Enums.DfuLogLevel) level, message);
        }
    }
    
}