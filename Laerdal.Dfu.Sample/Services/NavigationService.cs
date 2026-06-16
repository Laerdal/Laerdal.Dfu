namespace Laerdal.Dfu.Sample.Services;

public class NavigationService : INavigationService
{
    private readonly IServiceProvider _serviceProvider;

    public NavigationService(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    private INavigation? Navigation => Application.Current?.Windows.FirstOrDefault()?.Page?.Navigation;

    public async ValueTask NavigateToAsync<TPage>(IDictionary<string, object>? parameters = null)
        where TPage : Page
    {
        var page = _serviceProvider.GetRequiredService<TPage>();
        if (parameters != null && page is IQueryAttributable qa)
            qa.ApplyQueryAttributes(parameters);
        if (Navigation != null)
            await Navigation.PushAsync(page, true);
    }

    public async ValueTask NavigateBackAsync()
    {
        if (Navigation != null)
            await Navigation.PopAsync(true);
    }
}
