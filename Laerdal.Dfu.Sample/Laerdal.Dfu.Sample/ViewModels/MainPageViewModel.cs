using Laerdal.Dfu.Sample.Helpers;

using System.Collections.Generic;

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
        

    }
}