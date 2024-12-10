namespace WllxTextingProject.Tests
{
    public class HomePageTests : BaseTest
    {
        [Test, Order(1)]
        public void VerifyHeaderLinksAndButtonsAreDisplayed()
        {
            homePage.OpenPage();

            Assert.IsTrue(homePage.IsHomeLogoButtonDisplayed(), "The home page logo button is not displayed as expected.");

            Assert.IsTrue(homePage.IsMarketsLinkDisplayed(), "The 'Markets' link in navigation bar is not displayed as expected.");

            Assert.IsTrue(homePage.IsProductsLinkDisplayed(), "The 'Products' link in navigation bar is not displayed as expected.");

            Assert.IsTrue(homePage.IsPrimeLinkDisplayed(), "The 'Prime' link in navigation bar is not displayed as expected.");

            Assert.IsTrue(homePage.IsLabsLinkDisplayed(), "The 'Labs' link in navigation bar is not displayed as expected.");

            Assert.IsTrue(homePage.IsResourcesLinkDisplayed(), "The 'Resources' link in navigation bar is not displayed as expected.");

            Assert.IsTrue(homePage.IsSignInLinkDisplayed(), "The 'Sign In' link in navigation bar is not displayed as expected.");

            Assert.IsTrue(homePage.IsAppStoreButtonDisplayed(), "The 'App Store' button in navigation bar is not displayed as expected.");

            Assert.IsTrue(homePage.IsGooglePlayButtonDisplayed(), "The 'Google Play' button in navigation bar is not displayed as expected.");
        }

        [Test, Order(2)]
        public void VerifyIsBuyCryptoLinkNavigatesCorrectly()
        {
            homePage.OpenPage();

            Assert.IsTrue(homePage.IsBuyCryptoLinkNavigatesCorrectly(), "The 'Buy Crypto' link navigates to Buy Crypto page as expected.");
        }

        [Test, Order(3)]
        public void VerifyIsMarketsLinkNavigatesCorrectly()
        {
            homePage.OpenPage();

            Assert.IsTrue(homePage.IsMarketsLinkNavigatesCorrectly(), "The 'Markets' link navigates to Markets page as expected.");
        }

        // Should create tests for platforms, features and Reawrds navigates correctly
        [Test, Order(4)]
        public void VerifyIsNeobankingLinkInProductsNavigatesCorrectly()
        {
            homePage.OpenPage();

            Assert.IsTrue(homePage.IsNeobankingLinkInProductsNavigatesCorrectly(), "The 'Neobanking' link in Products menu navigates to Neobanking page as expected.");
        }
    }
}
