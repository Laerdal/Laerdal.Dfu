using Laerdal.Dfu.Sample.Helpers;

using Plugin.BluetoothLE;

using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

using Xamarin.Forms;

namespace Laerdal.Dfu.Sample
{
    public partial class MainPage : ContentPage
    {
        public bool ScanResultFilter(IScanResult scanResult)
        {
            var manufacturer = scanResult.AdvertisementData.GetManufacturer();
            return manufacturer == ManufacturerIdConstants.Laerdal_Medical_AS;
        }

        public ObservableCollection<IDevice> Devices { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Devices = new ObservableCollection<IDevice>();
        }

    }
}