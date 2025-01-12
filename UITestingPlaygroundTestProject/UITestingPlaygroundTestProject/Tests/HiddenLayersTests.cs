namespace UITestingPlaygroundTestProject.Tests
{
    public class HiddenLayersTests : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            hiddenLayersPage.OpenPage();
        }

        [Test, Order(1)]
        public void Test_VerifyingHiddenLayersPageHeading_ShouldReturnTrue()
        {
            Assert.True(hiddenLayersPage.IsPageHeadingCorrect(), "The page heading is not correct.");
        }

        [Test, Order(2)]
        public void Test_ClickGreenButton_ShouldAllowOnlyOnce()
        {
            hiddenLayersPage.ClickGreenButton();

            Assert.True(hiddenLayersPage.IsExceptionThrownAfterGreenButtonSecondClick(), "The green button is active and clickable.");

            Assert.True(hiddenLayersPage.IsBlueButtonEnabledAndDisplayed(), "The blue button is not active but it should be.");
        }
    }
}
