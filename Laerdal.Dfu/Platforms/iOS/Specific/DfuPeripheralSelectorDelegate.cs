using CoreBluetooth;
using Foundation;

namespace Laerdal.Dfu.Specific
{
    public class DfuPeripheralSelectorDelegate : Laerdal.Dfu.Bindings.iOS.IDFUPeripheralSelectorDelegate
    {
        private DfuInstallation DfuInstallation { get; }

        public DfuPeripheralSelectorDelegate(DfuInstallation dfuInstallation)
        {
            DfuInstallation = dfuInstallation;
        }

        public override bool Select(CBPeripheral peripheral,
                                    NSDictionary<NSString, NSObject> advertisementData,
                                    NSNumber rssi,
                                    string name)
        {
            return DfuInstallation.DeviceId == peripheral.Identifier.ToString();
        }
    }
}