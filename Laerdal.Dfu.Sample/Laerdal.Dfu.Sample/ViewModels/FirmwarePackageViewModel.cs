using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Xamarin.Essentials;
using Xamarin.Forms;

namespace Laerdal.Dfu.Sample.ViewModels
{
    public class FirmwarePackageViewModel : Helpers.BindableObject
    {
        #region Singleton

        /// <summary>
        /// Singleton instance
        /// </summary>
        public static FirmwarePackageViewModel Instance => _instance ?? (_instance = new FirmwarePackageViewModel());

        private static FirmwarePackageViewModel _instance;

        #endregion

        public FileInfo SelectedFirmwareFile
        {
            get => GetValue<FileInfo>();
            set
            {
                if (SetValue(value))
                {
                    DfuInstallationConfigurationPageViewModel.Instance.DfuInstallation.FileUrl = value?.FullName;
                }
            }
        }

        public async Task PickFileAsync()
        {
            try
            {
                var options = new PickOptions
                {
                    PickerTitle = "Please select a zip file",
                };
                var result = await FilePicker.PickAsync(options);
                if (result != null)
                {
                    var newFilePath = await CopyFile(result);
                    if (!string.IsNullOrEmpty(newFilePath))
                        SelectedFirmwareFile = new FileInfo(newFilePath);
                }
            }
            catch (Exception ex)
            {
                // The user canceled or something went wrong
            }
        }

        private async Task<string> CopyFile(FileResult fileResult)
        {
            if (await Xamarin.Essentials.Permissions.CheckStatusAsync<Xamarin.Essentials.Permissions.StorageWrite>() != Xamarin.Essentials.PermissionStatus.Granted)
                if (await Xamarin.Essentials.Permissions.RequestAsync<Xamarin.Essentials.Permissions.StorageWrite>() != Xamarin.Essentials.PermissionStatus.Granted)
                    return null;

            var outputFilePath = Path.Combine(FileSystem.AppDataDirectory, fileResult.FileName);
            if (File.Exists(outputFilePath))
                File.Delete(outputFilePath);

            using (var fileStream = new FileStream(outputFilePath, FileMode.Create))
            using (var stream = await fileResult.OpenReadAsync())
            {
                for (var i = 0; i < stream.Length; i++)
                {
                    fileStream.WriteByte((byte) stream.ReadByte());
                }

                fileStream.Close();
                stream.Close();
            }

            return outputFilePath;
        }
    }
}