namespace WhiteCane.Samples.Services;

public class ScreenReaderService : ISemanticScreenReader
{
    public void Announce(string text)
    {
        SemanticScreenReader.Announce(text);
    }
}