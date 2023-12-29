#if IOS
using System.Windows.Input;
using Foundation;
using UIKit;
using ContentView = Microsoft.Maui.Platform.ContentView;

namespace WhiteCane.Platforms.Controls;

public class NativeAccessibilityContentView : ContentView, IAccessibilityContentView
{
    private IList<BaseAccessibilityAction> _actions;
    public NativeAccessibilityContentView(IAccessibilityContentView accessibilityContentView)
    {
        AccessibilityTraits |= UIAccessibilityTrait.Adjustable;
        IncrementCommand = accessibilityContentView.IncrementCommand;
        DecrementCommand = accessibilityContentView.DecrementCommand;
        Actions = accessibilityContentView.Actions;
    }

    public ICommand IncrementCommand { get; set; }
    public ICommand DecrementCommand { get; set; }
    public IList<BaseAccessibilityAction> Actions
    {
        get => _actions; 
        set => SetAccessibilityActions(value); 
    }

    public override void AccessibilityIncrement()
    {
        IncrementCommand?.Execute(null);
        base.AccessibilityIncrement();
    }

    public override void AccessibilityDecrement()
    {
        DecrementCommand?.Execute(null);
        base.AccessibilityDecrement();
    }
    
    private void SetAccessibilityActions(IList<BaseAccessibilityAction> actions)
    {
        _actions = actions;
        var nativeActions = CreateNativeActions(actions);
        AccessibilityCustomActions = nativeActions.ToArray();
    }

    private IList<UIAccessibilityCustomAction> CreateNativeActions(IList<BaseAccessibilityAction> actions)
    {
        var nativeActions = new List<UIAccessibilityCustomAction>();
        if(actions is null || actions.Count == 0)
        {
            return new List<UIAccessibilityCustomAction>();
        }

        foreach(var action in actions)
        {
            var name = new NSString(action.Label);
            var nativeAction = new UIAccessibilityCustomAction(name, actionHandler: InvokeNativeAccessibilityAction);
            nativeActions.Add(nativeAction);
        }

        return nativeActions;
    }

    private bool InvokeNativeAccessibilityAction(UIAccessibilityCustomAction nativeAction)
    {
        try
        {
            var action = Actions.FirstOrDefault(x => x.Label == nativeAction.Name);
            action?.Command?.Execute(null);
            return true;
        }
        catch
        {
            return false;
        }
    }
}
#endif