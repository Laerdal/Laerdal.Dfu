using Laerdal.Dfu.Sample.ViewModels;

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
            DfuInstallationConfigurationPageViewModel.Instance.RefreshDfuInstallationConfiguration();
        }

        private void Button_OnClicked(object sender, System.EventArgs e)
        {
            DfuInstallationConfigurationPageViewModel.Instance.Reset();
            Navigation.PopAsync();
        }
    }
}