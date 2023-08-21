using CoreBluetooth;

using Foundation;

using Laerdal.Dfu.Bindings.iOS;

namespace Laerdal.Dfu
{
    public class DfuPeripheralSelectorDelegate : DFUPeripheralSelectorDelegate
    {
        private DfuInstallation DfuInstallation { get; }

        public DfuPeripheralSelectorDelegate(DfuInstallation dfuInstallation)
        {
            DfuInstallation = dfuInstallation;
        }


        public override CBUUID[] FilterByHint(CBUUID dfuServiceUuid)
        {
            return null;
        }

        public override bool Select(CBPeripheral peripheral,
                                    NSDictionary<NSString, NSObject> advertisementData,
                                    NSNumber rssi,
                                    string name)
        {
            if (DfuInstallation.DeviceId != peripheral.Identifier.ToString())
            {
                return false;
            }
            return true;
        }
    }
}