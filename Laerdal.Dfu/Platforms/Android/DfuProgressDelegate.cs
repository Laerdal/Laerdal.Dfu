using Laerdal.Dfu.Bindings.Android;
using Laerdal.Dfu.Enums;

namespace Laerdal.Dfu
{
    public class DfuProgressDelegate : DfuProgressListenerAdapter
    {
        private DfuInstallation DfuInstallation { get; }

        public DfuProgressDelegate(DfuInstallation dfuInstallation)
        {
            DfuInstallation = dfuInstallation;
            DfuServiceListenerHelper.RegisterProgressListener(Android.App.Application.Context, this);
        }

        protected override void Dispose(bool disposing)
        {
            DfuServiceListenerHelper.UnregisterProgressListener(Android.App.Application.Context, this);
            base.Dispose(disposing);
        }

        public override void OnError(string deviceAddress,
                                     int error,
                                     int errorType,
                                     string message)
        {
            if (!DfuInstallation.CheckDeviceAddress(deviceAddress)) { return; }

            DfuInstallation.OnDfuErrorReceived((DfuError) error, message);
            DfuInstallation.OnDfuStateChanged(DfuState.Error);
        }

        public override void OnDeviceConnected(string deviceAddress)
        {
            if (!DfuInstallation.CheckDeviceAddress(deviceAddress)) { return; }

            DfuInstallation.OnDfuStateChanged(DfuState.Connected);
        }

        public override void OnDeviceConnecting(string deviceAddress)
        {
            if (!DfuInstallation.CheckDeviceAddress(deviceAddress)) { return; }

            DfuInstallation.OnDfuStateChanged(DfuState.Connecting);
        }

        public override void OnDeviceDisconnected(string deviceAddress)
        {
            if (!DfuInstallation.CheckDeviceAddress(deviceAddress)) { return; }

            DfuInstallation.OnDfuStateChanged(DfuState.Disconnected);
        }

        public override void OnDeviceDisconnecting(string deviceAddress)
        {
            if (!DfuInstallation.CheckDeviceAddress(deviceAddress)) { return; }

            DfuInstallation.OnDfuStateChanged(DfuState.Disconnecting);
        }

        public override void OnDfuAborted(string deviceAddress)
        {
            if (!DfuInstallation.CheckDeviceAddress(deviceAddress)) { return; }

            DfuInstallation.OnDfuStateChanged(DfuState.Aborted);
            
        }

        public override void OnDfuCompleted(string deviceAddress)
        {
            if (!DfuInstallation.CheckDeviceAddress(deviceAddress)) { return; }

            DfuInstallation.OnDfuStateChanged(DfuState.Completed);
        }

        public override void OnFirmwareValidating(string deviceAddress)
        {
            if (!DfuInstallation.CheckDeviceAddress(deviceAddress)) { return; }

            DfuInstallation.OnDfuStateChanged(DfuState.Validating);
        }

        public override void OnDfuProcessStarted(string deviceAddress)
        {
            if (!DfuInstallation.CheckDeviceAddress(deviceAddress)) { return; }

            DfuInstallation.OnDfuStateChanged(DfuState.Started);
        }

        public override void OnDfuProcessStarting(string deviceAddress)
        {
            if (!DfuInstallation.CheckDeviceAddress(deviceAddress)) { return; }

            DfuInstallation.OnDfuStateChanged(DfuState.Starting);
        }

        public override void OnEnablingDfuMode(string deviceAddress)
        {
            if (!DfuInstallation.CheckDeviceAddress(deviceAddress)) { return; }

            DfuInstallation.OnDfuStateChanged(DfuState.EnablingDfuMode);
        }

        public override void OnProgressChanged(string deviceAddress,
                                               int percent,
                                               float speed,
                                               float avgSpeed,
                                               int currentPart,
                                               int partsTotal)
        {
            if (!DfuInstallation.CheckDeviceAddress(deviceAddress)) { return; }

            DfuInstallation.OnDfuStateChanged(DfuState.Uploading);
            DfuInstallation.OnProgressChanged(percent / 100D, speed, avgSpeed);
        }
    }
}