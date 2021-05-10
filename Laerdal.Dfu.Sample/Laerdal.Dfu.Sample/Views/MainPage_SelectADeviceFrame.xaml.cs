using Laerdal.Dfu.Sample.Pages;
using Laerdal.Dfu.Sample.ViewModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laerdal.Dfu.Sample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage_SelectADeviceFrame
    {
        public MainPage_SelectADeviceFrame()
        {
            InitializeComponent();
            GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(OnCLicked)
            });
        }

        private void OnCLicked()
        {
            if (MainPageViewModel.Instance.HasStarted)
                return;
            Navigation.PushAsync(new SelectADevicePage());
        }
    }
}