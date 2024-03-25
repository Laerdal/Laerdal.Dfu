using Android.App;
using Laerdal.Dfu.Enums;

namespace Laerdal.Dfu.Specific
{
    public class DfuProgressListener : Laerdal.Dfu.Bindings.Android.DfuProgressListenerAdapter
    {
        private DfuInstallation DfuInstallation { get; }

        public DfuProgressListener(DfuInstallation dfuInstallation)
        {
            DfuInstallation = dfuInstallation;
            Laerdal.Dfu.Bindings.Android.DfuServiceListenerHelper.RegisterProgressListener(Android.App.Application.Context, this);
        }

        protected override void Dispose(bool disposing)
        {
            Laerdal.Dfu.Bindings.Android.DfuServiceListenerHelper.UnregisterProgressListener(Android.App.Application.Context, this);
            base.Dispose(disposing);
        }

        public override void OnError(string deviceAddress,
                                     int error,
                                     int errorType,
                                     string message)
        {
            if (!DfuInstallation.CheckDeviceAddress(deviceAddress)) { return; }

            DfuInstallation.OnDfuError((DfuError) error, message);
        }

        public override void OnDeviceConnected(string deviceAddress)
        {
            if (!DfuInstallation.CheckDeviceAddress(deviceAddress)) { return; }

            DfuInstallation.State = DfuState.Connected;
        }

        public override void OnDeviceConnecting(string deviceAddress)
        {
            if (!DfuInstallation.CheckDeviceAddress(deviceAddress)) { return; }

            DfuInstallation.State = DfuState.Connecting;
        }

        public override void OnDeviceDisconnected(string deviceAddress)
        {
            if (!DfuInstallation.CheckDeviceAddress(deviceAddress)) { return; }

            DfuInstallation.State = DfuState.Disconnected;
        }

        public override void OnDeviceDisconnecting(string deviceAddress)
        {
            if (!DfuInstallation.CheckDeviceAddress(deviceAddress)) { return; }

            DfuInstallation.State = DfuState.Disconnecting;
        }

        public override void OnDfuAborted(string deviceAddress)
        {
            if (!DfuInstallation.CheckDeviceAddress(deviceAddress)) { return; }

            DfuInstallation.State = DfuState.Aborted;
        }

        public override void OnDfuCompleted(string deviceAddress)
        {
            if (!DfuInstallation.CheckDeviceAddress(deviceAddress)) { return; }

            DfuInstallation.State = DfuState.Completed;
        }

        public override void OnFirmwareValidating(string deviceAddress)
        {
            if (!DfuInstallation.CheckDeviceAddress(deviceAddress)) { return; }

            DfuInstallation.State = DfuState.Validating;
        }

        public override void OnDfuProcessStarted(string deviceAddress)
        {
            if (!DfuInstallation.CheckDeviceAddress(deviceAddress)) { return; }

            DfuInstallation.State = DfuState.Started;
        }

        public override void OnDfuProcessStarting(string deviceAddress)
        {
            if (!DfuInstallation.CheckDeviceAddress(deviceAddress)) { return; }

            DfuInstallation.State = DfuState.Starting;
        }

        public override void OnEnablingDfuMode(string deviceAddress)
        {
            if (!DfuInstallation.CheckDeviceAddress(deviceAddress)) { return; }

            DfuInstallation.State = DfuState.EnablingDfuMode;
        }

        public override void OnProgressChanged(string deviceAddress,
                                               int percent,
                                               float speed,
                                               float avgSpeed,
                                               int currentPart,
                                               int partsTotal)
        {
            if (!DfuInstallation.CheckDeviceAddress(deviceAddress)) { return; }

            DfuInstallation.State = DfuState.Uploading;
            DfuInstallation.OnProgressChanged(percent / 100D, speed, avgSpeed);
        }
    }
}