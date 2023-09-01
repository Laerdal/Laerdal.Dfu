using Laerdal.Dfu.Enums;

namespace Laerdal.Dfu
{
    public class DfuConfiguration
    {
        /// <summary>
        /// Android :
        ///     IDfuDeviceSelector
        /// iOS :
        ///     DFUPeripheralSelectorDelegate
        /// </summary>
        public DfuDeviceSelectorDelegate DfuDeviceSelectorDelegate {get; set;}
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetDeviceName(string name)
        /// iOS :
        ///     public string? AlternativeAdvertisingName {get; set;}
        ///     public bool AlternativeAdvertisingNameEnabled {get; set;}
        /// </summary>
        public string AlternativeAdvertisingName {get; set;}

        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetPrepareDataObjectDelay(long delay)
        /// iOS :
        ///     public double DataObjectPreparationDelay {get; set;}
        /// </summary>
        public double? DataObjectPreparationDelay {get; set;}
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator DisableResume()
        /// iOS :
        ///     public bool DisableResume {get; set;}
        /// </summary>
        public bool? DisableResume {get; set;}

        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetUnsafeExperimentalButtonlessServiceInSecureDfuEnabled(bool enable)
        /// iOS :
        ///     public bool EnableUnsafeExperimentalButtonlessServiceInSecureDfu {get; set;}
        /// </summary>
        public bool? EnableUnsafeExperimentalButtonlessServiceInSecureDfu {get; set;}

        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetForceDfu(bool force)
        /// iOS :
        ///     public bool ForceDfu {get; set;}
        /// </summary>
        public bool? ForceDfu {get; set;}

        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetForceScanningForNewAddressInLegacyDfu(bool force)
        /// iOS :
        ///     public bool ForceScanningForNewAddressInLegacyDfu {get; set;}
        /// </summary>
        public bool? ForceScanningForNewAddressInLegacyDfu {get; set;}

        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetPacketsReceiptNotificationsEnabled(bool enabled)
        ///     public DfuServiceInitiator SetPacketsReceiptNotificationsValue(int number)
        /// iOS :
        ///     public ushort PacketReceiptNotificationParameter {get; set;}
        /// </summary>
        public ushort? PacketReceiptNotificationParameter {get; set;}
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator DisableMtuRequest()
        /// </summary>
        public bool? DisableMtuRequest {get; set;}
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetDisableNotification(bool disableNotification)
        /// </summary>
        public bool? DisableNotification {get; set;}
        
        /// <summary>
        /// Android :
        ///     public const int DefaultMbrSize = 4096;
        ///     public DfuServiceInitiator SetMbrSize(int mbrSize)
        /// </summary>
        public int? MbrSize {get; set;}
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetScope(int scope)
        ///     public const int ScopeApplication = 2;
        ///     public const int ScopeSystemComponents = 1;
        /// </summary>
        public DfuServiceScope? Scope {get; set;}
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetForeground(bool foreground)
        /// </summary>
        public bool? Foreground {get; set;}
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetKeepBond(bool keepBond)
        /// </summary>
        public bool? KeepBond {get; set;}
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetRestoreBond(bool keepBond)
        /// </summary>
        public bool? RestoreBond {get; set;}
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetMtu(int mtu)
        /// </summary>
        public int? Mtu {get; set;}
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetNumberOfRetries(int max)
        /// </summary>
        public int? NumberOfRetries {get; set;}
        
        /// <summary>
        /// iOS :
        ///     public double ConnectionTimeout {get; set;}
        /// </summary>
        public long? ConnectionTimeout {get; set;}
        
        /// <summary>
        /// Android :
        ///     public DfuServiceInitiator SetScanTimeout(long scanTimeout)
        /// </summary>
        public long? ScanTimeout {get; set;}
        
        // TODO : CustomUuids
    }
}
