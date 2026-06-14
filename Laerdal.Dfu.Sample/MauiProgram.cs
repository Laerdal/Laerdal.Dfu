using Bluetooth.Maui;

namespace Laerdal.Dfu.Sample;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
        builder.Logging.AddDebug();
        builder.Services.AddLogging(configure => configure.AddDebug());
#endif

        builder.Services.AddBluetoothServices();

        builder.Services.AddSingleton<INavigationService, NavigationService>();

        builder.Services.AddTransient<ScanPage>();
        builder.Services.AddTransient<ScanViewModel>();
        builder.Services.AddTransient<DfuPage>();
        builder.Services.AddTransient<DfuViewModel>();

        return builder.Build();
    }
}
