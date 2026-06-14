namespace Laerdal.Dfu.Sample.Infrastructure;

public abstract partial class BaseViewModel : INotifyPropertyChanged
{
    private readonly ConcurrentDictionary<string, object?> _values = new();

    protected BaseViewModel(ILogger? logger = null)
    {
        Logger = logger;
    }

    protected ILogger? Logger { get; }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected T GetValue<T>(T defaultValue, [CallerMemberName] string? propertyName = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(propertyName);
        if (_values.TryGetValue(propertyName, out var value) && value is T tValue)
            return tValue;
        _values.TryAdd(propertyName, defaultValue);
        return defaultValue;
    }

    protected bool SetValue<T>(T value, [CallerMemberName] string? propertyName = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(propertyName);
        if (_values.TryGetValue(propertyName, out var existing) && Equals(existing, value))
            return false;
        _values.AddOrUpdate(propertyName, value, (_, _) => value);
        OnPropertyChanged(propertyName);
        return true;
    }

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public virtual ValueTask OnAppearingAsync() => ValueTask.CompletedTask;

    public virtual ValueTask OnDisappearingAsync() => ValueTask.CompletedTask;
}
