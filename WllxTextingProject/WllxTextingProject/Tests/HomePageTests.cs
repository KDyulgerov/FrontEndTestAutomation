namespace WllxTextingProject.Tests
{
    public class HomePageTests : BaseTest
    {
        [SetUp]
        public void HomePageTestsSetUp()
        {
            homePage.OpenPage();
        }

        [Test, Order(1)]
        public void VerifyHeaderLinksAndButtonsAreDisplayed()
        {
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
            Assert.IsTrue(homePage.IsBuyCryptoLinkNavigatesCorrectly(), "The 'Buy Crypto' link does not navigate to Buy Crypto page as expected.");
        }

        [Test, Order(3)]
        public void VerifyIsMarketsLinkNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsMarketsLinkNavigatesCorrectly(), "The 'Markets' link does not navigate to Markets page as expected.");
        }

        // Tests for Platforms Links

        [Test, Order(4)]
        public void VerifyIsNeobankingLinkInProductsNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsNeobankingLinkInProductsNavigatesCorrectly(), "The 'Neobanking' link in Products menu does not navigate to Neobanking page as expected.");
        }

        [Test, Order(5)]
        public void VerifyIsCustodyProLinkInProductsNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsCustodyProLinkInProductsNavigatesCorrectly(), "The 'Custody Pro' link in Products menu does not navigate to Custody Pro page as expected.");
        }

        [Test, Order(6)]
        public void VerifyIsSmartCustodyLinkInProductsNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsSmartCustodyLinkInProductsNavigatesCorrectly(), "The 'Smart Custody' link in Products menu does not navigate to Smart Custody page as expected.");
        }

        [Test, Order(7)]
        public void VerifyIsSelfCustodyLinkInProductsNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsSelfCustodyLinkInProductsNavigatesCorrectly(), "The 'Self Custody' link in Products menu does not navigate to Self Custody page as expected.");
        }

        [Test, Order(8)]
        public void VerifyIsWallexPayLinkInProductsNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsWallexPayLinkInProductsNavigatesCorrectly(), "The 'Wallex Pay' link in Products menu does not navigate to Wallex Pay page as expected.");
        }

        [Test, Order(9)]
        public void VerifyIsEurstLinkInProductsNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsEurstLinkInProductsNavigatesCorrectly(), "The 'Eurst' link in Products menu does not navigate to Eurst page as expected.");
        }

        [Test, Order(10)]
        public void VerifyIsNftLinkInProductsNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsNftLinkInProductsNavigatesCorrectly(), "The 'NFT' link in Products menu does not navigate to NFT page as expected.");
        }

        // Tests for Features Links

        [Test, Order(11)]
        public void VerifyIsWallexCardLinkInProductsNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsWallexCardLinkInProductsNavigatesCorrectly(), "The 'Wallex Card' link in Products menu does not navigate to Wallex Card page as expected.");
        }

        [Test, Order(12)]
        public void VerifyIsEarnAndSavingsLinkInProductsNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsEarnAndSavingsLinkInProductsNavigatesCorrectly(), "The 'Earn & Savings' link in Products menu does not navigate to Earn & Savings page as expected.");
        }

        [Test, Order(13)]
        public void VerifyIsWallexCreditLinkInProductsNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsWallexCreditLinkInProductsNavigatesCorrectly(), "The 'Wallex Credit' link in Products menu does not navigate to Wallex Credit page as expected.");
        }

        [Test, Order(14)]
        public void VerifyIsCryptocurrencyLinkInProductsNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsCryptocurrencyLinkInProductsNavigatesCorrectly(), "The 'Cryptocurrency' link in Products menu does not navigate to Cryptocurrency page as expected.");
        }

        [Test, Order(15)]
        public void VerifyIsPaymentsLinkInProductsNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsPaymentsLinkInProductsNavigatesCorrectly(), "The 'Payments' link in Products menu does not navigate to Payments page as expected.");
        }

        // Tests for Features Links

        [Test, Order(16)]
        public void VerifyIsEurustBackRewardsLinkInProductsNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsEurustBackRewardsLinkInProductsNavigatesCorrectly(), "The 'EURST Back' link in Products menu does not navigate to EURST Back page as expected.");
        }

        [Test, Order(17)]
        public void VerifyIsInviteAFriendLinkInProductsNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsInviteAFriendLinkInProductsNavigatesCorrectly(), "The 'Invite a Friend' link in Products menu does not navigate to Invite a Friend Back page as expected.");
        }

        // Tests for Explore and Buy Crypto in Products

        [Test, Order(18)]
        public void VerifyIsExploreLinkInProductsNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsExploreLinkInProductsNavigatesCorrectly(), "The 'Explore' link in Products menu does not navigate to Explore page as expected.");
        }

        [Test, Order(19)]
        public void VerifyIsBuyCryptoButtonInProductsNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsBuyCryptoButtonInProductsNavigatesCorrectly(), "The 'Buy Crypto' button in Products menu does not navigate to Sign Up page as expected.");
        }

        // Tests for Prime Links

        [Test, Order(20)]
        public void VerifyIsCorporateLinkInPrimeNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsCorporateLinkInPrimesNavigatesCorrectly(), "The 'Corporate' link in Prime menu does not navigate to Corporate page as expected.");
        }

        [Test, Order(21)]
        public void VerifyIsPrivateLinkInPrimeNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsPrivateLinkInPrimesNavigatesCorrectly(), "The 'Private' link in Prime menu does not navigate to Private page as expected.");
        }

        [Test, Order(22)]
        public void VerifyIsWealthLinkInPrimeNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsWealthLinkInPrimesNavigatesCorrectly(), "The 'Wealth' link in Prime menu does not navigate to Wealth page as expected.");
        }

        [Test, Order(23)]
        public void VerifyIsAmbassadorLinkInPrimeNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsAmbassadorLinkInPrimesNavigatesCorrectly(), "The 'Ambassador' link in Prime menu does not navigate to Ambassador page as expected.");
        }

        // Tests for Labs Links

        [Test, Order(24)]
        public void VerifyIsWallexLabLinkInLabsNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsWallexLabLinkInLabsNavigatesCorrectly(), "The 'WallexLab' link in Labs menu does not navigate to WallexLab page as expected.");
        }

        [Test, Order(25)]
        public void VerifyIsVenturesLinkInLabsNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsVenturesLinkInLabsNavigatesCorrectly(), "The 'Ventures' link in Labs menu does not navigate to Ventures page as expected.");
        }

        [Test, Order(26)]
        public void VerifyIsFoundationLinkInLabsNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsFoundationLinkInLabsNavigatesCorrectly(), "The 'Foundation' link in Labs menu does not navigate to Foundation page as expected.");
        }

        // Tests for Resources Links

        [Test, Order(26)]
        public void VerifyIsCustomerExperienceCenterLinkInResourcesNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsCustomerExperienceCenterLinkInResourcesNavigatesCorrectly(), "The 'Customer Experience Center' link in Resources menu does not navigate to Customer Experience Center page as expected.");
        }

        [Test, Order(27)]
        public void VerifyIsSystemStatusLinkInResourcesNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsSystemStatusLinkInResourcesNavigatesCorrectly(), "The 'SystemStatus' link in Resources menu does not navigate to SystemStatus page as expected.");
        }

        [Test, Order(28)]
        public void VerifyIsWallexPediaLinkInResourcesNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsWallexPediaLinkInResourcesNavigatesCorrectly(), "The 'WallexPedia' link in Resources menu does not navigate to WallexPedia page as expected.");
        }

        [Test, Order(29)]
        public void VerifyIsWallexWhitePaperLinkInResourcesNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsWallexWhitePaperLinkInResourcesNavigatesCorrectly(), "The 'Wallex WhitePaper' link in Resources menu does not navigate to Wallex WhitePaper page as expected.");
        }

        [Test, Order(30)]
        public void VerifyIsCareersLinkInResourcesNavigatesCorrectly()
        {
            Assert.IsTrue(homePage.IsCareersLinkInResourcesNavigatesCorrectly(), "The 'Careers' link in Resources menu does not navigate to Careers page as expected.");
        }


    }
}
