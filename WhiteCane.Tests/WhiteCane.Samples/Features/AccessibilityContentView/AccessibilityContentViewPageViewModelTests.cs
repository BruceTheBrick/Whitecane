using WhiteCane.Samples.Features;

namespace WhiteCane.Tests.WhiteCane.Samples;

public class AccessibilityContentViewPageViewModelTests : UnitTestBase<AccessibilityContentViewPageViewModel>
{
    #region Increment

    [Fact]
    private void Increment_ShouldPerformScreenReaderAnnouncement()
    {
        //Arrange
        
        //Act
        Sut.IncrementCommand.Execute(null);

        //Assert
        Mocker.GetMock<ISemanticScreenReader>().Verify(x => x.Announce("You have incremented!"));
    }

    #endregion
    
    #region Decrement

    [Fact]
    private void Decrement_ShouldPerformScreenReaderAnnouncement()
    {
        //Arrange
        
        //Act
        Sut.DecrementCommand.Execute(null);

        //Assert
        Mocker.GetMock<ISemanticScreenReader>().Verify(x => x.Announce("You have decremented!"));
    }

    #endregion
}