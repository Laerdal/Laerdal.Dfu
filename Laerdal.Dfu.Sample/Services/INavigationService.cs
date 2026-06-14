namespace Laerdal.Dfu.Sample.Services;

public interface INavigationService
{
    ValueTask NavigateToAsync<TPage>(IDictionary<string, object>? parameters = null) where TPage : Page;
    ValueTask NavigateBackAsync();
}
