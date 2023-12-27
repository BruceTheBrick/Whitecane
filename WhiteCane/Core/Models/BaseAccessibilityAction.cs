using System.Windows.Input;

namespace WhiteCane;

public class BaseAccessibilityAction
{
    public BaseAccessibilityAction()
    {
    }

    public BaseAccessibilityAction(string label, ICommand command)
    {
        Label = label;
        Command = command;
    }
    
    public string Label { get; set; }
    public ICommand Command { get; set; }
}