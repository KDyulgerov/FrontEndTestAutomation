using WllxTextingProject.Pages;

namespace WllxTextingProject.Tests
{
    public class HomePageTests : BaseTest
    {
        [Test, Order(1)]
        public void VerifyingElements() // Just Example
        {
            homePage.OpenPage();

            Assert.IsTrue(homePage.IsHomeLogoButtonDisplayed(), "The home page logo button is not displayed as expected.");
            Assert.IsTrue(homePage.IsNavigationBarLinksDisplayed(), "The links in navigation bar are not displayed as expected.");
        }
    }
}
