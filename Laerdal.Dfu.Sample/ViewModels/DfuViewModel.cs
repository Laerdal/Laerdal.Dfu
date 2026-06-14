using Laerdal.Dfu.EventArgs;

namespace Laerdal.Dfu.Sample.ViewModels;

public class DfuViewModel : BaseViewModel, IQueryAttributable
{
    private DfuInstallation? _installation;

    private readonly INavigationService _navigation;
    private readonly ILogger<DfuViewModel> _logger;

    public DfuViewModel(INavigationService navigation, ILogger<DfuViewModel> logger)
    {
        _navigation = navigation;
        _logger = logger;

        SelectFileCommand = new AsyncRelayCommand(SelectFileAsync, () => !IsBusy);
        StartDfuCommand = new AsyncRelayCommand(StartDfuAsync, CanStartDfu);
        AbortCommand = new RelayCommand(AbortDfu, () => IsBusy);
    }

    public IBluetoothRemoteDevice? Device
    {
        get => GetValue<IBluetoothRemoteDevice?>(null);
        private set
        {
            SetValue(value);
            OnPropertyChanged(nameof(DeviceName));
            OnPropertyChanged(nameof(DeviceAddress));
        }
    }

    public string DeviceName => Device?.Name ?? "Unknown Device";
    public string DeviceAddress => Device?.Id ?? string.Empty;

    public string? FirmwareFilePath
    {
        get => GetValue<string?>(null);
        private set
        {
            SetValue(value);
            OnPropertyChanged(nameof(FirmwareFileName));
            StartDfuCommand.NotifyCanExecuteChanged();
        }
    }

    public string FirmwareFileName => FirmwareFilePath != null
        ? System.IO.Path.GetFileName(FirmwareFilePath)
        : "No file selected";

    public bool IsBusy
    {
        get => GetValue(false);
        private set
        {
            SetValue(value);
            SelectFileCommand.NotifyCanExecuteChanged();
            StartDfuCommand.NotifyCanExecuteChanged();
            AbortCommand.NotifyCanExecuteChanged();
        }
    }

    public double Progress
    {
        get => GetValue(0.0);
        private set => SetValue(value);
    }

    public string ProgressText
    {
        get => GetValue("0%");
        private set => SetValue(value);
    }

    public string StatusMessage
    {
        get => GetValue(string.Empty);
        private set => SetValue(value);
    }

    public bool HasError
    {
        get => GetValue(false);
        private set => SetValue(value);
    }

    public string ErrorMessage
    {
        get => GetValue(string.Empty);
        private set => SetValue(value);
    }

    public IAsyncRelayCommand SelectFileCommand { get; }
    public IAsyncRelayCommand StartDfuCommand { get; }
    public IRelayCommand AbortCommand { get; }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.TryGetValue("Device", out var device) && device is IBluetoothRemoteDevice d)
            Device = d;
    }

    private async Task SelectFileAsync()
    {
        try
        {
            var result = await FilePicker.Default.PickAsync(new PickOptions
            {
                PickerTitle = "Select firmware file",
                FileTypes = new FilePickerFileType(new Dictionary<DevicePlatform, IEnumerable<string>>
                {
                    { DevicePlatform.Android, new[] { "application/zip", "application/octet-stream" } },
                    { DevicePlatform.iOS, new[] { "public.zip-archive", "public.data" } },
                    { DevicePlatform.MacCatalyst, new[] { "public.zip-archive", "public.data" } },
                    { DevicePlatform.WinUI, new[] { ".zip", ".bin" } },
                })
            });

            if (result != null)
                FirmwareFilePath = result.FullPath;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "File picker failed");
        }
    }

    private bool CanStartDfu() => !IsBusy && FirmwareFilePath != null && Device != null;

    private async Task StartDfuAsync()
    {
        if (Device == null || FirmwareFilePath == null)
            return;

        _installation?.Dispose();
        _installation = new DfuInstallation(Device.Id, FirmwareFilePath);
        _installation.StateChanged += OnStateChanged;
        _installation.ProgressChanged += OnProgressChanged;
        _installation.ErrorOccured += OnErrorOccured;

        HasError = false;
        ErrorMessage = string.Empty;
        Progress = 0;
        ProgressText = "0%";
        StatusMessage = "Starting...";
        IsBusy = true;

        try
        {
            _logger.LogInformation("Starting DFU on {DeviceId} with {File}", Device.Id, FirmwareFilePath);
            _installation.Start();
            await _installation.Task;
            _logger.LogInformation("DFU completed");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "DFU failed");
            if (!HasError)  // ErrorOccured event may have already set this
                SetError(ex.Message);
        }
        finally
        {
            IsBusy = false;
        }
    }

    private void AbortDfu()
    {
        _installation?.Abort();
        StatusMessage = "Aborting...";
    }

    private void OnStateChanged(object? sender, DfuState state)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            StatusMessage = state.ToString();
            if (state == DfuState.Completed)
            {
                Progress = 1.0;
                ProgressText = "100%";
            }
        });
    }

    private void OnProgressChanged(object? sender, DfuProgressChangedEventArgs e)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            Progress = e.Progress;                      // already 0.0-1.0
            var speedKb = e.CurrentSpeedBytesPerSecond / 1024.0;
            ProgressText = $"{e.Progress * 100:F0}%  ({speedKb:F1} KB/s)";
        });
    }

    private void OnErrorOccured(object? sender, DfuErrorEventArgs e)
    {
        MainThread.BeginInvokeOnMainThread(() => SetError($"{e.Error}: {e.Message}"));
    }

    private void SetError(string message)
    {
        ErrorMessage = message;
        HasError = true;
        StatusMessage = "Failed";
    }
}
