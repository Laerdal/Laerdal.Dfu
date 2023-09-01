namespace Laerdal.Dfu
{
    public abstract partial class DfuDeviceSelectorDelegate
    {
        public virtual string[] FilterByHint(string dfuServiceUuid)
        {
            return null;
        }

        public virtual bool Matches(string deviceName,
            string deviceAddress,
            int rssi,
            byte[] scanRecord,
            string originalAddress,
            string incrementedAddress)
        {
            return originalAddress == deviceAddress || incrementedAddress == deviceAddress;
        }
    }
}
