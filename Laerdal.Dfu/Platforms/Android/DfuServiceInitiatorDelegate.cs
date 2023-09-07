using Android.OS;

using Laerdal.Dfu.Bindings.Android;

using System;

namespace Laerdal.Dfu
{
    public class DfuServiceInitiatorDelegate : IDisposable
    {
        public DfuServiceInitiator Initiator { get; private set; }
        
        private DfuInstallation DfuInstallation { get; set; }

        public DfuServiceInitiatorDelegate(DfuInstallation dfuInstallation)
        {
            DfuInstallation = dfuInstallation;
            Initiator = new DfuServiceInitiator(DfuInstallation.DeviceId).SetZip(DfuInstallation.FileUrl);
        }
        
        public void Dispose()
        {
            Initiator?.Dispose();
            DfuInstallation = null;
        }
        
        public void Configure(DfuConfiguration configuration)
        {
            SetAlternativeAdvertisingName(configuration);
            SetDataObjectPreparationDelay(configuration);
            SetDisableResume(configuration);
            SetUnsafeExperimentalButtonlessServiceInSecureDfuEnabled(configuration);
            SetForceDfu(configuration);
            SetForceScanningForNewAddressInLegacyDfu(configuration);
            SetPacketsReceiptNotifications(configuration);
            SetDisableMtuRequest(configuration);
            SetDisableNotification(configuration);
            SetMbrSize(configuration);
            SetScope(configuration);
            SetForeground(configuration);
            SetKeepBond(configuration);
            SetRestoreBond(configuration);
            SetMtu(configuration);
            SetNumberOfRetries(configuration);
            SetScanTimeout(configuration);
            SetRebootTime(configuration);
            
            // For Oreo progress
            if ((int) Build.VERSION.SdkInt >= 26)
            {
                DfuServiceInitiator.CreateDfuNotificationChannel(Android.App.Application.Context);
            }

            // public DfuServiceInitiator SetCurrentMtu(int mtu)
            // public DfuServiceInitiator SetCustomUuidsForButtonlessDfuWithBondSharing(UUID buttonlessDfuServiceUuid, UUID buttonlessDfuControlPointUuid)
            // public DfuServiceInitiator SetCustomUuidsForButtonlessDfuWithoutBondSharing(UUID buttonlessDfuServiceUuid, UUID buttonlessDfuControlPointUuid)
            // public DfuServiceInitiator SetCustomUuidsForExperimentalButtonlessDfu(UUID buttonlessDfuServiceUuid, UUID buttonlessDfuControlPointUuid)
            // public DfuServiceInitiator SetCustomUuidsForLegacyDfu(UUID dfuServiceUuid, UUID dfuControlPointUuid, UUID dfuPacketUuid, UUID dfuVersionUuid)
            // public DfuServiceInitiator SetCustomUuidsForSecureDfu(UUID dfuServiceUuid, UUID dfuControlPointUuid, UUID dfuPacketUuid)
        }
        
        private void SetNumberOfRetries(DfuConfiguration configuration)
        {
            // NumberOfRetries
            if (configuration.NumberOfRetries.HasValue)
            {
                Initiator = Initiator.SetNumberOfRetries(configuration.NumberOfRetries.Value);
            }
        }

        private void SetMtu(DfuConfiguration configuration)
        {
            // Mtu
            if (configuration.Mtu.HasValue)
            {
                Initiator = Initiator.SetMtu(configuration.Mtu.Value);
            }
        }
        
        private void SetScanTimeout(DfuConfiguration configuration)
        {
            Initiator = Initiator.SetScanTimeout(configuration.ScanTimeout ?? DfuServiceInitiator.DefaultScanTimeout);
        }
        
        private void SetRebootTime(DfuConfiguration configuration)
        {
            Initiator = Initiator.SetRebootTime(configuration.RebootTime ?? DfuServiceInitiator.DefaultScanTimeout);
        }

        private void SetRestoreBond(DfuConfiguration configuration)
        {
            // RestoreBond
            if (configuration.RestoreBond.HasValue)
            {
                Initiator = Initiator.SetRestoreBond(configuration.RestoreBond.Value);
            }
        }

        private void SetKeepBond(DfuConfiguration configuration)
        {
            // KeepBond
            if (configuration.KeepBond.HasValue)
            {
                Initiator = Initiator.SetKeepBond(configuration.KeepBond.Value);
            }
        }

        private void SetForeground(DfuConfiguration configuration)
        {
            // Foreground
            if (configuration.Foreground.HasValue)
            {
                Initiator = Initiator.SetForeground(configuration.Foreground.Value);
            }
        }

        private void SetScope(DfuConfiguration configuration)
        {
            // Scope
            if (configuration.Scope.HasValue)
            {
                Initiator = Initiator.SetScope((int) configuration.Scope.Value);
            }
        }

        private void SetMbrSize(DfuConfiguration configuration)
        {
            // MbrSize
            Initiator = Initiator.SetMbrSize(configuration.MbrSize ?? DfuServiceInitiator.DefaultMbrSize);
        }

        private void SetDisableNotification(DfuConfiguration configuration)
        {
            // DisableNotification
            if (configuration.DisableNotification.HasValue)
            {
                Initiator = Initiator.SetDisableNotification(configuration.DisableNotification.Value);
            }
        }

        private void SetDisableMtuRequest(DfuConfiguration configuration)
        {
            // DisableMtuRequest
            if (configuration.DisableMtuRequest ?? false)
            {
                Initiator = Initiator.DisableMtuRequest();
            }
        }

        private void SetForceDfu(DfuConfiguration configuration)
        {
            // ForceDfu
            if (configuration.ForceDfu.HasValue)
            {
                Initiator = Initiator.SetForceDfu(configuration.ForceDfu.Value);
            }
        }

        private void SetUnsafeExperimentalButtonlessServiceInSecureDfuEnabled(DfuConfiguration configuration)
        {
            // EnableUnsafeExperimentalButtonlessServiceInSecureDfu
            if (configuration.EnableUnsafeExperimentalButtonlessServiceInSecureDfu.HasValue)
            {
                Initiator = Initiator.SetUnsafeExperimentalButtonlessServiceInSecureDfuEnabled(configuration.EnableUnsafeExperimentalButtonlessServiceInSecureDfu.Value);
            }
        }

        private void SetForceScanningForNewAddressInLegacyDfu(DfuConfiguration configuration)
        {
            // ForceScanningForNewAddressInLegacyDfu
            if (configuration.ForceScanningForNewAddressInLegacyDfu.HasValue)
            {
                Initiator = Initiator.SetForceScanningForNewAddressInLegacyDfu(configuration.ForceScanningForNewAddressInLegacyDfu.Value);
            }
        }

        private void SetPacketsReceiptNotifications(DfuConfiguration configuration)
        {
            // PacketsReceiptNotifications
            Initiator = Initiator.SetPacketsReceiptNotificationsEnabled(configuration.PacketReceiptNotificationParameter.HasValue);
            Initiator = Initiator.SetPacketsReceiptNotificationsValue(configuration.PacketReceiptNotificationParameter ?? DfuServiceInitiator.DefaultPrnValue);
        }

        private void SetDataObjectPreparationDelay(DfuConfiguration configuration)
        {
            // DataObjectPreparationDelay
            Initiator = Initiator.SetPrepareDataObjectDelay((long) (configuration.DataObjectPreparationDelay ?? 0));
        }

        private void SetDisableResume(DfuConfiguration configuration)
        {
            // DisableResume
            if (configuration.DisableResume ?? false)
            {
                Initiator = Initiator.DisableResume();
            }
        }

        private void SetAlternativeAdvertisingName(DfuConfiguration configuration)
        {
            // AlternativeAdvertisingName
            if (!string.IsNullOrEmpty(configuration.AlternativeAdvertisingName))
            {
                Initiator = Initiator.SetDeviceName(configuration.AlternativeAdvertisingName);
            }
        }
    }
}
