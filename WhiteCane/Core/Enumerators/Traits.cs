namespace WhiteCane;

[Flags]
public enum Traits
{
    None = 0,
    Button = 1,
    Link = 2,
    Image = 4,
    Selected = 8,
    PlaysSound = 16,
    KeyboardKey = 32,
    StaticText = 64,
    SummaryElement = 128,
    NotEnabled = 256,
    UpdatesFrequently = 512,
    SearchField = 1024,
    StartsMediaSession = 2048,
    Adjustable = 4096,
    AllowsDirectInteraction = 8192,
    CausesPageTurn = 16384,
    Header = 65536,
}