using Android.App;
using Android.OS;

using Java.Lang;

using Laerdal.Dfu.Specific;

using System.Globalization;
using System.Linq;

namespace Laerdal.Dfu
{
    public partial class DfuInstallation
    {
        public Laerdal.Dfu.Droid.DfuServiceInitiator Initiator { get; }

        public Laerdal.Dfu.Droid.DfuServiceController Controller { get; private set; }

        private DfuProgressListener DfuProgressListener { get; }

        private DfuLogger DfuLogger { get; }

        public DfuInstallation(string deviceId, string fileUrl) : base(deviceId, fileUrl)
        {
            DfuProgressListener = new DfuProgressListener(this);
            DfuLogger = new DfuLogger(deviceId);

            // For Oreo progress
            if ((int) Build.VERSION.SdkInt >= 26)
            {
                Laerdal.Dfu.Droid.DfuServiceInitiator.CreateDfuNotificationChannel(Application.Context);
            }

            Initiator = new Laerdal.Dfu.Droid.DfuServiceInitiator(deviceId).SetZip(fileUrl).SetPacketsReceiptNotificationsEnabled(true).SetPacketsReceiptNotificationsValue(Laerdal.Dfu.Droid.DfuServiceInitiator.DefaultPrnValue).SetUnsafeExperimentalButtonlessServiceInSecureDfuEnabled(true).SetDisableNotification(true);
        }

        public override void Start()
        {
            if (Controller != null)
            {
                throw new System.Exception("Controller is already set.");
            }

            Controller = Initiator.Start(Application.Context, Class.FromType(typeof(DfuService)));
        }

        public override void Pause()
        {
            Controller?.Pause();
        }

        public override void Resume()
        {
            Controller?.Resume();
        }

        public override void Abort()
        {
            Controller?.Abort();
        }

        protected override void Dispose(bool disposing)
        {
            DfuProgressListener?.Dispose();
            if (disposing)
            {
                Initiator?.Dispose();
                Controller?.Dispose();
                DfuLogger?.Dispose();
            }
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