using CoreBluetooth;

using Foundation;

using Laerdal.Dfu.Bindings.iOS;

using System;
using System.Linq;

namespace Laerdal.Dfu
{
    public partial class DfuDeviceSelectorDelegate : DFUPeripheralSelectorDelegate
    {
        public override CBUUID[] FilterByHint(CBUUID dfuServiceUuid) => FilterByHint(dfuServiceUuid.Uuid).Select(CBUUID.FromString).ToArray();
        
        public override bool Select(
            CBPeripheral peripheral, 
            NSDictionary<NSString, NSObject> advertisementData, 
            NSNumber rssi, 
            string name) => Matches(name, peripheral.Identifier.ToString(), rssi.Int32Value, 
                                    new AdvertisementData(advertisementData).ManufacturerData?.ToArray() ?? Array.Empty<byte>(), 
                                    peripheral.Identifier.ToString(), peripheral.Identifier.ToString());
    }
}