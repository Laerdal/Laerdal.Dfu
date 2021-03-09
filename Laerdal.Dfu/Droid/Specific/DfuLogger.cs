using Android.App;
using Laerdal.Dfu.Enums;

namespace Laerdal.Dfu.Specific
{
    public class DfuLogger : Java.Lang.Object, Laerdal.Dfu.Droid.IDfuLogListener
    {
        public string DeviceAddress { get; }

        public DfuLogger(string deviceAddress)
        {
            DeviceAddress = deviceAddress;
            Laerdal.Dfu.Droid.DfuServiceListenerHelper.RegisterLogListener(Application.Context, this);
        }

        protected override void Dispose(bool disposing)
        {
            Laerdal.Dfu.Droid.DfuServiceListenerHelper.UnregisterLogListener(Application.Context, this);
            base.Dispose(disposing);
        }

        public void OnLogEvent(string deviceAddress, int level, string message)
        {
            if (deviceAddress != DeviceAddress)
                return;

            Events.OnDfuMessageReceived((DfuLogLevel) level, $"{deviceAddress} : {message}");
        }
    }
}