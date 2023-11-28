#if ANDROID
using System.Windows.Input;
using Android.Views.Accessibility;
using AndroidX.Core.View;
using Microsoft.Maui.Handlers;
using WhiteCane.Controls;
using View = Android.Views.View;

namespace WhiteCane.Handlers;

public partial class AccessibilityContentViewHandler : ViewHandler<ContentView, AccessibilityContentView>
{
    private const string Increment = "Increment";
    private const string Decrement = "Decrement";
    protected override AccessibilityContentView CreatePlatformView()
    {
        return new AccessibilityContentView(Context);
    }
    
    private static void MapIncrementCommand(AccessibilityContentViewHandler handler, AccessibilityContentView contentView)
    {
        RemoveExistingCommand(handler.PlatformView, Increment);
        AddAccessibilityActionFromCommand(handler.PlatformView, contentView.IncrementCommand, Increment);
    }

    private static void MapDecrementCommand(AccessibilityContentViewHandler handler, AccessibilityContentView contentView)
    {
        RemoveExistingCommand(handler.PlatformView, Decrement);
        AddAccessibilityActionFromCommand(handler.PlatformView, contentView.DecrementCommand, Decrement);
    }

    private static void MapActions(AccessibilityContentViewHandler handler, AccessibilityContentView contentView)
    {
        foreach (var action in handler.PlatformView.Actions)
        {
            ViewCompat.AddAccessibilityAction(contentView, action.Label, new NativeAccessibilityAction(action));
        }
    }

    private static void RemoveExistingCommand(View contentView, string actionLabel)
    {
        try
        {
            using var accessibilityNodeInfo = contentView.CreateAccessibilityNodeInfo();
            if (accessibilityNodeInfo is null)
            {
                return;
            }
            
            var actions = accessibilityNodeInfo.ActionList ?? Array.Empty<AccessibilityNodeInfo.AccessibilityAction>();
            var existingAction = actions.FirstOrDefault(x => x.Label == actionLabel);
            if (existingAction is null)
            {
                return;
            }

            accessibilityNodeInfo.RemoveAction(existingAction);
        }
        catch
        {
            // ignored
        }
    }
    
    private static void AddAccessibilityActionFromCommand(AccessibilityContentView contentView, ICommand command, string label)
    {
        ViewCompat.AddAccessibilityAction(contentView, label, new NativeAccessibilityAction(command));
    }
}
#endif