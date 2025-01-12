namespace UITestingPlaygroundTestProject.Tests
{
    public class LoadDelayTests : BaseTest
    {
        [Test, Order(1)]
        public void Test_VerifyingLoadDelayPageHeading_ShouldReturnTrue()
        {
            loadDelayPage.OpenPage();

            Assert.True(loadDelayPage.IsPageHeadingCorrect(), "The page heading is not correct.");
        }

        [Test, Order(2)]
        public void Test_ClickDelayButton_ShouldNotThrowException()
        {
            basePage.OpenBasePage();

            Assert.True(loadDelayPage.IsDelayButtonClicked(), "The delay button is not active and clickable.");
        }
    }
}
