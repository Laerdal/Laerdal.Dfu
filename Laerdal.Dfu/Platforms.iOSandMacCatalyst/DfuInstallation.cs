using CoreFoundation;
using Foundation;
using Laerdal.Dfu.Specific;

namespace Laerdal.Dfu
{
    public partial class DfuInstallation
    {
        public static Func<DispatchQueue> Queue { get; set; } = () => DispatchQueue.GetGlobalQueue(DispatchQueuePriority.Default);
        public static Func<DispatchQueue> LoggerQueue { get; set; } = () => DispatchQueue.GetGlobalQueue(DispatchQueuePriority.Default);
        public static Func<DispatchQueue> DelegateQueue { get; set; } = () => DispatchQueue.GetGlobalQueue(DispatchQueuePriority.Default);
        public static Func<DispatchQueue> ProgressQueue { get; set; } = () => DispatchQueue.GetGlobalQueue(DispatchQueuePriority.Default);

        public Func<Laerdal.Dfu.Bindings.iOS.DFUServiceInitiator, Laerdal.Dfu.Bindings.iOS.DFUServiceInitiator> CustomDfuServiceInitiatorConfiguration { get; set; } = dfuInitiator => dfuInitiator;
        private void SetInitiator()
        {
            DfuServiceDelegate = new DfuServiceDelegate(this);
            DfuProgressDelegate = new DfuProgressDelegate(this);
            DfuPeripheralSelectorDelegate = new DfuPeripheralSelectorDelegate(this);

            Firmware = new Laerdal.Dfu.Bindings.iOS.DFUFirmware(new NSUrl(FileUrl, isDir: false), out _);

            Initiator = new Laerdal.Dfu.Bindings.iOS.DFUServiceInitiator(
                queue: Queue.Invoke(),
                loggerQueue: LoggerQueue.Invoke(),
                delegateQueue: DelegateQueue.Invoke(),
                progressQueue: ProgressQueue.Invoke(),
                centralManagerOptions: null
            )
            {
                Logger = new DfuLogger(),
                WeakDelegate = DfuServiceDelegate,
                WeakProgressDelegate = DfuProgressDelegate,
            };

            Initiator = Initiator.WithFirmware(Firmware);

            if (PacketReceiptNotificationParameter.HasValue)
            {
                Initiator.PacketReceiptNotificationParameter = PacketReceiptNotificationParameter.Value;

            }
            if (DataObjectPreparationDelay.HasValue)
            {
                Initiator.DataObjectPreparationDelay = DataObjectPreparationDelay.Value;
            }

            if (DisableResume.HasValue)
            {
                Initiator.DisableResume = DisableResume.Value;
            }

            Initiator.AlternativeAdvertisingName = AlternativeAdvertisingName;

            Initiator.AlternativeAdvertisingNameEnabled = !string.IsNullOrEmpty(AlternativeAdvertisingName);
            if (ForceScanningForNewAddressInLegacyDfu.HasValue)
            {
                Initiator.ForceScanningForNewAddressInLegacyDfu = ForceScanningForNewAddressInLegacyDfu.Value;

            }
            if (EnableUnsafeExperimentalButtonlessServiceInSecureDfu.HasValue)
            {
                Initiator.ForceScanningForNewAddressInLegacyDfu = EnableUnsafeExperimentalButtonlessServiceInSecureDfu.Value;

            }
            if (ForceDfu.HasValue)
            {
                Initiator.ForceDfu = ForceDfu.Value;
            }

            if (ConnectionTimeout.HasValue)
            {
                Initiator.ConnectionTimeout = ConnectionTimeout.Value;
            }

            Initiator = CustomDfuServiceInitiatorConfiguration?.Invoke(Initiator);
        }

        public Laerdal.Dfu.Bindings.iOS.DFUFirmware Firmware { get; private set; }public Laerdal.Dfu.Bindings.iOS.DFUServiceInitiator Initiator { get; private set; }
        public Laerdal.Dfu.Bindings.iOS.DFUServiceController Controller { get; private set; }

        private DfuServiceDelegate DfuServiceDelegate { get;set; }

        private DfuProgressDelegate DfuProgressDelegate { get; set; }

        

        private DfuPeripheralSelectorDelegate DfuPeripheralSelectorDelegate { get; set; }
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
            if (!disposing)
                return;

            DfuServiceDelegate?.Dispose();
            DfuServiceDelegate = null;
            
            DfuProgressDelegate?.Dispose();
            DfuProgressDelegate = null;
            
            DfuPeripheralSelectorDelegate?.Dispose();
            DfuPeripheralSelectorDelegate = null;
            
            Firmware?.Dispose();
            Firmware = null;
            
            Initiator?.Dispose();
            Initiator = null;
            
            Controller?.Dispose();
            Controller = null;
        }
    }
}