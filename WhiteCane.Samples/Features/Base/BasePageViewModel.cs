namespace WhiteCane.Samples.Features;

public class BasePageViewModel : IPageLifecycleAware, INavigationAware, INavigationAwareAsync, IPageLifecycleAwareAsync
{
    public virtual void OnAppearing()
    {
    }

    public virtual void OnDisappearing()
    {
    }
    
    public Task OnAppearingAsync()
    {
        return Task.CompletedTask;
    }

    public Task OnDisappearingAsync()
    {
        return Task.CompletedTask;
    }

    public virtual void OnNavigatedTo(NavigatedToEventArgs navigationArgs)
    {
    }

    public virtual void OnNavigatedFrom(NavigatedFromEventArgs navigationArgs)
    {
    }

    public virtual void OnNavigatingFrom(NavigatingFromEventArgs navigationArgs)
    {
    }

    public virtual Task OnNavigatedToAsync(NavigatedToEventArgs navigationArgs)
    {
        return Task.CompletedTask;
    }

    public virtual Task OnNavigatedFromAsync(NavigatedFromEventArgs navigationArgs)
    {
        return Task.CompletedTask;
    }

    public Task OnNavigatingFromAsync(NavigatingFromEventArgs navigationArgs)
    {
        return Task.CompletedTask;
    }
}