using Laerdal.Dfu.EventArgs;
using System.Diagnostics;

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
            Laerdal.Dfu.Events.DfuErrorOccured += EventsOnDfuErrorOccured;
            Laerdal.Dfu.Events.DfuMessageReceived += EventsOnDfuMessageReceived;
            MainPage = new NavigationPage(new MainPage());
        }

        private void EventsOnDfuMessageReceived(object sender, DfuMessageReceivedEventArgs e)
        {
            Debug.WriteLine($"{e.LogLevel} : {e.Message}");
        }

        private void EventsOnDfuErrorOccured(object sender, DfuErrorEventArgs e)
        {
            Debug.WriteLine($"{e.Error}({(int)e.Error}) : {e.Message}");
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