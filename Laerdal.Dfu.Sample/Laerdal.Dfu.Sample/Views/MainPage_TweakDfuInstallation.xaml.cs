using Laerdal.Dfu.Sample.Pages;

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
    public partial class MainPage_TweakDfuInstallation
    {
        public MainPage_TweakDfuInstallation()
        {
            InitializeComponent();
            GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(OnCLicked)
            });
        }

        private void OnCLicked()
        {
            Navigation.PushAsync(new DfuInstallationConfigurationPage());
        }
    }
}