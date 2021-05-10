using Laerdal.Dfu.Sample.Helpers;
using Laerdal.Dfu.Sample.Pages;

using Plugin.BluetoothLE;

using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Laerdal.Dfu.Sample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}