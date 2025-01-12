namespace UITestingPlaygroundTestProject.Tests
{
    public class ScrollbarsTests : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            scrollbarsPage.OpenPage();
        }

        [Test, Order(1)]
        public void Test_VerifyingScrollbarsPageHeading_ShouldReturnTrue()
        {
            Assert.True(scrollbarsPage.IsPageHeadingCorrect(), "The page heading is not correct.");
        }

        [Test, Order(2)]
        public void Test_VerifyingHiddenButtonDisplayed_ShouldReturnTrue()
        {
            scrollbarsPage.ScrollToHiddenElement();

            Assert.True(scrollbarsPage.IsHiddentButtonDisplayed(), "The hidden button is not displayed.");
        }

        [Test, Order(3)]
        public void Test_VerifyingHiddenButtonClickable_ShouldReturnTrue()
        {
            scrollbarsPage.ScrollToHiddenElement();

            Assert.True(scrollbarsPage.IsHiddenButtonClickable(), "The hidden button is not clickable.");
        }
    }
}
