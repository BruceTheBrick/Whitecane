using System.Windows.Input;

namespace WhiteCane;

public interface IAccessibilityContentView
{
    public ICommand IncrementCommand { get; set; }
    public ICommand DecrementCommand { get; set; }
    public IList<BaseAccessibilityAction> Actions { get; set; }
}