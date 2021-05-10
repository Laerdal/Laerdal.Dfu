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
    public partial class MainPage_PickFirmwarePackageFrame
    {
        public MainPage_PickFirmwarePackageFrame()
        {
            InitializeComponent();
            GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(OnCLicked)
            });
        }

        private async void OnCLicked()
        {
            if (MainPageViewModel.Instance.HasStarted)
                return;
            await FirmwarePackageViewModel.Instance.PickFileAsync();
        }
    }
}