using CommunityToolkit.Mvvm.Input;

namespace WhiteCane.Samples.Features;

public partial class AccessibilityContentViewPageViewModel : BasePageViewModel
{
    private readonly ISemanticScreenReader _screenReader;

    public AccessibilityContentViewPageViewModel(ISemanticScreenReader screenReader)
    {
        _screenReader = screenReader;
        InitActions();
    }

    public IList<BaseAccessibilityAction> Actions { get; private set; } = new List<BaseAccessibilityAction>(); 
    
    [RelayCommand]
    private void Increment()
    {
        _screenReader.Announce("You have incremented!");
    }

    [RelayCommand]
    private void Decrement()
    {
        _screenReader.Announce("You have decremented!");
    }
    
    private void InitActions()
    {
        var helloCommand = new Command(() => SemanticScreenReader.Default.Announce("Hello there!"));
        var goodbyeCommand = new Command(() => SemanticScreenReader.Default.Announce("Goodbye!"));
        var returnCommand = new Command(() => SemanticScreenReader.Default.Announce("I'll Be back"));

        Actions = new List<BaseAccessibilityAction>()
        {
            new ("Say Hello", helloCommand),
            new ("Say Goodbye", goodbyeCommand),
            new ("Quote Terminator", returnCommand),
        };
    }
}