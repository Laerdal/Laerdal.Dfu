namespace Laerdal.Dfu.Sample.ViewModels;

public class ScanViewModel : BaseViewModel
{
    private static readonly Guid LegacyDfuServiceUuid = new("00001530-1212-EFDE-1523-785FEABCD123");
    private static readonly Guid SecureDfuServiceUuid = new("0000FE59-0000-1000-8000-00805F9B34FB");

    private IReadOnlyList<IBluetoothRemoteDevice> _allDevices = [];

    private readonly IBluetoothScanner _scanner;
    private readonly INavigationService _navigation;
    private readonly ILogger<ScanViewModel> _logger;

    public ScanViewModel(IBluetoothScanner scanner, INavigationService navigation, ILogger<ScanViewModel> logger)
    {
        _scanner = scanner;
        _navigation = navigation;
        _logger = logger;

        StartScanCommand = new AsyncRelayCommand(StartScanAsync, () => !IsScanning);
        StopScanCommand = new AsyncRelayCommand(StopScanAsync, () => IsScanning);
        SelectDeviceCommand = new AsyncRelayCommand<IBluetoothRemoteDevice>(SelectDeviceAsync);

        _scanner.RunningStateChanged += OnRunningStateChanged;
        _scanner.DeviceListChanged += OnDeviceListChanged;
    }

    public ObservableCollection<IBluetoothRemoteDevice> Devices { get; } = new();

    public bool IsScanning
    {
        get => GetValue(false);
        private set => SetValue(value);
    }

    public int DeviceCount => Devices.Count;

    public IAsyncRelayCommand StartScanCommand { get; }
    public IAsyncRelayCommand StopScanCommand { get; }
    public IAsyncRelayCommand<IBluetoothRemoteDevice> SelectDeviceCommand { get; }

    public static bool HasDfuService(IBluetoothRemoteDevice device)
    {
        var guids = device.LastAdvertisement?.ServicesGuids;
        if (guids == null)
            return false;
        return guids.Any(g => g == LegacyDfuServiceUuid || g == SecureDfuServiceUuid);
    }

    public override async ValueTask OnAppearingAsync()
    {
        await base.OnAppearingAsync();
        await StartScanAsync();
    }

    public override async ValueTask OnDisappearingAsync()
    {
        await base.OnDisappearingAsync();
        await StopScanAsync();
    }

    private async Task StartScanAsync()
    {
        try
        {
            await _scanner.StartScanningAsync(new ScanningOptions { IgnoreNamelessAdvertisements = false });
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to start BLE scan");
            await ShowAlertAsync("Scan Error", ex.Message);
        }
    }

    private async Task StopScanAsync()
    {
        try
        {
            await _scanner.StopScanningAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to stop BLE scan");
        }
    }

    private async Task SelectDeviceAsync(IBluetoothRemoteDevice? device)
    {
        if (device == null)
            return;
        await _navigation.NavigateToAsync<DfuPage>(new Dictionary<string, object> { ["Device"] = device });
    }

    private void OnRunningStateChanged(object? sender, System.EventArgs e)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            IsScanning = _scanner.IsRunning;
            StartScanCommand.NotifyCanExecuteChanged();
            StopScanCommand.NotifyCanExecuteChanged();
        });
    }

    private void OnDeviceListChanged(object? sender, DeviceListChangedEventArgs e)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            _allDevices = [.. _scanner.GetDevices()];
            Devices.Clear();
            foreach (var d in _allDevices.OrderByDescending(d => d.SignalStrengthDbm))
                Devices.Add(d);
            OnPropertyChanged(nameof(DeviceCount));
        });
    }

    private static async Task ShowAlertAsync(string title, string message)
    {
        var page = Application.Current?.Windows.FirstOrDefault()?.Page;
        if (page != null)
            await page.DisplayAlertAsync(title, message, "OK");
    }
}
