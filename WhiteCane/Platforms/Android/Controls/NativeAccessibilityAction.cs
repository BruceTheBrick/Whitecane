using System.Windows.Input;
using AndroidX.Core.View.Accessibility;

namespace WhiteCane.Controls;

public class NativeAccessibilityAction : Java.Lang.Object, IAccessibilityViewCommand
{
    private readonly ICommand _command;

    public NativeAccessibilityAction(ICommand command)
    {
        _command = command;
    }

    public NativeAccessibilityAction(BaseAccessibilityAction action)
    {
        _command = action.Command;
    }
    
    public bool Perform(Android.Views.View view, AccessibilityViewCommandCommandArguments arguments)
    {
        try
        {
            _command?.Execute(null);
            return true;
        }
        catch
        {
            return false;
        }
    }
}