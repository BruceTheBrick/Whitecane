#if IOS
using WhiteCane.Platforms.iOS.Controls;
using ContentView = Microsoft.Maui.Platform.ContentView;

namespace WhiteCane.Handlers;

public partial class AccessibilityContentViewHandler
{
    public static IPropertyMapper<AccessibilityContentView, AccessibilityContentViewHandler> PropertyMapper =
        new PropertyMapper<AccessibilityContentView, AccessibilityContentViewHandler>(ViewMapper)
        {
            [nameof(IAccessibilityContentView.IncrementCommand)] = MapIncrementCommand,
            [nameof(IAccessibilityContentView.DecrementCommand)] = MapDecrementCommand,
            [nameof(IAccessibilityContentView.Actions)] = MapActions,
        };

    private static void MapIncrementCommand(AccessibilityContentViewHandler handler, AccessibilityContentView view)
    {
        if (handler.PlatformView is NativeAccessibilityContentView nativeAccessibilityContentView)
        {
            nativeAccessibilityContentView.IncrementCommand = view.IncrementCommand;
        }
    }

    private static void MapDecrementCommand(AccessibilityContentViewHandler handler, AccessibilityContentView view)
    {
       if(handler.PlatformView is NativeAccessibilityContentView nativeAccessibilityContentView)
       {
           nativeAccessibilityContentView.DecrementCommand = view.DecrementCommand;
       }
    }

    private static void MapActions(AccessibilityContentViewHandler handler, AccessibilityContentView view)
    {
        if (handler.PlatformView is NativeAccessibilityContentView nativeAccessibilityContentView)
        {
            nativeAccessibilityContentView.Actions = view.Actions;
        }
    }

    protected override ContentView CreatePlatformView()
    {
        return new NativeAccessibilityContentView(VirtualView as IAccessibilityContentView);
    }
}
#endif