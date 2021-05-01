using Laerdal.Dfu.Sample.ViewModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laerdal.Dfu.Sample.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DfuInstallationConfigurationPage : ContentPage
    {
        public DfuInstallationConfigurationPage()
        {
            InitializeComponent();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            DfuInstallationViewModel.Instance.RefreshDfuInstallationConfiguration();
        }

        private void Button_OnClicked(object sender, System.EventArgs e)
        {
            DfuInstallationViewModel.Instance.Reset();
            Navigation.PopAsync();
        }
    }
}