using Microsoft.Maui.Handlers;
using UIKit;
using WhiteCane.Controls;

namespace WhiteCane.Handlers;

public partial class AccessibilityContentViewHandler : ViewHandler<IAccessibilityContentView, UIView>
{
    protected override UIView CreatePlatformView()
    {
        return new UIView();
    }

    private static void MapIncrementCommand(AccessibilityContentViewHandler handler, IAccessibilityContentView contentView)
    {
        ApplyAdjustableIfCommandsAreSet(handler, contentView);
    }
    
    private static void MapDecrementCommand(AccessibilityContentViewHandler handler, IAccessibilityContentView contentView)
    {
        ApplyAdjustableIfCommandsAreSet(handler, contentView);
    }
    
    private static void MapActions(AccessibilityContentViewHandler handler, IAccessibilityContentView contentView)
    {
        throw new NotImplementedException();
    }

    private static void ApplyAdjustableIfCommandsAreSet(AccessibilityContentViewHandler handler, IAccessibilityContentView contentView)
    {
        if (contentView.DecrementCommand is not null || contentView.IncrementCommand is not null)
        {
            handler.PlatformView.AccessibilityTraits |= UIAccessibilityTrait.Adjustable;
        }
    }
}