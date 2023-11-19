using Microsoft.Maui.Handlers;
using WhiteCane.Controls;
using View = Android.Views.View;

namespace WhiteCane.Handlers;

public partial class AccessibilityContentViewHandler : ViewHandler<IAccessibilityContentView, Android.Views.View>
{
    protected override View CreatePlatformView()
    {
        return new View(Context);
    }
    
    private static void MapIncrementCommand(AccessibilityContentViewHandler handler, IAccessibilityContentView contentView)
    {
        throw new NotImplementedException();
    }
    
    private static void MapDecrementCommand(AccessibilityContentViewHandler handler, IAccessibilityContentView contentView)
    {
        throw new NotImplementedException();
    }
    
    private static void MapActions(AccessibilityContentViewHandler handler, IAccessibilityContentView contentView)
    {
        throw new NotImplementedException();
    }
}