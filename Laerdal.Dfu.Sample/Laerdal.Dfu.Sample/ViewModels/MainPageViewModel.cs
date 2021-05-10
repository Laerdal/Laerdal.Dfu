using Laerdal.Dfu.Sample.Helpers;

namespace Laerdal.Dfu.Sample.ViewModels
{
    public class MainPageViewModel : BindableObject
    {
        #region Singleton

        /// <summary>
        /// Singleton instance
        /// </summary>
        public static MainPageViewModel Instance => _instance ?? (_instance = new MainPageViewModel());

        private static MainPageViewModel _instance;

        #endregion

        public bool HasStarted
        {
            get => GetValue<bool>();
            set => SetValue(value);
        }

        public async void Start()
        {
            if (HasStarted)
                return;
            HasStarted = true;
            DfuInstallationConfigurationPageViewModel.Instance.DfuInstallation.Start();
        }

    }
}