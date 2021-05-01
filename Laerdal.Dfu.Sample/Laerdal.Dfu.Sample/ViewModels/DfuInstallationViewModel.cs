using Laerdal.Dfu.Sample.Helpers;

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Laerdal.Dfu.Sample.ViewModels
{
    public class DfuInstallationViewModel : BindableObject
    {
        #region Singleton

        /// <summary>
        /// Singleton instance
        /// </summary>
        public static DfuInstallationViewModel Instance => _instance ?? (_instance = new DfuInstallationViewModel());

        private static DfuInstallationViewModel _instance;

        #endregion
        
        public DfuInstallation DfuInstallation
        {
            get => GetValue(new DfuInstallation($"{BluetoothDeviceViewModel.Instance.SelectedDevice?.Device?.Uuid}", $"{FirmwarePackageViewModel.Instance.SelectedFirmwareFile?.FullName}"));
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
            DfuInstallation = new DfuInstallation($"{BluetoothDeviceViewModel.Instance.SelectedDevice?.Device?.Uuid}", $"{FirmwarePackageViewModel.Instance.SelectedFirmwareFile?.FullName}");
        }
    }
}