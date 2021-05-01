using Laerdal.Dfu.Sample.Helpers;
using Laerdal.Dfu.Sample.Models;

using Plugin.BluetoothLE;

using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace Laerdal.Dfu.Sample.ViewModels
{
    public class BluetoothDeviceViewModel : BindableObject
    {
        #region Singleton

        /// <summary>
        /// Singleton instance
        /// </summary>
        public static BluetoothDeviceViewModel Instance => _instance ?? (_instance = new BluetoothDeviceViewModel());

        private static BluetoothDeviceViewModel _instance;

        #endregion

        public ObservableCollection<CustomScanResult> ScanResults
        {
            get => GetValue<ObservableCollection<CustomScanResult>>();
            set => SetValue(value);
        }

        public CustomScanResult SelectedDevice
        {
            get => GetValue<CustomScanResult>();
            set
            {
                if (SetValue(value))
                {
                    DfuInstallationViewModel.Instance.DfuInstallation.DeviceId = $"{value?.Device?.Uuid}";
                }
            }
        }

        private BluetoothDeviceViewModel()
        {
            ScanResults = new ObservableCollection<CustomScanResult>();
            CrossBleAdapter.Current.WhenStatusChanged()
                           .Subscribe(status =>
                            {
                                Debug.WriteLine($"Status : {status}");
                            });
            RequestPermissionAsync();
        }

        public void StartScanning()
        {
            if (!CrossBleAdapter.Current.IsScanning)
                CrossBleAdapter.Current.Scan().Subscribe(OnScanResultReceived);
        }

        public async void OnScanResultReceived(IScanResult scanResult)
        {
            var existing = ScanResults.SingleOrDefault(sr => sr.Device.Uuid.ToString() == scanResult.Device.Uuid.ToString());
            if (existing != null)
                existing.UpdateFrom(scanResult);
            else
            {
                existing = new CustomScanResult(scanResult);
                lock (ScanResults)
                {
                    ScanResults.Add(existing);
                }
            }
        }

        public async void RequestPermissionAsync()
        {
            if (Xamarin.Forms.Device.RuntimePlatform != Xamarin.Forms.Device.Android)
                return;
            // Permission
            if (await Xamarin.Essentials.Permissions.CheckStatusAsync<Xamarin.Essentials.Permissions.LocationAlways>() != Xamarin.Essentials.PermissionStatus.Granted)
            {
                if (await Xamarin.Essentials.Permissions.RequestAsync<Xamarin.Essentials.Permissions.LocationAlways>() != Xamarin.Essentials.PermissionStatus.Granted)
                    throw new Exception($"Xamarin.Essentials.Permissions.LocationAlways was not granted");
            }
        }
    }
}