namespace WhiteCane.Samples;

public partial class HomePage
{
    public HomePage()
    {
        InitializeComponent();
    }

    private void NavigateToAccessibilityContentViewPage(object? sender, EventArgs e)
    {
        Shell.Current.GoToAsync(Routes.AccessibilityContentViewPage);
    }
}