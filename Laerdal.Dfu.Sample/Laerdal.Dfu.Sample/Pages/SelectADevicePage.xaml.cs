using Laerdal.Dfu.Sample.Helpers;
using Laerdal.Dfu.Sample.Models;
using Laerdal.Dfu.Sample.ViewModels;

using Plugin.BluetoothLE;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laerdal.Dfu.Sample.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectADevicePage : ContentPage
    {

        public SelectADevicePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            BluetoothDeviceViewModel.Instance.StartScanning();
        }

        private void DevicesListView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Navigation.PopAsync();
        }
/*
        public SemaphoreSlim ScanResultsSemaphoreSlim = new SemaphoreSlim(1);
        
        protected override async void OnAppearing()
        {
            DevicesListView.ItemsSource = ScanResults;
            
            if(!CrossBleAdapter.Current.IsScanning)
                CrossBleAdapter.Current.Scan().Subscribe(async scanResult =>
                {
                    await ScanResultsSemaphoreSlim.WaitAsync();
                    try
                    {
                        var existing = ScanResults.SingleOrDefault(sr => sr.Device.Uuid == scanResult.Device.Uuid);
                        if (existing != null)
                            existing.UpdateFrom(scanResult);
                        else
                        {
                            existing = new CustomScanResult(scanResult);
                            ScanResults.Add(existing);
                        }

                        if (App.SelectedDevice != null && existing.Device.Uuid == App.SelectedDevice.Uuid && DevicesListView.SelectedItem != existing)
                        {
                            DevicesListView.SelectedItem = existing;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                    finally
                    {
                        ScanResultsSemaphoreSlim.Release();
                    }
                });
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            if(!CrossBleAdapter.Current.IsScanning)
                CrossBleAdapter.Current.StopScan();

            DevicesListView.ItemsSource = null;
        }

        private void DevicesListView_OnItemSelected(object sender, SelectionChangedEventArgs selectionChangedEventArgs)
        {
            if (!(DevicesListView.SelectedItem is CustomScanResult scanResult))
                return;
            Debug.WriteLine($"Device selected : {scanResult.Device.Name} ({scanResult.Device.Uuid})");
            App.SelectedDevice = scanResult.Device;
        }
*/
        /*
        
        
        
        
        
        
        
        private async void DevicesListView_OnRefreshing(object sender, System.EventArgs e)
        {
            await RefreshAsync();
        }

        public async Task RefreshAsync()
        {
            
            if (DevicesListView.IsRefreshing)
                return;
            DevicesListView.IsRefreshing = true;
            try
            {
                Devices.Clear();

                // Stop previous scan
                if (CrossBleAdapter.Current.IsScanning)
                    CrossBleAdapter.Current.StopScan();

                Debug.WriteLine($"Start scanning");
                Title = "Scanning ...";
                await Task.Delay(5000);
                Debug.WriteLine($"Found {Devices.Count} devices !");
                DevicesListView.SelectedItem = Devices.Where(d => d.Uuid == App.SelectedDevice.Uuid);
                Title = "Available devices";
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        protected override void OnAppearing()
        {
            CrossBleAdapter.Current.WhenStatusChanged()
                           .Subscribe(status =>
                            {
                                Debug.WriteLine($"Status : {status}");
                            });
            if(!Devices.Any())
                RefreshAsync();
        }
*/
        /*
        protected override async void OnAppearing()
        {
            base.OnAppearing();


            await RequestLocationPermissionAsync();

            if (!CrossBleAdapter.Current.IsScanning)
                CrossBleAdapter.Current.Scan(new ScanConfig()
                                {
                                    ScanType = BleScanType.Balanced,
                                    AndroidUseScanBatching = true
                                })
                               .Subscribe(scanResult =>
                                {
                                    if (ScanResultFilter(scanResult))
                                    {
                                        if (Devices.All(d => d.Uuid.ToString() != scanResult.Device.Uuid.ToString()))
                                        {
                                            Devices.Add(scanResult.Device);
                                            Debug.WriteLine($"New device : {scanResult.Device.Name} ({scanResult.Device.Uuid})");
                                        }
                                    }
                                });
        }
        
        public bool ScanResultFilter(IScanResult scanResult)
        {
            var manufacturer = scanResult.AdvertisementData.GetManufacturer();
            return manufacturer == ManufacturerIdConstants.Laerdal_Medical_AS;
        }

        
        /// <summary>
        /// Ensures the LocationAlways permission is Granted
        /// </summary>
        /// <returns>True if Granted</returns>
        public static async System.Threading.Tasks.Task<bool> RequestLocationPermissionAsync()
        {
            if (await Xamarin.Essentials.Permissions.CheckStatusAsync<Xamarin.Essentials.Permissions.LocationAlways>() == Xamarin.Essentials.PermissionStatus.Granted)
            {
                return true;
            }

            return await Xamarin.Essentials.Permissions.RequestAsync<Xamarin.Essentials.Permissions.LocationAlways>() == Xamarin.Essentials.PermissionStatus.Granted;
        }*/
    }
}