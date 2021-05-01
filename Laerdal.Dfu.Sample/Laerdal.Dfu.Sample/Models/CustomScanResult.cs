using Laerdal.Dfu.Sample.Helpers;

using Plugin.BluetoothLE;

using System;
using System.Collections.Concurrent;
using System.Linq;

namespace Laerdal.Dfu.Sample.Models
{
    public class CustomScanResult : BindableObject, IScanResult, IEquatable<CustomScanResult>
    {
        public string Name
        {
            get => GetValue("No name");
            private set
            {
                if(!string.IsNullOrEmpty(value))
                    SetValue(value);
            }
        }

        public CustomScanResult(IDevice device, int rssi, IAdvertisementData advertisementData)
        {
            UpdateFrom(device, rssi, advertisementData);
        }
        
        public CustomScanResult(IScanResult scanResult)
        {
            UpdateFrom(scanResult);
        }

        public void UpdateFrom(IScanResult scanResult)
        {
            UpdateFrom(scanResult.Device, scanResult.Rssi, scanResult.AdvertisementData);
        }
        
        public void UpdateFrom(IDevice device, int rssi, IAdvertisementData advertisementData)
        {
            Device = device;
            Rssi = rssi;
            AdvertisementData = advertisementData;
            Name = device.Name;
        }

        public IDevice Device 
        {
            get => GetValue<IDevice>();
            private set => SetValue(value);
        }

        private readonly ConcurrentQueue<int> _rssiHistory = new ConcurrentQueue<int>();
        public int Rssi
        {
            get => GetValue<int>();
            private set
            {
                SetValue(value);
                _rssiHistory.Enqueue(value, 10);
                SignalStrengthPercent = RssiHelper.RssiToSignalStrengthConverter(_rssiHistory.Average());
            }
        }
        
        /// <summary>
        /// Signal strength in % (between 0.00 and 1.00)
        /// </summary>
        public double SignalStrengthPercent 
        {
            get => GetValue<double>();
            private set => SetValue(value);
        }

        public IAdvertisementData AdvertisementData 
        {
            get => GetValue<IAdvertisementData>();
            private set => SetValue(value);
        }

        public bool Equals(CustomScanResult other)
        {
            if (other?.Device?.Uuid == null)
                return false;
            return other.Device.Uuid.ToString() == Device.Uuid.ToString();
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            return Equals((CustomScanResult) obj);
        }

        public override int GetHashCode()
        {
            return Device.Uuid.GetHashCode();
        }

        public static bool operator ==(CustomScanResult left, CustomScanResult right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(CustomScanResult left, CustomScanResult right)
        {
            return !Equals(left, right);
        }
    }
}