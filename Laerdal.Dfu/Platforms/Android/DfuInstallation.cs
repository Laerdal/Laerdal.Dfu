using Java.Lang;

using Laerdal.Dfu.Bindings.Android;

using System.Globalization;
using System.Linq;

namespace Laerdal.Dfu
{

    public partial class DfuInstallation
    {
        private DfuProgressDelegate DfuProgressDelegate { get; set; }

        private DfuLoggerDelegate DfuLoggerDelegate { get; set; }

        private DfuServiceInitiatorDelegate DfuServiceInitiatorDelegate { get; set; }

        private DfuServiceController DfuServiceController { get; set; }

        public DfuInstallation(string deviceId, string fileUrl) : base(deviceId, fileUrl)
        {
        }

        public override void Start(DfuConfiguration configuration = null)
        {
            if (DfuServiceController != null)
            {
                throw new System.Exception("Controller is already set.");
            }

            DfuProgressDelegate = new DfuProgressDelegate(this);
            DfuLoggerDelegate = new DfuLoggerDelegate(this);
            DfuServiceInitiatorDelegate = new DfuServiceInitiatorDelegate(this);
            if (configuration != null)
            {
                DfuServiceInitiatorDelegate.Configure(configuration);
                DfuServiceDelegate.DfuDeviceSelector = configuration.DfuDeviceSelectorDelegate;
            }

            DfuServiceController = DfuServiceInitiatorDelegate.Initiator.Start(Android.App.Application.Context, Class.FromType(typeof(DfuServiceDelegate)));
        }

        public override void Pause()
        {
            DfuServiceController?.Pause();
        }

        public override void Resume()
        {
            DfuServiceController?.Resume();
        }

        public override void Abort()
        {
            DfuServiceController?.Abort();
        }

        protected override void Dispose(bool disposing)
        {
            DfuProgressDelegate?.Dispose();
            DfuLoggerDelegate?.Dispose();
            DfuServiceInitiatorDelegate?.Dispose();
            DfuServiceController?.Dispose();
        }

        public bool CheckDeviceAddress(string deviceAddress)
        {
            if (deviceAddress == DeviceId)
            {
                return true;
            }

            var parsed = DeviceId.Split(':').Select(p => int.Parse(p, NumberStyles.HexNumber)).ToList();
            parsed[^1] += 1;
            var deviceAddressPlusOne = string.Join(":", parsed.Select(p => p.ToString("X2")));

            if (deviceAddress == deviceAddressPlusOne)
            {
                return true;
            }

            return false;
        }
    }
}
