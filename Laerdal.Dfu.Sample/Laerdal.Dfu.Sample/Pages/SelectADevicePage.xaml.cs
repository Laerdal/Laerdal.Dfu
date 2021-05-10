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
            SelectADevicePageViewModel.Instance.StartScanning();
        }

        private void DevicesListView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}