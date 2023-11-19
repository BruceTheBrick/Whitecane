using System.Windows.Input;

namespace WhiteCane.Controls;

public partial class AccessibilityContentView : IAccessibilityContentView, IElement
{
    public IElementHandler Handler { get; set; }
    public IElement Parent { get; }
    public ICommand IncrementCommand { get; set; }
    public ICommand DecrementCommand { get; set; }
    public IList<BaseAccessibilityAction> Actions { get; set; }
}