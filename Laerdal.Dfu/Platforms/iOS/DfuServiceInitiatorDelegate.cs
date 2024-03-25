using CoreFoundation;

using Foundation;

using Laerdal.Dfu.Bindings.iOS;

using System;

namespace Laerdal.Dfu
{
    public class DfuServiceInitiatorDelegate : IDisposable
    {
        private static Func<DispatchQueue> Queue { get; set; } = () => DispatchQueue.GetGlobalQueue(DispatchQueuePriority.Default);
        private static Func<DispatchQueue> DelegateQueue { get; set; } = () => DispatchQueue.GetGlobalQueue(DispatchQueuePriority.Default);
        private static Func<DispatchQueue> ProgressQueue { get; set; } = () => DispatchQueue.GetGlobalQueue(DispatchQueuePriority.Default);
        private static Func<DispatchQueue> LoggerQueue { get; set; } = () => DispatchQueue.GetGlobalQueue(DispatchQueuePriority.Default);
        
        
        public DFUServiceInitiator Initiator { get; private set; }
        
        private DfuInstallation DfuInstallation { get; set; }
        
        private DFUFirmware Firmware { get; set;}
        
        public DfuServiceInitiatorDelegate(DfuInstallation dfuInstallation)
        {
            DfuInstallation = dfuInstallation;
            
            Firmware = new DFUFirmware(new NSUrl(DfuInstallation.FileUrl, false), out NSError error);
            if (error != null)
                throw new Exception(error.LocalizedDescription);

            Initiator = new DFUServiceInitiator(Queue.Invoke(),
                                                DelegateQueue.Invoke(),
                                                ProgressQueue.Invoke(),
                                                LoggerQueue.Invoke(),
                                                null)
            {
                Logger = DfuInstallation.DfuLoggerDelegate,
                WeakProgressDelegate = DfuInstallation.DfuProgressDelegate,
                WeakDelegate = DfuInstallation.DfuProgressDelegate
            }.WithFirmware(Firmware);
        }
        
        public void Dispose()
        {
            Initiator?.Dispose();
            Firmware?.Dispose();
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
            SetConnectionTimeout(configuration);
            SetDeviceSelector(configuration);
        }
        
        private void SetDeviceSelector(DfuConfiguration configuration)
        {
            // DfuDeviceSelectorDelegate
            if (configuration.DfuDeviceSelectorDelegate != null)
                Initiator.PeripheralSelector = configuration.DfuDeviceSelectorDelegate;
        }

        private void SetConnectionTimeout(DfuConfiguration configuration)
        {
            // Scope
            if (configuration.ConnectionTimeout.HasValue)
                Initiator.ConnectionTimeout = configuration.ConnectionTimeout.Value;
        }

        private void SetForceDfu(DfuConfiguration configuration)
        {
            // ForceDfu
            if (configuration.ForceDfu.HasValue)
                Initiator.ForceDfu = configuration.ForceDfu.Value;
        }

        private void SetUnsafeExperimentalButtonlessServiceInSecureDfuEnabled(DfuConfiguration configuration)
        {
            // EnableUnsafeExperimentalButtonlessServiceInSecureDfu
            if (configuration.EnableUnsafeExperimentalButtonlessServiceInSecureDfu.HasValue)
                Initiator.ForceScanningForNewAddressInLegacyDfu = configuration.EnableUnsafeExperimentalButtonlessServiceInSecureDfu.Value;
        }

        private void SetForceScanningForNewAddressInLegacyDfu(DfuConfiguration configuration)
        {
            // ForceScanningForNewAddressInLegacyDfu
            if (configuration.ForceScanningForNewAddressInLegacyDfu.HasValue)
                Initiator.ForceScanningForNewAddressInLegacyDfu = configuration.ForceScanningForNewAddressInLegacyDfu.Value;
        }

        private void SetPacketsReceiptNotifications(DfuConfiguration configuration)
        {
            // PacketsReceiptNotifications
            if (configuration.PacketReceiptNotificationParameter.HasValue)
                Initiator.PacketReceiptNotificationParameter = configuration.PacketReceiptNotificationParameter.Value;
        }

        private void SetDataObjectPreparationDelay(DfuConfiguration configuration)
        {
            // DataObjectPreparationDelay
            if (configuration.DataObjectPreparationDelay.HasValue)
                Initiator.DataObjectPreparationDelay = configuration.DataObjectPreparationDelay.Value;
        }

        private void SetDisableResume(DfuConfiguration configuration)
        {
            // DisableResume
            if (configuration.DisableResume.HasValue)
                Initiator.DisableResume = configuration.DisableResume.Value;
        }

        private void SetAlternativeAdvertisingName(DfuConfiguration configuration)
        {
            // AlternativeAdvertisingName
            Initiator.AlternativeAdvertisingNameEnabled = !string.IsNullOrEmpty(configuration.AlternativeAdvertisingName);
            Initiator.AlternativeAdvertisingName = configuration.AlternativeAdvertisingName;
        }
    }
}
