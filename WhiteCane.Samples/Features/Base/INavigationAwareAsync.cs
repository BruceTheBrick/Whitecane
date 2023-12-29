namespace WhiteCane.Samples.Features;

public interface INavigationAwareAsync
{
    public Task OnNavigatedToAsync(NavigatedToEventArgs navigationArgs);
    public Task OnNavigatedFromAsync(NavigatedFromEventArgs navigationArgs);
    public Task OnNavigatingFromAsync(NavigatingFromEventArgs navigationArgs);
}