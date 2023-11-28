#if IOS
using Microsoft.Maui.Handlers;
using WhiteCane.Controls;

namespace WhiteCane.Handlers;

public partial class AccessibilityContentViewHandler : ViewHandler<ContentView, AccessibilityContentView>
{
    protected override AccessibilityContentView CreatePlatformView()
    {
        return new AccessibilityContentView();
    }
    
    private static void MapIncrementCommand(AccessibilityContentViewHandler handler, AccessibilityContentView contentView)
    {
        contentView.IncrementCommand = handler.PlatformView.IncrementCommand;
    }

    private static void MapDecrementCommand(AccessibilityContentViewHandler handler, AccessibilityContentView contentView)
    {
        contentView.DecrementCommand = handler.PlatformView.DecrementCommand;
    }

    private static void MapActions(AccessibilityContentViewHandler handler, AccessibilityContentView contentView)
    {
        contentView.Actions = handler.PlatformView.Actions;
    }
}
#endif