#if ANDROID
using AndroidX.Core.View;
using Microsoft.Maui.Handlers;
using WhiteCane.Controls;

namespace WhiteCane.Handlers;

public partial class AccessibilityContentViewHandler : ViewHandler<ContentView, AccessibilityContentView>
{
    private static void MapIncrementCommand(AccessibilityContentViewHandler handler, AccessibilityContentView contentView)
    {
        throw new NotImplementedException();
    }

    protected override AccessibilityContentView CreatePlatformView()
    {
        throw new NotImplementedException();
    }

    private static void MapDecrementCommand(AccessibilityContentViewHandler handler, AccessibilityContentView contentView)
    {
        throw new NotImplementedException();
    }

    private static void MapActions(AccessibilityContentViewHandler handler, AccessibilityContentView contentView)
    {
        foreach (var action in handler.PlatformView.Actions)
        {
            ViewCompat.AddAccessibilityAction(contentView, action.Label, new NativeAccessibilityAction(action.Command));
        }
    }
}
#endif