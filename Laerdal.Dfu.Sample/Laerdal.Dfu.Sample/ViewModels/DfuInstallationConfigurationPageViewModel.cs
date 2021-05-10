using Laerdal.Dfu.Enums;
using Laerdal.Dfu.EventArgs;
using Laerdal.Dfu.Sample.Helpers;

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace Laerdal.Dfu.Sample.ViewModels
{
    public class DfuInstallationConfigurationPageViewModel : BindableObject
    {
        #region Singleton

        /// <summary>
        /// Singleton instance
        /// </summary>
        public static DfuInstallationConfigurationPageViewModel Instance => _instance ?? (_instance = new DfuInstallationConfigurationPageViewModel());

        private static DfuInstallationConfigurationPageViewModel _instance;

        #endregion

        private static DfuInstallation GetDfuInstallation()
        {
            var output = new DfuInstallation($"{SelectADevicePageViewModel.Instance.SelectedDevice?.Device?.Uuid}", $"{FirmwarePackageViewModel.Instance.SelectedFirmwareFile?.FullName}");
            
            output.ErrorOccured += DfuInstallationOnErrorOccured;
            output.StateChanged += DfuInstallationOnStateChanged;
            output.ProgressChanged += DfuInstallationOnProgressChanged;

            return output;
        }

        private static void DfuInstallationOnProgressChanged(object sender, DfuProgressChangedEventArgs e)
        {
            Debug.WriteLine($"Progress : {e.Progress} ");
        }

        private static void DfuInstallationOnStateChanged(object sender, DfuState e)
        {
            Debug.WriteLine($"State : {e} ({(int)e}) ");
        }

        private static void DfuInstallationOnErrorOccured(object sender, DfuErrorEventArgs e)
        {
            Debug.WriteLine($"Error : {e.Error} ({(int)e.Error}) ");
            Debug.WriteLine($"Error Message : {e.Message}");
        }

        public DfuInstallation DfuInstallation
        {
            get => GetValue(GetDfuInstallation());
            set => SetValue(value);
        }
        
        public Dictionary<string, string> DfuInstallationConfiguration
        {
            get => GetValue<Dictionary<string, string>>();
            set => SetValue(value);
        }

        public void RefreshDfuInstallationConfiguration()
        {
            var output = new Dictionary<string, string>();
            if (DfuInstallation != null)
            {
                if (DfuInstallation.ForceDfu.HasValue)
                    output.Add("ForceDfu", $"{DfuInstallation.ForceDfu}");
                if (DfuInstallation.DisableResume.HasValue)
                    output.Add("DisableResume", $"{DfuInstallation.DisableResume}");
                if (!string.IsNullOrEmpty(DfuInstallation.AlternativeAdvertisingName))
                    output.Add("AlternativeAdvertisingName", $"{DfuInstallation.AlternativeAdvertisingName}");
                if (DfuInstallation.DataObjectPreparationDelay.HasValue)
                    output.Add("DataObjectPreparationDelay", $"{DfuInstallation.DataObjectPreparationDelay}");
                if (DfuInstallation.EnableUnsafeExperimentalButtonlessServiceInSecureDfu.HasValue)
                    output.Add("EnableUnsafeExperimentalButtonlessServiceInSecureDfu", $"{DfuInstallation.EnableUnsafeExperimentalButtonlessServiceInSecureDfu}");
                if (DfuInstallation.ForceScanningForNewAddressInLegacyDfu.HasValue)
                    output.Add("ForceScanningForNewAddressInLegacyDfu", $"{DfuInstallation.ForceScanningForNewAddressInLegacyDfu}");
                if (DfuInstallation.Foreground.HasValue)
                    output.Add("Foreground", $"{DfuInstallation.Foreground}");
                if (DfuInstallation.Mtu.HasValue)
                    output.Add("Mtu", $"{DfuInstallation.Mtu}");
                if (DfuInstallation.Scope.HasValue)
                    output.Add("Scope", $"{DfuInstallation.Scope}");
                if (DfuInstallation.DisableNotification.HasValue)
                    output.Add("DisableNotification", $"{DfuInstallation.DisableNotification}");
                if (DfuInstallation.KeepBond.HasValue)
                    output.Add("KeepBond", $"{DfuInstallation.KeepBond}");
                if (DfuInstallation.RestoreBond.HasValue)
                    output.Add("RestoreBond", $"{DfuInstallation.RestoreBond}");
                if (DfuInstallation.MbrSize.HasValue)
                    output.Add("MbrSize", $"{DfuInstallation.MbrSize}");
                if (DfuInstallation.DisableMtuRequest.HasValue)
                    output.Add("DisableMtuRequest", $"{DfuInstallation.DisableMtuRequest}");
                if (DfuInstallation.NumberOfRetries.HasValue)
                    output.Add("NumberOfRetries", $"{DfuInstallation.NumberOfRetries}");
                if (DfuInstallation.ConnectionTimeout.HasValue)
                    output.Add("ConnectionTimeout", $"{DfuInstallation.ConnectionTimeout}");
            }

            DfuInstallationConfiguration = output;
        }

        public void Reset()
        {
            DfuInstallation = GetDfuInstallation();
        }
    }
}