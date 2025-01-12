using UITestingPlaygroundTestProject.Pages;

namespace UITestingPlaygroundTestProject.Tests
{
    public class AjaxDataTests : BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            ajaxDataPage.OpenPage();
        }

        [Test, Order(1)]
        public void Test_VerifyingAjaxDataPageHeading_ShouldReturnTrue()
        {
            Assert.True(ajaxDataPage.IsPageHeadingCorrect(), "The page heading is not correct.");
        }

        [Test, Order(2)]
        public void Test_ClickAjaxButton_ShouldReturnTrue()
        {
            Assert.True(ajaxDataPage.IsAjaxDataDisplayedWithCorrectMessage(), "The AJAX data is not displayed.");
        }
    }
}
