using Android.App;
using Android.OS;

using Java.Lang;

using Laerdal.Dfu.Droid;
using Laerdal.Dfu.Specific;

using System;
using System.Globalization;
using System.Linq;

namespace Laerdal.Dfu
{
    public partial class DfuInstallation
    {
        public Func<DfuServiceInitiator, DfuServiceInitiator> CustomDfuServiceInitiatorConfiguration { get; set; } = (dfuInitiator) => dfuInitiator;
        
        private void SetInitiator()
        {
            DfuProgressListener = new DfuProgressListener(this);
            DfuLogger = new DfuLogger(DeviceId);

            Initiator = new Laerdal.Dfu.Droid.DfuServiceInitiator(DeviceId).SetZip(FileUrl);
            
            // PacketsReceiptNotifications
            Initiator = Initiator.SetPacketsReceiptNotificationsEnabled(PacketReceiptNotificationParameter.HasValue);
            Initiator = Initiator.SetPacketsReceiptNotificationsValue(PacketReceiptNotificationParameter ?? DfuServiceInitiator.DefaultPrnValue);
            
            // DataObjectPreparationDelay
            Initiator = Initiator.SetPrepareDataObjectDelay((long) (DataObjectPreparationDelay ?? 0));

            // DisableResume
            if (DisableResume ?? false)
            {
                Initiator = Initiator.DisableResume();
            }

            // AlternativeAdvertisingName
            if (!string.IsNullOrEmpty(AlternativeAdvertisingName))
            {
                Initiator = Initiator.SetDeviceName(AlternativeAdvertisingName);
            }
            
            // ForceScanningForNewAddressInLegacyDfu
            if (ForceScanningForNewAddressInLegacyDfu.HasValue)
            {
                Initiator = Initiator.SetForceScanningForNewAddressInLegacyDfu(ForceScanningForNewAddressInLegacyDfu.Value);
            }
            
            // EnableUnsafeExperimentalButtonlessServiceInSecureDfu
            if (EnableUnsafeExperimentalButtonlessServiceInSecureDfu.HasValue)
            {
                Initiator = Initiator.SetUnsafeExperimentalButtonlessServiceInSecureDfuEnabled(EnableUnsafeExperimentalButtonlessServiceInSecureDfu.Value);
            }
            
            // ForceDfu
            if (ForceDfu.HasValue)
            {
                Initiator = Initiator.SetForceDfu(ForceDfu.Value);
            }
            
            // DisableMtuRequest
            if (DisableMtuRequest ?? false)
            {
                Initiator = Initiator.DisableMtuRequest();
            }

            // DisableNotification
            if (DisableNotification.HasValue)
            {
                Initiator = Initiator.SetDisableNotification(DisableNotification.Value);
            }
            
            // MbrSize
            Initiator = Initiator.SetMbrSize(MbrSize ?? DfuServiceInitiator.DefaultMbrSize);
            
            // Scope
            if (Scope.HasValue)
            {
                Initiator = Initiator.SetScope((int) Scope.Value);
            }
            
            // Foreground
            if (Foreground.HasValue)
            {
                Initiator = Initiator.SetForeground(Foreground.Value);
            }
            
            // KeepBond
            if (KeepBond.HasValue)
            {
                Initiator = Initiator.SetKeepBond(KeepBond.Value);
            }
            
            // RestoreBond
            if (RestoreBond.HasValue)
            {
                Initiator = Initiator.SetRestoreBond(RestoreBond.Value);
            }
            
            // Mtu
            if (Mtu.HasValue)
            {
                Initiator = Initiator.SetMtu(Mtu.Value);
            }
            
            // Phy
            if (Phy.HasValue)
            {
                Initiator = Initiator.SetPhy((int) Phy.Value);
            }
            
            // NumberOfRetries
            if (NumberOfRetries.HasValue)
            {
                Initiator = Initiator.SetNumberOfRetries(NumberOfRetries.Value);
            }
            
            // For Oreo progress
            if ((int) Build.VERSION.SdkInt >= 26)
            {
                Laerdal.Dfu.Droid.DfuServiceInitiator.CreateDfuNotificationChannel(Application.Context);
            }
            
            Initiator = CustomDfuServiceInitiatorConfiguration?.Invoke(Initiator);
            
            // public DfuServiceInitiator SetCurrentMtu(int mtu)
            // public DfuServiceInitiator SetCustomUuidsForButtonlessDfuWithBondSharing(UUID buttonlessDfuServiceUuid, UUID buttonlessDfuControlPointUuid)
            // public DfuServiceInitiator SetCustomUuidsForButtonlessDfuWithoutBondSharing(UUID buttonlessDfuServiceUuid, UUID buttonlessDfuControlPointUuid)
            // public DfuServiceInitiator SetCustomUuidsForExperimentalButtonlessDfu(UUID buttonlessDfuServiceUuid, UUID buttonlessDfuControlPointUuid)
            // public DfuServiceInitiator SetCustomUuidsForLegacyDfu(UUID dfuServiceUuid, UUID dfuControlPointUuid, UUID dfuPacketUuid, UUID dfuVersionUuid)
            // public DfuServiceInitiator SetCustomUuidsForSecureDfu(UUID dfuServiceUuid, UUID dfuControlPointUuid, UUID dfuPacketUuid)
        }

        public Laerdal.Dfu.Droid.DfuServiceInitiator Initiator { get; private set; }

        public Laerdal.Dfu.Droid.DfuServiceController Controller { get; private set; }

        private DfuProgressListener DfuProgressListener { get; set;}

        private DfuLogger DfuLogger { get; set;}

        public DfuInstallation(string deviceId, string fileUrl) : base(deviceId, fileUrl)
        {
        }
        public DfuInstallation() : base()
        {
        }
        
        public override void Start()
        {
            if (Controller != null)
            {
                throw new System.Exception("Controller is already set.");
            }

            SetInitiator();
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