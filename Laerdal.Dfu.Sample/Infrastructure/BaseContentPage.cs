namespace Laerdal.Dfu.Sample.Infrastructure;

public abstract class BaseContentPage<TViewModel> : ContentPage
    where TViewModel : BaseViewModel
{
    protected BaseContentPage(TViewModel viewModel)
    {
        ViewModel = viewModel;
        BindingContext = viewModel;
    }

    protected TViewModel ViewModel { get; }

    protected async override void OnAppearing()
    {
        base.OnAppearing();
        await ViewModel.OnAppearingAsync();
    }

    protected async override void OnDisappearing()
    {
        base.OnDisappearing();
        await ViewModel.OnDisappearingAsync();
    }
}
