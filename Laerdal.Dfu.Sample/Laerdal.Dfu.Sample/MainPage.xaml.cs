using Laerdal.Dfu.Sample.Helpers;
using Laerdal.Dfu.Sample.ViewModels;

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
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, System.EventArgs e)
        {
            MainPageViewModel.Instance.Start();
        }
    }
}