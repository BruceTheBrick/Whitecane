using System.Windows.Input;
using AndroidX.Core.View.Accessibility;
using Java.Interop;

namespace WhiteCane.Controls;

public class NativeAccessibilityAction :  JavaObject, IAccessibilityViewCommand
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

    public IntPtr Handle { get; }
    
    public bool Perform(Android.Views.View view, AccessibilityViewCommandCommandArguments arguments)
    {
        try
        {
            _command?.Execute(null);
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }
}