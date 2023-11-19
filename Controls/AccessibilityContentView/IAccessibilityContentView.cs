using System.Windows.Input;

namespace WhiteCane.Controls;

public interface IAccessibilityContentView : IView
{
    public ICommand IncrementCommand { get; set; }
    public ICommand DecrementCommand { get; set; }
    public IList<BaseAccessibilityAction> Actions { get; set; }
}