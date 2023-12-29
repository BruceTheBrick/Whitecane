namespace WhiteCane.Samples.Features;

public interface IPageLifecycleAwareAsync
{
    public Task OnAppearingAsync();
    public Task OnDisappearingAsync();
}