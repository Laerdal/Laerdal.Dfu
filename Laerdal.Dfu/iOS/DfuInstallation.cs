using CoreFoundation;
using Foundation;

using Laerdal.Dfu.iOS;
using Laerdal.Dfu.Specific;

using System;

namespace Laerdal.Dfu
{
    public partial class DfuInstallation
    {
        public static Func<DispatchQueue> Queue { get; set; } = () => DispatchQueue.GetGlobalQueue(DispatchQueuePriority.Default);
        public static Func<DispatchQueue> DelegateQueue { get; set; } = () => DispatchQueue.GetGlobalQueue(DispatchQueuePriority.Default);
        public static Func<DispatchQueue> ProgressQueue { get; set; } = () => DispatchQueue.GetGlobalQueue(DispatchQueuePriority.Default);
        public static Func<DispatchQueue> LoggerQueue { get; set; } = () => DispatchQueue.GetGlobalQueue(DispatchQueuePriority.Default);

        public Func<DFUServiceInitiator, DFUServiceInitiator> CustomDfuServiceInitiatorConfiguration { get; set; } = (dfuInitiator) => dfuInitiator;
        
        private void SetInitiator()
        {
            DfuProgressDelegate = new DfuProgressDelegate(this);
            DfuServiceDelegate = new DfuServiceDelegate(this);
            DfuPeripheralSelectorDelegate = new DfuPeripheralSelectorDelegate(this);

            Firmware = new Laerdal.Dfu.iOS.DFUFirmware(new NSUrl(FileUrl, false));
            
            Initiator = new Laerdal.Dfu.iOS.DFUServiceInitiator(Queue.Invoke(), 
                                                                DelegateQueue.Invoke(), 
                                                                ProgressQueue.Invoke(), 
                                                                LoggerQueue.Invoke())
            {
                Logger = new DfuLogger(),
                WeakProgressDelegate = DfuProgressDelegate,
                WeakDelegate = DfuServiceDelegate,
            };
            Initiator = Initiator.WithFirmware(Firmware);

            // PacketsReceiptNotifications
            if (PacketReceiptNotificationParameter.HasValue)
                Initiator.PacketReceiptNotificationParameter = PacketReceiptNotificationParameter.Value;
            
            // DataObjectPreparationDelay
            if (DataObjectPreparationDelay.HasValue)
                Initiator.DataObjectPreparationDelay = DataObjectPreparationDelay.Value;

            // DisableResume
            if (DisableResume.HasValue)
                Initiator.DisableResume = DisableResume.Value;

            // AlternativeAdvertisingName
            Initiator.AlternativeAdvertisingNameEnabled = !string.IsNullOrEmpty(AlternativeAdvertisingName);
            Initiator.AlternativeAdvertisingName = AlternativeAdvertisingName;
            
            // ForceScanningForNewAddressInLegacyDfu
            if (ForceScanningForNewAddressInLegacyDfu.HasValue)
                Initiator.ForceScanningForNewAddressInLegacyDfu = ForceScanningForNewAddressInLegacyDfu.Value;
            
            // EnableUnsafeExperimentalButtonlessServiceInSecureDfu
            if (EnableUnsafeExperimentalButtonlessServiceInSecureDfu.HasValue)
                Initiator.ForceScanningForNewAddressInLegacyDfu = EnableUnsafeExperimentalButtonlessServiceInSecureDfu.Value;
            
            // ForceDfu
            if (ForceDfu.HasValue)
                Initiator.ForceDfu = ForceDfu.Value;

            // ConnectionTimeout
            if (ConnectionTimeout.HasValue)
                Initiator.ConnectionTimeout = ConnectionTimeout.Value;

            Initiator = CustomDfuServiceInitiatorConfiguration?.Invoke(Initiator);

            // public DFUUuidHelper UuidHelper {get; set;}
        }

        public Laerdal.Dfu.iOS.DFUServiceInitiator Initiator { get; private set;  } 

        public Laerdal.Dfu.iOS.DFUServiceController Controller { get; private set; }

        public Laerdal.Dfu.iOS.DFUFirmware Firmware { get; private set;}
        
        private DfuProgressDelegate DfuProgressDelegate { get; set;}

        private DfuServiceDelegate DfuServiceDelegate { get; set;}

        private DfuPeripheralSelectorDelegate DfuPeripheralSelectorDelegate { get; set;}
        
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
            Controller = Initiator.StartWithTargetWithIdentifier(new NSUuid(DeviceId));
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
            if (disposing)
            {
                Initiator?.Dispose();
                Controller?.Dispose();
                Firmware?.Dispose();
            }
        }
    }
}