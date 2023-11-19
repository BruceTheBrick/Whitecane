using System.Windows.Input;

namespace WhiteCane.Controls;

public class AccessibilityContentView : ContentView, IAccessibilityContentView
{
    public static readonly BindableProperty IncrementCommandProperty = BindableProperty.Create(
        nameof(IncrementCommand),
        typeof(ICommand),
        typeof(AccessibilityContentView));
    
    public static readonly BindableProperty DecrementCommandProperty = BindableProperty.Create(
        nameof(DecrementCommand),
        typeof(ICommand),
        typeof(AccessibilityContentView));
    
    public static readonly BindableProperty ActionsProperty = BindableProperty.Create(
        nameof(Actions),
        typeof(IList<BaseAccessibilityAction>),
        typeof(AccessibilityContentView));

    public ICommand IncrementCommand
    {
        get => (ICommand) GetValue(IncrementCommandProperty);
        set => SetValue(IncrementCommandProperty, value);
    }
    
    public ICommand DecrementCommand
    {
        get => (ICommand) GetValue(DecrementCommandProperty);
        set => SetValue(DecrementCommandProperty, value);
    }
    
    public IList<BaseAccessibilityAction> Actions
    {
        get => (IList<BaseAccessibilityAction>) GetValue(ActionsProperty);
        set => SetValue(ActionsProperty, value);
    }
}