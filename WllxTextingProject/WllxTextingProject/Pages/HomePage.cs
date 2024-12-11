namespace WllxTextingProject.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageUrl => "https://wallex.global";

        protected readonly By homePageBankingHeading = By.XPath("//h1[@class='display-1 text-center']");

        protected readonly By homePageBankingDescription = By.XPath("//div[@class='row mt-lg-5 my-2']//p[@class='text-center']");

        protected readonly By homePageWallexLogoSignUpButton = By.XPath("//div[@class='row d-flex flex-row align-items-center justify-content-center box-grad-buttons dark-buttons']//a[@class='btn btn-outline-light square-btn me-3']");

        protected readonly By homePageWallexLogoSignUpButtonPopUp = By.XPath("//div[@class='pup-signin']/h5[text()='Sign Up to:']");

        protected readonly By homePageGooglePlayButton = By.XPath("//div[@class='row d-flex flex-row align-items-center justify-content-center box-grad-buttons dark-buttons']//a[@class='btn btn-outline-light square-btn'][@data-bs-target]");

        protected readonly By homePageGooglePlayButtonPopUp = By.XPath("//div[@class='pup-signin pup-apps']/h5[text()='Wallex Apps for Android']");

        protected readonly By homePageAppStoreButton = By.XPath("//div[@class='row d-flex flex-row align-items-center justify-content-center box-grad-buttons dark-buttons']//a[@class='btn btn-outline-light square-btn mx-3']");

        protected readonly By homePageAppStoreButtonPopUp = By.XPath("//div[@class='pup-signin pup-apps']/h5[text()='Wallex Apps for iOS']");

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


        // Methods for First Heading ----------->

        public bool IsBankingHeadingAndDescriptionTextCorrect()
        {
            return GetText(homePageBankingHeading).Trim() == "Banking for the web 5 era." &&
            GetText(homePageBankingDescription).Trim() == "Buy, sell, spend, and earn crypto on the most advanced crypto ecosystem.";
        }

        // Methods for First Four Buttons and Slider ----------->
        public bool IsFourButtonsBelowBankingHeaderDisplayed()
        {
            return FindElement(homePageWallexLogoSignUpButton).Displayed &&
                    FindElement(homePageGooglePlayButton).Displayed &&
                    FindElement(homePageAppStoreButton).Displayed &&
                    FindElement(homePageArrowExploreButton).Displayed;
        }

        public bool IsWallexLogoSingUpButtonNavigatesCorrectly()
        {
            Click(homePageWallexLogoSignUpButton);

            var element = FindElement(homePageWallexLogoSignUpButtonPopUp);

            return element.Displayed && element.Text.Trim() == "Sign Up to:";

        }

        public bool IsGooglePlayButtonNavigatesCorrectly()
        {
            Click(homePageGooglePlayButton);

            var element = FindElement(homePageGooglePlayButtonPopUp);

            return element.Displayed && element.Text.Trim() == "Wallex Apps for Android";
        }

        public bool IsAppStoreButtonNavigatesCorrectly()
        {
            Click(homePageAppStoreButton);

            var element = FindElement(homePageAppStoreButtonPopUp);

            return element.Displayed && element.Text.Trim() == "Wallex Apps for iOS";
        }

        public bool IsArrowExploreButtonNavigatesCorrectly()
        {
            Click(homePageArrowExploreButton);

            return driver.Url == "https://wallex.global/explore" && driver.Title == "EXPLORE WALLEX - All main solutions and features at a glance.";
        }

        public bool IsSliderWithPhonesDisplayed()
        {
            return FindElement(homePagePhoneSliderElement).Displayed;
        }

        public bool IsSliderDisplaysAllPhonesAndTablets()
        {
            return FindElement(sliderNeobankingPhone).Displayed &&
                FindElement(sliderCustodyProPhone).Displayed &&
                FindElement(sliderSmartCustodyPhone).Displayed &&
                FindElement(sliderSelfManagedCustodyPhone).Displayed &&
                FindElement(sliderWallexPayTablet).Displayed &&
                FindElement(sliderNftTablet).Displayed;
        }

        // Methods for Cards ----------->

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

        public bool IsCardsCardButtonNavigatesProperly()
        {
            Click(homePageCardsCardArrowButton);

            return driver.Url == "https://wallex.global/card" && driver.Title == "Wallex Card";
        }

        public bool IsBuySellSwapCardHeadingTextCorrect()
        {
            string cardText = GetText(homePageBuySellSwapCard);

            return cardText.Contains("BUY, SELL & SWAP.");
        }

        public bool IsBuySellSwapCardButtonNavigatesProperly()
        {
            Click(homePageBuySellSwapCardArrowButton);

            return driver.Url == "https://app.wallex.global/auth/sign-up" && driver.Title == "Wallex";
        }

        public bool IsInviteFriendsCardHeadingAndDescriptionTextCorrect()
        {
            string cardHeadingText = GetText(homePageinviteFriendsCardHeading);
            string cardDescriptionText = GetText(homePageInviteFriendsCardDescription);

            return cardHeadingText.Trim() == "INVITE FRIENDS." &&
            cardDescriptionText.Trim() == "Get rewarded.";
        }

        public bool IsInviteFriendsCardButtonNavigatesProperly()
        {
            Click(homePageInviteFriendsCardArrowButton);

            return driver.Url == "https://wallex.global/referral" && driver.Title == "Wallex - Invite Friends and get rewarded easily";
        }

        public bool IsEarnCardHeadingAndDescriptionTextCorrect()
        {
            string cardHeadingText = GetText(homePageEarnCardHeading);
            string cardDescriptionText = GetText(homePageEarnCardDescription);

            return cardHeadingText.Trim() == "EARN." &&
            cardDescriptionText.Trim() == "Earn interest up to 12 % on your cryptocurrency and stablecoins while you hold it with our flexible and fixed plans. Deposit in your saving account.";
        }

        public bool IsEarnCardButtonNavigatesProperly()
        {
            Click(homePageEarnCardArrowButton);

            return driver.Url == "https://wallex.global/saving" && driver.Title == "WALLEX - Savings";
        }

        // Methods for Second Heading and Description ----------->

        public bool IsBuildAndManageHeadingAndDescriptionTextCorrect()
        {
            return GetText(homePageBuildAndManageHeading).Trim() == "BUILD & MANAGE YOUR PORTFOLIO." &&
            GetText(homePageBuildAndManageDescription).Trim() == "Build a robust and varied portfolio featuring the market's leading cryptocurrencies.";
        }

        // Methods for Stay on Track Card ----------->

        public bool IsStayOnTrackCardHeadingAndDescriptionTextCorrect()
        {
            return GetText(homePageStayOnTrackCardHeading).Trim() == "STAY ON TRACK." &&
            GetText(homePageStayOnTrackCardDescription).Trim() == "Keep track of your favourite assets. Invest in Bitcoin, Ethereum, Polkadot, and numerous other globally top-ranking coins.";
        }

        public bool IsStayOnTrackCardButtonNavigatesProperly()
        {
            Click(homePageStayOnTrackCardArrowButton);

            return driver.Url == "https://wallex.global/markets" && driver.Title == "WALLEX NEOBANKING - Markets";
        }

        public bool IsTopGainersChartDisplayed()
        {
            Click(homePageStayOnTrackCardTopGainersLink);

            return FindElement(homePageStayOnTrackCardTopGainersContainer).Displayed;
        }

        public bool IsTopLosersChartDisplayed()
        {
            Click(homePageStayOnTrackCardTopLosersLink);

            return FindElement(homePageStayOnTrackCardTopLosersContainer).Displayed;
        }

        // Methods for Stay on Track Card ----------->

        public bool IsStablecoinsCardHeadingAndDescriptionTextCorrect()
        {
            return GetText(homePageStablecoinCardHeading).Trim() == "STABLECOINS." &&
            GetText(homePageStablecoinCardDescription).Trim() == "Wallex supports the most popular stablecoins with deposit options and savings plans on EURST, Dai, Tether, Polygon and more.";
        }

        public bool IsStablecoinsCardButtonNavigatesProperly()
        {
            Click(homePageStablecoinCardGetStartedButton);

            return driver.Url == "https://app.wallex.global/auth/sign-up" && driver.Title == "Wallex";
        }

        // Methods for CountBox ----------->

        public bool IsWallexCountBoxTextCorrect()
        {
            var elementAsString = GetText(homePageWallexCountBox);

            return elementAsString.Contains("Turnover") &&
            elementAsString.Contains("Clients") &&
            elementAsString.Contains("Cryptocurrencies") &&
            elementAsString.Contains("Jurisdictions");
        }

        // Methods for WX Credit ----------->

        public bool IsWxCreditCardHeadingAndDescriptionTextCorrect()
        {
            return GetText(homePageWxCreditCardHeading).Trim() == "WX-Credit." &&
            GetText(homePageWxCreditCardDescription).Trim() == "Access credit without selling your cryptocurrency. Enjoy low rates and instant access to your credit line by adding funds.";
        }

        public bool IsWxCreditCardButtonNavigatesProperly()
        {
            Click(homePageWxCreditCardGetCreditButton);

            return driver.Url == "https://wallex.global/credit" && driver.Title == "Wallex WX-CREDIT";
        }

        // To add last heading ------------>
    }
}
