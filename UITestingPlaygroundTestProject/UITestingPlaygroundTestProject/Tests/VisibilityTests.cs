namespace UITestingPlaygroundTestProject.Tests
{
    public class VisibilityTests : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            visibilityPage.OpenPage();
        }

        [Test, Order(1)]
        public void Test_VerifyingVisibilityPageHeading_ShouldReturnTrue()
        {
            Assert.True(visibilityPage.IsPageHeadingCorrect(), "The page heading is not correct.");
        }

        [Test, Order(2)]
        public void Test_ClickHideButton_ShouldHideButtons()
        {
            visibilityPage.ClickHideButton();

            Assert.False(visibilityPage.IsRemovedButtonDisplayed(), "The removed button is displayed.");

            Assert.False(visibilityPage.IsZeroWidthButtonDisplayed(), "The zero width button is displayed.");

            Assert.False(visibilityPage.IsOverlappedButtonDisplayed(), "The overlapped button is displayed.");

            Assert.False(visibilityPage.IsOpacityButtonDisplayed(), "The opacity button is displayed.");

            Assert.False(visibilityPage.IsVisibilityHiddenButtonDisplayed(), "The visibility hidden button is displayed.");

            Assert.False(visibilityPage.IsVisibilityNoneButtonDisplayed(), "The visibility none button is displayed.");

            Assert.False(visibilityPage.IsOffscreenButtonDisplayed(), "The offscreen button is displayed.");
        }
    }
}
