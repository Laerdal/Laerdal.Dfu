using CoreFoundation;
using Foundation;
using System;

using Laerdal.Dfu.Bindings.iOS;

namespace Laerdal.Dfu
{
    public partial class DfuInstallation
    {
        internal DfuProgressDelegate DfuProgressDelegate { get; private set;}
        
        internal DfuLoggerDelegate DfuLoggerDelegate { get; private set;}
        
        private DfuServiceInitiatorDelegate DfuServiceInitiatorDelegate { get; set; }
        
        private DFUServiceController DfuServiceController { get; set; }

        
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
            }
            
            DfuServiceController = DfuServiceInitiatorDelegate.Initiator.StartWithTargetWithIdentifier(new NSUuid(DeviceId));
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
    }
}