using CommunityToolkit.Mvvm.Input;

namespace WhiteCane.Samples.Features;

public partial class HomePageViewModel : BasePageViewModel
{
    [RelayCommand]
    private Task NavigateToAccessibilityContentViewPage()
    {
        return Shell.Current.GoToAsync(Routes.AccessibilityContentViewPage);
    }
}