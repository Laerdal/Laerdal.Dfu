using Laerdal.Dfu.Bindings.Android;
using Laerdal.Dfu.Enums;

namespace Laerdal.Dfu
{
    public class DfuLogger : Java.Lang.Object, IDfuLogListener
    {
        public string DeviceAddress { get; }

        public DfuLogger(string deviceAddress)
        {
            DeviceAddress = deviceAddress;
            DfuServiceListenerHelper.RegisterLogListener(Android.App.Application.Context, this);
        }

        protected override void Dispose(bool disposing)
        {
            DfuServiceListenerHelper.UnregisterLogListener(Android.App.Application.Context, this);
            base.Dispose(disposing);
        }

        public void OnLogEvent(string deviceAddress, int level, string message)
        {
            if (deviceAddress != DeviceAddress)
                return;

            DfuEvents.OnDfuMessageReceived((DfuLogLevel) level, $"{deviceAddress} : {message}");
        }
    }
}