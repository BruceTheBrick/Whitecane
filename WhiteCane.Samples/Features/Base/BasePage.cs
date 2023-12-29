namespace WhiteCane.Samples.Features;

public class BasePage : ContentPage
{
    public BasePage()
    {
        Padding = 16;
    }

    public BasePage(BasePageViewModel? viewModel)
    {
        BindingContext = viewModel;
        Padding = 16;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (BindingContext is IPageLifecycleAware pageLifecycle)
        {
            pageLifecycle.OnAppearing();
        }

        if (BindingContext is IPageLifecycleAwareAsync pageLifecycleAwareAsync)
        {
            _ = pageLifecycleAwareAsync.OnAppearingAsync();
        }
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        if (BindingContext is IPageLifecycleAware pageLifecycle)
        {
            pageLifecycle.OnDisappearing();
        }
        
        if (BindingContext is IPageLifecycleAwareAsync pageLifecycleAwareAsync)
        {
            _ = pageLifecycleAwareAsync.OnDisappearingAsync();
        }
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
        if (BindingContext is INavigationAware navigationAware)
        {
            navigationAware.OnNavigatedTo(args);
        }
        
        if (BindingContext is INavigationAwareAsync navigationAwareAsync)
        {
            _ = navigationAwareAsync.OnNavigatedToAsync(args);
        }
    }
    
    protected override void OnNavigatedFrom(NavigatedFromEventArgs args)
    {
        base.OnNavigatedFrom(args);
        if (BindingContext is INavigationAware navigationAware)
        {
            navigationAware.OnNavigatedFrom(args);
        }
        
        if (BindingContext is INavigationAwareAsync navigationAwareAsync)
        {
            _ = navigationAwareAsync.OnNavigatedFromAsync(args);
        }
    }
    
    protected override void OnNavigatingFrom(NavigatingFromEventArgs args)
    {
        base.OnNavigatingFrom(args);
        if (BindingContext is INavigationAware navigationAware)
        {
            navigationAware.OnNavigatingFrom(args);
        }
        
        if (BindingContext is INavigationAwareAsync navigationAwareAsync)
        {
            _ = navigationAwareAsync.OnNavigatingFromAsync(args);
        }
    }
}