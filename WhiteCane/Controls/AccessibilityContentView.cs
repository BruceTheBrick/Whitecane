using System.Windows.Input;

namespace WhiteCane;

public class AccessibilityContentView : ContentView, IAccessibilityContentView
{
    public static BindableProperty IncrementCommandProperty = BindableProperty.Create(
        nameof(IncrementCommand), 
        typeof(ICommand), 
        typeof(AccessibilityContentView));
    
    public static BindableProperty DecrementCommandProperty = BindableProperty.Create(
        nameof(DecrementCommand),
        typeof(ICommand),
        typeof(AccessibilityContentView));
    
    public static BindableProperty ActionsProperty = BindableProperty.Create(
        nameof(Actions),
        typeof(IList<BaseAccessibilityAction>),
        typeof(AccessibilityContentView));

    public ICommand IncrementCommand
    {
        get => (ICommand)GetValue(IncrementCommandProperty);
        set => SetValue(IncrementCommandProperty, value);
    }

    public ICommand DecrementCommand
    {
        get => (ICommand)GetValue(DecrementCommandProperty);
        set => SetValue(DecrementCommandProperty, value);
    }

    public IList<BaseAccessibilityAction> Actions
    {
        get => (IList<BaseAccessibilityAction>)GetValue(ActionsProperty);
        set => SetValue(ActionsProperty, value);
    }
}