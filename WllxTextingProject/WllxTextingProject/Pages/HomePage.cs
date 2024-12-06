namespace WllxTextingProject.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageUrl => "https://wallex.global/";

        protected readonly By homePageBankingHeading = By.XPath("//h1[@class='display-1 text-center']");

        protected readonly By homePageBankingDescription = By.XPath("//div[@class='row mt-lg-5 my-2']//p[@class='text-center']");

        protected readonly By homePageWallexLogoSignUpButton = By.XPath("//div[@class='row d-flex flex-row align-items-center justify-content-center box-grad-buttons dark-buttons']//a[@class='btn btn-outline-light square-btn me-3']");

        protected readonly By homePageGooglePlayButton = By.XPath("//div[@class='row d-flex flex-row align-items-center justify-content-center box-grad-buttons dark-buttons']//a[@class='btn btn-outline-light square-btn'][@data-bs-target]");

        protected readonly By homePageAppStoreButton = By.XPath("//div[@class='row d-flex flex-row align-items-center justify-content-center box-grad-buttons dark-buttons']//a[@class='btn btn-outline-light square-btn mx-3']");

        protected readonly By homePageArrowExploreButton = By.XPath("//a[@href='/explore'][@class='btn btn-outline-light square-btn']");

        // Locating Phone Slider Element and Phones & Tablets
        protected readonly By homePagePhoneSliderElement = By.XPath("//div[@class='slider']");

        protected readonly By sliderNeobankingPhone = By.XPath("//div[@class='slider']//a[@href='/neobanking']");

        protected readonly By sliderCustodyProPhone = By.XPath("//div[@class='slider']//a[@href='/custody-pro']");

        protected readonly By sliderSmartCustodyPhone = By.XPath("//div[@class='slider']//a[@href='/smart-custody']");

        protected readonly By sliderSelfManagedCustodyPhone = By.XPath("//div[@class='slider']//a[@href='/self-managed-custody']");

        protected readonly By sliderWallexPayTablet = By.XPath("//div[@class='slider']//a[@href='/wallex-pay']");

        protected readonly By sliderNftTablet = By.XPath("//div[@class='slider']//a[@href='https://nft.wallex.global/']");

        // Locating Home Page Elements & Cards
        protected readonly By homePageHeadingElevate = By.XPath("//h2[@class='display-1' and contains(., 'ELEVATE')]");

        protected readonly By homePageDescriptionElevate = By.XPath("//div[@class='col pt-5']//p");

        // Locating Cards Card & Details

        // Locatind Cards Card
        protected readonly By homePageCardsCard = By.XPath("//div[@class='card-body d-flex flex-column justify-content-between p-xxl-5 p-4 py-4' and contains(., 'CARDS')]");

        protected readonly By homePageCardsCardArrowButton = By.XPath("//div[@class='text-end pb-lg-0']//a[@href='/card']");

        // Buy Sell Swap Card
        protected readonly By homePageBuySellSwapCard = By.XPath("//div[@class='col-md-4 d-md-flex d-none']//div[@class='card mb-5 box-gradient--02 box-gradient--02_v2']");

        protected readonly By homePageBuySellSwapCardArrowButton = By.XPath("//div[@class='text-end pb-lg-0']//a[@href='https://app.wallex.global/auth/sign-up']");

        protected readonly By wallexGlobalAppSignUpTitle = By.XPath("//div[@class='head flex-row']//div[@class='title']");

        // Invite Friends Card
        protected readonly By homePageinviteFriendsCardHeading = By.XPath("//div[@class='card-body p-xxl-5 p-4']//h2");

        protected readonly By homePageInviteFriendsCardDescription = By.XPath("//div[@class='card-body p-xxl-5 p-4']//p");

        protected readonly By homePageInviteFriendsCardArrowButton = By.XPath("//div[@class='text-end pb-lg-0']//a[@href='/referral']");

        // Earn Card
        protected readonly By homePageEarnCardHeading = By.XPath("//div[@class='col-lg-7 col-md-6 d-flex flex-column justify-content-center']//h2");

        protected readonly By homePageEarnCardDescription = By.XPath("//div[@class='col-lg-7 col-md-6 d-flex flex-column justify-content-center']//p");

        protected readonly By homePageEarnCardArrowButton = By.XPath("//div[@class='text-end pb-lg-0']//a[@href='/saving']");

        // Build & Manage Elements
        protected readonly By homePageBuildAndManageHeading = By.XPath("//div[@class='container px-sm-0']//div[@class='row d-flex justify-content-center text-center elevate_title']//h2");

        protected readonly By homePageBuildAndManageDescription = By.XPath("//div[@class='container px-sm-0']//div[@class='row d-flex justify-content-center text-center elevate_title']//div");

        // Stay on Track Card
        protected readonly By homePageStayOnTrackCardTopGainersLink = By.XPath("//div[@class='col-lg-12 d-flex flex-column align-items-start markets-selector']//ul//li[@id='01']");

        protected readonly By homePageStayOnTrackCardTopLosersLink = By.XPath("//div[@class='col-lg-12 d-flex flex-column align-items-start markets-selector']//ul//li[@id='02']");

        protected readonly By homePageStayOnTrackCardTopGainersContainer = By.XPath("//div[@class='container assets__container --gainers opacity-100 --active']");

        protected readonly By homePageStayOnTrackCardTopLosersContainer = By.XPath("//div[@class='container assets__container --losers --active']");

        protected readonly By homePageStayOnTrackCardHeading = By.XPath("//div[@class='row pt-xxl-5 pb-xxl-0 py-4']//h2");

        protected readonly By homePageStayOnTrackCardDescription = By.XPath("//div[@class='row pt-xxl-5 pb-xxl-0 py-4']//p");

        protected readonly By homePageStayOnTrackCardArrowButton = By.XPath("//div[@class='text-start pb-lg-0']/a");

        // Stablecoins Card
        protected readonly By homePageStablecoinCardHeading = By.XPath("//div[@class='col-lg-7 col-md-6 col-8 d-flex flex-column justify-content-evenly']/div/h2");

        protected readonly By homePageStablecoinCardDescription = By.XPath("//div[@class='col-lg-7 col-md-6 col-8 d-flex flex-column justify-content-evenly']/div/div[@class='col-lg-8 col-md-12 pt-4']");

        protected readonly By homePageStablecoinCardGetStartedButton = By.XPath("//div[@class='row']//div[@class='pb-lg-0 ps-lg-0 ps-md-2']/a[@href='https://app.wallex.global/auth/sign-up']");

        // Count Wallex Box Turnover Clients Cryptocurrencies Jurisdictions
        protected readonly By homePageWallexCountBox = By.XPath("//div[@class='row gy-4']");

        // WX-Credit Card
        protected readonly By homePageWxCreditCardHeading = By.XPath("//h3[@class='display-3 d-md-flex d-none mg-bottom-0 text-md-start text-center']");

        protected readonly By homePageWxCreditCardDescription = By.XPath("//p[@class='me-xl-5 text-md-start text-center']");

        protected readonly By homePageWxCreditCardGetCreditButton = By.XPath("//div[@class='col-12 d-flex flex-row align-items-center buttons-arrow-wrapper']/a[@href='/credit']");

        // Try the digital banking Heading and app buttons
        protected readonly By homePageTryTheDigitalBankingHeading = By.XPath("//h2[@class='display-2']");

        protected readonly By homePageTryTheDigitalBankingAppStoreButton = By.XPath("//div[@class='col-lg-4 col-12 d-flex justify-content-center align-items-center']/button[@class='btn btn-outline-primary apps-btn']");

        protected readonly By homePageTryTheDigitalBankingGooglePlayButton = By.XPath("//div[@class='col-lg-4 col-12 d-flex justify-content-center align-items-center']/button[@class='btn btn-outline-primary apps-btn ms-2']");

        // Creating BuyCryptoPage class

        // Creating MarketsPage class

        // Creating ProductNeobankingPage class

        // Creating ProductCustodyProPage class

        // Creating ProductSmartCustodyPage class

        // Creating ProductSelfManagedCustodyPage class

        // Creating ProductWallexPayPage class

        // Creating TO DO MORE! class


        // Methods TO DO! ---------------------

        public bool IsElevateHeadingAndDescriptionTextCorrect()
        {
            return GetText(homePageHeadingElevate).Trim() == "ELEVATE YOUR FINANCES." &&
            GetText(homePageDescriptionElevate).Trim() == "Our incredibly intuitive features guide you through your daily needs and in planning your future.";
        }

        public bool IsCardsCardHeadingAndDescriptionTextCorrect()
        {
            string cardText = GetText(homePageCardsCard);

            return cardText.Contains("CARDS.") &&
            cardText.Contains("Spend your crypto easily.");
        }

        public bool IsBuySellSwapCardHeadingTextCorrect()
        {
            string cardText = GetText(homePageBuySellSwapCard);

            return cardText.Contains("BUY, SELL & SWAP.");
        }

        public bool IsBuySellSwapCardButtonNavigatesProperly()
        {
            var arrowButton = FindElement(homePageBuySellSwapCardArrowButton);
            var wallexGlobalAppTitle = FindElement(wallexGlobalAppSignUpTitle);

            arrowButton.Click();

            return driver.Url == "https://app.wallex.global/auth/sign-up" && wallexGlobalAppTitle.Displayed;
        }
    }
}
