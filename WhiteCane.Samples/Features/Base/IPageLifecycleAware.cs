namespace WhiteCane.Samples.Features;

public interface IPageLifecycleAware
{
    public void OnAppearing();
    public void OnDisappearing();
}