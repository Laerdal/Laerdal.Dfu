using Android.App;
using Android.OS;

using Java.Lang;

using Laerdal.Dfu.Specific;

using System;
using System.Globalization;
using System.Linq;

namespace Laerdal.Dfu
{
    public partial class DfuInstallation
    {
        public Func<Laerdal.Dfu.Bindings.Android.DfuServiceInitiator, Laerdal.Dfu.Bindings.Android.DfuServiceInitiator> CustomDfuServiceInitiatorConfiguration { get; set; } = dfuInitiator => dfuInitiator;
        
        private void SetInitiator()
        {
            DfuLogger = new DfuLogger(DeviceId);
            DfuProgressListener = new DfuProgressListener(this);

            Initiator = new Laerdal.Dfu.Bindings.Android.DfuServiceInitiator(DeviceId).SetZip(FileUrl)!;
            Initiator = Initiator.SetPacketsReceiptNotificationsEnabled(PacketReceiptNotificationParameter.HasValue)!; // PacketsReceiptNotifications
            Initiator = Initiator.SetPacketsReceiptNotificationsValue(PacketReceiptNotificationParameter ?? Laerdal.Dfu.Bindings.Android.DfuServiceInitiator.DefaultPrnValue)!;
            Initiator = Initiator.SetPrepareDataObjectDelay((long) (DataObjectPreparationDelay ?? 0))!; // DataObjectPreparationDelay

            if (DisableResume ?? false)
            {
                Initiator = Initiator.DisableResume()!;
            }

            if (!string.IsNullOrEmpty(AlternativeAdvertisingName))
            {
                Initiator = Initiator.SetDeviceName(AlternativeAdvertisingName)!;
            }
            
            if (ForceScanningForNewAddressInLegacyDfu.HasValue)
            {
                Initiator = Initiator.SetForceScanningForNewAddressInLegacyDfu(ForceScanningForNewAddressInLegacyDfu.Value)!;
            }
            
            if (EnableUnsafeExperimentalButtonlessServiceInSecureDfu.HasValue)
            {
                Initiator = Initiator.SetUnsafeExperimentalButtonlessServiceInSecureDfuEnabled(EnableUnsafeExperimentalButtonlessServiceInSecureDfu.Value)!;
            }

            if (ForceDfu.HasValue)
            {
                Initiator = Initiator.SetForceDfu(ForceDfu.Value)!;
            }
            
            if (DisableMtuRequest ?? false)
            {
                Initiator = Initiator.DisableMtuRequest()!;
            }

            if (DisableNotification.HasValue)
            {
                Initiator = Initiator.SetDisableNotification(DisableNotification.Value)!;
            }
            
            Initiator = Initiator.SetMbrSize(MbrSize ?? Laerdal.Dfu.Bindings.Android.DfuServiceInitiator.DefaultMbrSize)!;
            
            if (Scope.HasValue)
            {
                Initiator = Initiator.SetScope((int) Scope.Value)!;
            }
            
            if (Foreground.HasValue)
            {
                Initiator = Initiator.SetForeground(Foreground.Value)!;
            }

            if (KeepBond.HasValue)
            {
                Initiator = Initiator.SetKeepBond(KeepBond.Value)!;
            }
            
            if (RestoreBond.HasValue)
            {
                Initiator = Initiator.SetRestoreBond(RestoreBond.Value)!;
            }
            
            if (Mtu.HasValue)
            {
                Initiator = Initiator.SetMtu(Mtu.Value)!;
            }

            if (NumberOfRetries.HasValue)
            {
                Initiator = Initiator.SetNumberOfRetries(NumberOfRetries.Value)!;
            }
            
            // For Oreo progress
            if ((int) Build.VERSION.SdkInt >= 26)
            {
                Laerdal.Dfu.Bindings.Android.DfuServiceInitiator.CreateDfuNotificationChannel(Android.App.Application.Context);
            }
            
            Initiator = CustomDfuServiceInitiatorConfiguration?.Invoke(Initiator)!;
            
            // public DfuServiceInitiator SetCurrentMtu(int mtu)
            // public DfuServiceInitiator SetCustomUuidsForButtonlessDfuWithBondSharing(UUID buttonlessDfuServiceUuid, UUID buttonlessDfuControlPointUuid)
            // public DfuServiceInitiator SetCustomUuidsForButtonlessDfuWithoutBondSharing(UUID buttonlessDfuServiceUuid, UUID buttonlessDfuControlPointUuid)
            // public DfuServiceInitiator SetCustomUuidsForExperimentalButtonlessDfu(UUID buttonlessDfuServiceUuid, UUID buttonlessDfuControlPointUuid)
            // public DfuServiceInitiator SetCustomUuidsForLegacyDfu(UUID dfuServiceUuid, UUID dfuControlPointUuid, UUID dfuPacketUuid, UUID dfuVersionUuid)
            // public DfuServiceInitiator SetCustomUuidsForSecureDfu(UUID dfuServiceUuid, UUID dfuControlPointUuid, UUID dfuPacketUuid)
        }

        private DfuLogger DfuLogger { get; set;}
        private DfuProgressListener DfuProgressListener { get; set;}
        
        public Laerdal.Dfu.Bindings.Android.DfuServiceInitiator Initiator { get; private set; }
        public Laerdal.Dfu.Bindings.Android.DfuServiceController Controller { get; private set; }

        public DfuInstallation(string deviceId, string fileUrl) : base(deviceId, fileUrl)
        {
        }

        public DfuInstallation()
        {
        }
        
        public override void Start()
        {
            if (Controller != null)
                throw new System.Exception("Controller is already set.");

            SetInitiator();
            Controller = Initiator.Start(Android.App.Application.Context, Class.FromType(typeof(DfuService)));
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
            if (!disposing)
                return;

            DfuProgressListener?.Dispose();
            DfuProgressListener = null;
            
            Initiator?.Dispose();
            Initiator = null;
            
            Controller?.Dispose();
            Controller = null;
            
            DfuLogger?.Dispose();
            DfuLogger = null;
        }

        public bool CheckDeviceAddress(string deviceAddress)
        {
            if (deviceAddress == DeviceId)
                return true;

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