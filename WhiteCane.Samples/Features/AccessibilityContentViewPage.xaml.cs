namespace WhiteCane.Samples.Features;

public partial class AccessibilityContentViewPage
{
    public AccessibilityContentViewPage()
    {
        InitializeComponent();
        var incrementCommand = new Command(Increment);
        var decrementCommand = new Command(Decrement);
        AccessibilityContentView.IncrementCommand = incrementCommand;
        AccessibilityContentView.DecrementCommand = decrementCommand;
    }
    
    private void Increment()
    {
        SemanticScreenReader.Default.Announce("You have incremented!");
    }

    private void Decrement()
    {
        SemanticScreenReader.Default.Announce("You have decremented!");
    }
}