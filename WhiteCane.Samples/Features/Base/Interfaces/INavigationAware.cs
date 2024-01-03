namespace WhiteCane.Samples.Features;

public interface INavigationAware
{
    public void OnNavigatedTo(NavigatedToEventArgs navigationArgs);
    public void OnNavigatedFrom(NavigatedFromEventArgs navigationArgs);
    public void OnNavigatingFrom(NavigatingFromEventArgs navigationArgs);
}