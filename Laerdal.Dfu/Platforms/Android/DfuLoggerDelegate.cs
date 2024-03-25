using Laerdal.Dfu.Bindings.Android;
using Laerdal.Dfu.Enums;

namespace Laerdal.Dfu
{
    public class DfuLoggerDelegate : Java.Lang.Object, IDfuLogListener
    {
        private DfuInstallation DfuInstallation { get; }

        public DfuLoggerDelegate(DfuInstallation dfuInstallation)
        {
            DfuInstallation = dfuInstallation;
            DfuServiceListenerHelper.RegisterLogListener(Android.App.Application.Context, this);
        }

        protected override void Dispose(bool disposing)
        {
            DfuServiceListenerHelper.UnregisterLogListener(Android.App.Application.Context, this);
            base.Dispose(disposing);
        }
        
        public void OnLogEvent(string deviceAddress, int level, string message)
        {
            if (!DfuInstallation.CheckDeviceAddress(deviceAddress)) { return; }

            DfuInstallation.OnDfuLogReceived((DfuLogLevel) level, message);
        }
    }
}