namespace WhiteCane.Samples.Services;

public class SemanticScreenReader : ISemanticScreenReader
{
    public void Announce(string text)
    {
        Microsoft.Maui.Accessibility.SemanticScreenReader.Announce(text);
    }
}