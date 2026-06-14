namespace Laerdal.Dfu.Sample;

public partial class App : Application
{
    private readonly IServiceProvider _serviceProvider;

    public App(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        _serviceProvider = serviceProvider;
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        var scanPage = _serviceProvider.GetRequiredService<ScanPage>();
        var nav = new NavigationPage(scanPage);
#if IOS || MACCATALYST
        Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific.NavigationPage
            .SetPrefersLargeTitles(nav, false);
#endif
        return new Window(nav);
    }
}
