using Plugin.BluetoothLE;
using Plugin.BluetoothLE.Server;

namespace Laerdal.Dfu.Sample.Helpers
{
    public static class AdvertisementDataExtensions
    {
        public static int GetManufacturerId(this IAdvertisementData advertisementData)
        {
            if (advertisementData?.ManufacturerData == null || advertisementData.ManufacturerData.Length < 2)
            {
                return -1;
            }

            return ((advertisementData.ManufacturerData.GetOrDefault(1) & 0xFF) << 8) + (advertisementData.ManufacturerData.GetOrDefault(0) & 0xFF);
        }
        
        public static ManufacturerIdConstants GetManufacturer(this IAdvertisementData advertisementData)
        {
            return (ManufacturerIdConstants) advertisementData.GetManufacturerId();
        }
        
    }
}