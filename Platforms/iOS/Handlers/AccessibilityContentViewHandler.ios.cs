#if IOS
using WhiteCane.Platforms.Controls;
using ContentView = Microsoft.Maui.Platform.ContentView;

namespace WhiteCane.Handlers;

public partial class AccessibilityContentViewHandler
{
    private IAccessibilityContentView AccessibilityContentView => VirtualView as IAccessibilityContentView;
    protected override ContentView CreatePlatformView()
    {
        return new NativeAccessibilityContentView(AccessibilityContentView);
    }
}
#endif