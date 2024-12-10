namespace WllxTextingProject.Pages
{
    public class BasePage
    {
        protected readonly IWebDriver driver;

        protected readonly WebDriverWait wait;

        protected readonly Actions actions;

        public virtual string? PageUrl { get; }

        // Locating Navigation Bar Elements
        protected readonly By homeLogoButton = By.XPath("//div[@class='container container-xl p-0']//a");

        protected readonly By buyCryptoLink = By.XPath("//li[@class='d-lg-flex d-none']//a[contains(@href, '/buy-crypto')]");

        protected readonly By marketsLink = By.XPath("//li[@class='d-lg-flex d-none']//a[@href='/markets']");

        protected readonly By productsLink = By.XPath("//a[@class='hover-underline-animation']//span[text()='Products']");

        protected readonly By primeLink = By.XPath("//a[@class='hover-underline-animation']//span[text()='Prime']");

        protected readonly By labsLink = By.XPath("//a[@class='hover-underline-animation']//span[text()='Labs']");

        protected readonly By resourcesLink = By.XPath("//a[@class='hover-underline-animation']//span[text()='Resources']");

        protected readonly By signInButton = By.XPath("//div[@class='navbar']//a[@class='signin-btn']");

        protected readonly By appStoreButton = By.XPath("//div[@class='col-6 d-flex justify-content-end']//button[@class='btn btn-outline-primary apps-btn me-1']");

        protected readonly By googlePlayButton = By.XPath("//div[@class='col-6 d-flex justify-content-end']//button[@class='btn btn-outline-primary apps-btn']");

        // Locating Procuts Menu Elements
        protected readonly By productsNeobankingLink = By.XPath("//div[@class='col-md-6']//a[@href='/neobanking']");

        protected readonly By productsCustodyProLink = By.XPath("//div[@class='col-md-6']//a[@href='/custody-pro']");

        protected readonly By productsSmartCustodyLink = By.XPath("//div[@class='col-md-6']//a[@href='/smart-custody']");

        protected readonly By productsSelfManagedCustodyLink = By.XPath("//div[@class='col-md-6']//a[@href='/self-managed-custody']");

        protected readonly By productsWallexPayLink = By.XPath("//div[@class='col-md-6']//a[@href='/wallex-pay']");

        protected readonly By productsEurstLink = By.XPath("//div[@class='col-md-6']//a[@href='https://eurst.io/']");

        protected readonly By productsNftLink = By.XPath("//div[@class='col-md-6']//a[@href='https://nft.wallex.global/']");

        protected readonly By productsWallexCardLink = By.XPath("//div[@class='col-md-6']//a[@href='/card']");

        protected readonly By productsEarnAndSavingsLink = By.XPath("//div[@class='col-md-6']//a[@href='/saving']");

        protected readonly By productsWallexCreditLink = By.XPath("//div[@class='col-md-6']//a[@href='/credit']");

        protected readonly By productsCryptocurrencyLink = By.XPath("//div[@class='col-md-6']//a[@href='/cryptocurrency']");

        protected readonly By productsPaymentsLink = By.XPath("//div[@class='col-md-6']//a[@href='/payments']");

        protected readonly By productsEurustBackRewardsLink = By.XPath("//div[@class='col-md-6']//a[@href='/rewards']");

        protected readonly By productsInviteAFriendLink = By.XPath("//div[@class='col-md-6']//a[@href='/referral']");

        protected readonly By productsExploreLink = By.XPath("//div[@class='col-12 d-flex flex-row align-items-center buttons-arrow-wrapper justify-content-center']//a[@href='/explore']");

        protected readonly By productsBuyCryptoButton = By.XPath("//button[@class='btn btn-outline-primary apps-btn d-flex flex-row align-items-center']");

        // Locating Prime Menu Elements
        protected readonly By primeCorporateLink = By.XPath("//div[@class='col-md-6 px-0 mb-0 mb-lg-0']//a[@href='/corporate']");

        protected readonly By primePrivateLink = By.XPath("//div[@class='col-md-6 px-0 mb-0 mb-lg-0']//a[@href='/personal']");

        protected readonly By primeWealthLink = By.XPath("//div[@class='col-md-6 px-0 mb-0 mb-lg-0']//a[@href='/wealth']");

        protected readonly By primeAmbassadorsLink = By.XPath("//div[@class='col-md-6 px-0 mb-0 mb-lg-0']//a[@href='/ambassadors']");

        // Locating Labs Menu Elements
        protected readonly By labsWallexLabLink = By.XPath("//div[@class='col-md-6 px-0 mb-0 mb-lg-0']//a[@href='https://www.wallexlab.com/']");

        protected readonly By labsVenturesLink = By.XPath("//div[@class='col-md-6 px-0 mb-0 mb-lg-0']//a[@href='/wallex_ventures']");

        protected readonly By labsFoundationLink = By.XPath("//div[@class='col-md-6 px-0 mb-0 mb-lg-0']//a[@href='/foundation/']");

        // Locating Resources Menu Elements
        protected readonly By resourcesHelpLink = By.XPath("//li[@class='dropdown d-lg-flex d-none']//ul//li//a[@href='https://intercom.help/platform-faq/en']");

        protected readonly By resourcesCustomerExperienceCenterLink = By.XPath("//li[@class='dropdown d-lg-flex d-none']//ul//li//a[@href='https://experience.wallex.global/wallex']");

        protected readonly By resourcesSystemStatusLink = By.XPath("//li[@class='dropdown d-lg-flex d-none']//ul//li//a[@href='https://experience.wallex.global/wallex/system-status']");

        protected readonly By resourcesWallexpediaLink = By.XPath("//li[@class='dropdown d-lg-flex d-none']//ul//li//a[@href='/wallexpedia']");

        protected readonly By resourcesWallexWhitepaperLink = By.XPath("//li[@class='dropdown d-lg-flex d-none']//ul//li//a[@href='https://experience.wallex.global/wallex/whitepaper']");

        protected readonly By resourcesCareersLink = By.XPath("//li[@class='dropdown d-lg-flex d-none']//ul//li//a[@href='/careers']");

        protected readonly By resourcesDiscordLink = By.XPath("//li[@class='dropdown d-lg-flex d-none']//ul//li//a[@href='#']"); // [Soon] - Currently Not Available

        protected readonly By cookiesAcceptButton = By.XPath("//button[@class='iubenda-cs-accept-btn iubenda-cs-btn-primary']");

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            actions = new Actions(driver);
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(this.PageUrl);

            var cookiesAcceptButtonPopUp = driver.FindElements(cookiesAcceptButton).FirstOrDefault();
            if (cookiesAcceptButtonPopUp != null && cookiesAcceptButtonPopUp.Displayed)
            {
                cookiesAcceptButtonPopUp.Click();
            }
        }

        protected IWebElement FindElement(By by)
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        protected ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return driver.FindElements(by);
        }

        protected void Type(By by, string text)
        {
            var element = FindElement(by);
            element.Clear();
            element.SendKeys(text);
        }

        protected void Click(By by)
        {
            FindElement(by).Click();
        }

        protected string GetText(By by)
        {
            return FindElement(by).Text;
        }

        public bool IsHomeLogoButtonDisplayed()
        {
            return FindElement(homeLogoButton).Displayed;
        }

        public bool IsBuyCryptoLinkDisplayed()
        {
            return FindElement(buyCryptoLink).Displayed;
        }

        public bool IsBuyCryptoLinkNavigatesCorrectly()
        {
            Click(buyCryptoLink);

            return driver.Url == "https://wallex.global/buy-crypto?asset=APE_ERC20" && driver.Title == "WALLEX NEOBANKING - Market widget";
        }

        public bool IsMarketsLinkDisplayed()
        {
            return FindElement(marketsLink).Displayed;
        }

        public bool IsMarketsLinkNavigatesCorrectly()
        {
            Click(marketsLink);

            return driver.Url == "https://wallex.global/markets" && driver.Title == "WALLEX NEOBANKING - Markets";
        }

        public bool IsProductsLinkDisplayed()
        {
            return FindElement(productsLink).Displayed;
        }

        public bool isProductsDropdownPlatformsDisplayed()
        {
            var element = FindElement(productsLink);
            actions.MoveToElement(element).Perform();

            return FindElement(productsNeobankingLink).Displayed &&
                FindElement(productsCustodyProLink).Displayed &&
                FindElement(productsSmartCustodyLink).Displayed &&
                FindElement(productsSelfManagedCustodyLink).Displayed &&
                FindElement(productsWallexPayLink).Displayed &&
                FindElement(productsEurstLink).Displayed &&
                FindElement(productsNftLink).Displayed;
        }

        public bool isProductsDropdownFeaturesDisplayed()
        {
            var element = FindElement(productsLink);
            actions.MoveToElement(element).Perform();

            return FindElement(productsWallexCardLink).Displayed &&
                FindElement(productsEarnAndSavingsLink).Displayed &&
                FindElement(productsWallexCreditLink).Displayed &&
                FindElement(productsCryptocurrencyLink).Displayed &&
                FindElement(productsPaymentsLink).Displayed;
        }

        public bool isProductsDropdownRewardsDisplayed()
        {
            var element = FindElement(productsLink);
            actions.MoveToElement(element).Perform();

            return FindElement(productsEurustBackRewardsLink).Displayed &&
                FindElement(productsInviteAFriendLink).Displayed;
        }

        public bool IsProductsDropdownExploreLinkDisplayed()
        {
            return FindElement(productsBuyCryptoButton).Displayed;
        }

        public bool IsProductsDropdownBuyCryptoButtonDisplayed()
        {
            return FindElement(productsExploreLink).Displayed;
        }

        public bool IsPrimeLinkDisplayed()
        {
            return FindElement(primeLink).Displayed;
        }

        public bool isPrimeDropdownLinksDisplayed()
        {
            var element = FindElement(primeLink);
            actions.MoveToElement(element).Perform();

            return FindElement(primeCorporateLink).Displayed &&
                FindElement(primePrivateLink).Displayed &&
                FindElement(primeWealthLink).Displayed &&
                FindElement(primeAmbassadorsLink).Displayed;
        }

        public bool IsLabsLinkDisplayed()
        {
            return FindElement(labsLink).Displayed;
        }

        public bool isLabsDropdownLinksDisplayed()
        {
            var element = FindElement(labsLink);
            actions.MoveToElement(element).Perform();

            return FindElement(labsWallexLabLink).Displayed &&
                FindElement(labsVenturesLink).Displayed &&
                FindElement(labsFoundationLink).Displayed;
        }

        public bool IsResourcesLinkDisplayed()
        {
            return FindElement(resourcesLink).Displayed;
        }

        public bool isResourcesDropdownLinksDisplayed()
        {
            var element = FindElement(resourcesLink);
            actions.MoveToElement(element).Perform();

            return FindElement(resourcesHelpLink).Displayed &&
                FindElement(resourcesCustomerExperienceCenterLink).Displayed &&
                FindElement(resourcesSystemStatusLink).Displayed &&
                FindElement(resourcesWallexpediaLink).Displayed &&
                FindElement(resourcesWallexWhitepaperLink).Displayed &&
                FindElement(resourcesCareersLink).Displayed &&
                FindElement(resourcesDiscordLink).Displayed;
        }

        public bool IsSignInLinkDisplayed()
        {
            return FindElement(signInButton).Displayed;
        }

        public bool IsAppStoreButtonDisplayed()
        {
            return FindElement(appStoreButton).Displayed;
        }

        public bool IsGooglePlayButtonDisplayed()
        {
            return FindElement(googlePlayButton).Displayed;
        }

        // Methods for Platforms in Products

        public bool IsNeobankingLinkInProductsNavigatesCorrectly()
        {
            var element = FindElement(productsLink);
            actions.MoveToElement(element).Perform();

            Click(productsNeobankingLink);

            return driver.Url == "https://wallex.global/neobanking" && driver.Title == "WALLEX NEOBANKING - Pay Smart, Pay Wallex";
        }

        public bool IsCustodyProLinkInProductsNavigatesCorrectly()
        {
            var element = FindElement(productsLink);
            actions.MoveToElement(element).Perform();

            Click(productsCustodyProLink);

            return driver.Url == "https://wallex.global/custody-pro" && driver.Title == "Custody PRO - Safe custody of assets - users can deposit and store their fiat and crypto with a reliable, easy-to-use platform.";
        }

        public bool IsSmartCustodyLinkInProductsNavigatesCorrectly()
        {
            var element = FindElement(productsLink);
            actions.MoveToElement(element).Perform();

            Click(productsSmartCustodyLink);

            return driver.Url == "https://wallex.global/smart-custody" && driver.Title == "Smart Custody - An innovative custodial wallet for saving, convenient management & spending with card.";
        }

        public bool IsSelfCustodyLinkInProductsNavigatesCorrectly()
        {
            var element = FindElement(productsLink);
            actions.MoveToElement(element).Perform();

            Click(productsSelfManagedCustodyLink);

            return driver.Url == "https://wallex.global/self-managed-custody" && driver.Title == "Self Managed Custody - Designed for clients who wish to manage their own wallet keys and hold the full access to their information, which is kept securely.";
        }

        public bool IsWallexPayLinkInProductsNavigatesCorrectly()
        {
            var element = FindElement(productsLink);
            actions.MoveToElement(element).Perform();

            Click(productsWallexPayLink);

            return driver.Url == "https://wallex.global/wallex-pay" && driver.Title == "WALLEX PAY - THE BEST CRYPTO PAYMENT FOR BUSINESS.";
        }

        public bool IsEurstLinkInProductsNavigatesCorrectly()
        {
            var element = FindElement(productsLink);
            actions.MoveToElement(element).Perform();

            Click(productsEurstLink);

            return driver.Url == "https://eurst.io" && driver.Title == "EURST"; // Title to be checked once website is available
        }

        public bool IsNftLinkInProductsNavigatesCorrectly()
        {
            var element = FindElement(productsLink);
            actions.MoveToElement(element).Perform();

            Click(productsNftLink);

            return driver.Url == "https://nft.wallex.global/" && driver.Title == "Wallex - NFT Marketplace";
        }

        // Methods for Features in Products 

        public bool IsWallexCardLinkInProductsNavigatesCorrectly()
        {
            var element = FindElement(productsLink);
            actions.MoveToElement(element).Perform();

            Click(productsWallexCardLink);

            return driver.Url == "https://wallex.global/card" && driver.Title == "Wallex Card";
        }

        public bool IsEarnAndSavingsLinkInProductsNavigatesCorrectly()
        {
            var element = FindElement(productsLink);
            actions.MoveToElement(element).Perform();

            Click(productsEarnAndSavingsLink);

            return driver.Url == "https://wallex.global/saving" && driver.Title == "WALLEX - Savings";
        }

        public bool IsWallexCreditLinkInProductsNavigatesCorrectly()
        {
            var element = FindElement(productsLink);
            actions.MoveToElement(element).Perform();

            Click(productsWallexCreditLink);

            return driver.Url == "https://wallex.global/credit" && driver.Title == "Wallex WX-CREDIT";
        }

        public bool IsCryptocurrencyLinkInProductsNavigatesCorrectly()
        {
            var element = FindElement(productsLink);
            actions.MoveToElement(element).Perform();

            Click(productsCryptocurrencyLink);

            return driver.Url == "https://wallex.global/cryptocurrency" && driver.Title == "Wallex - Cryptocurrency";
        }

        public bool IsPaymentsLinkInProductsNavigatesCorrectly()
        {
            var element = FindElement(productsLink);
            actions.MoveToElement(element).Perform();

            Click(productsPaymentsLink);

            return driver.Url == "https://wallex.global/payments" && driver.Title == "PAYMENTS - Your GATEWAY FOR THE WEB.3 EXPERIENCE.";
        }

        // Methods for Rewards in Products 
        public bool IsEurustBackRewardsLinkInProductsNavigatesCorrectly()
        {
            var element = FindElement(productsLink);
            actions.MoveToElement(element).Perform();

            Click(productsEurustBackRewardsLink);

            return driver.Url == "https://wallex.global/rewards" && driver.Title == "EURSTback™ Rewards - Spend with your Wallex Card and earn EURST";
        }

        public bool IsInviteAFriendLinkInProductsNavigatesCorrectly()
        {
            var element = FindElement(productsLink);
            actions.MoveToElement(element).Perform();

            Click(productsInviteAFriendLink);

            return driver.Url == "https://wallex.global/referral" && driver.Title == "Wallex - Invite Friends and get rewarded easily";
        }

        // Right side elements in Pruducts menu

        public bool IsExploreLinkInProductsNavigatesCorrectly()
        {
            var element = FindElement(productsLink);
            actions.MoveToElement(element).Perform();

            Click(productsExploreLink);

            return driver.Url == "https://wallex.global/explore" && driver.Title == "EXPLORE WALLEX - All main solutions and features at a glance.";
        }

        public bool IsBuyCryptoButtonInProductsNavigatesCorrectly()
        {
            var element = FindElement(productsLink);
            actions.MoveToElement(element).Perform();

            Click(productsBuyCryptoButton);

            return driver.Url == "https://app.wallex.global/auth/sign-up" && driver.Title == "Wallex";
        }

        // Methods for Prime menu
        public bool IsCorporateLinkInPrimesNavigatesCorrectly()
        {
            var element = FindElement(primeLink);
            actions.MoveToElement(element).Perform();

            Click(primeCorporateLink);

            return driver.Url == "https://wallex.global/corporate" && driver.Title == "Wallex Prime - Corporate";
        }

        public bool IsPrivateLinkInPrimesNavigatesCorrectly()
        {
            var element = FindElement(primeLink);
            actions.MoveToElement(element).Perform();

            Click(primePrivateLink);

            return driver.Url == "https://wallex.global/personal" && driver.Title == "Wallex Prime - Personal.";
        }

        public bool IsWealthLinkInPrimesNavigatesCorrectly()
        {
            var element = FindElement(primeLink);
            actions.MoveToElement(element).Perform();

            Click(primeWealthLink);

            return driver.Url == "https://wallex.global/wealth" && driver.Title == "WALLEX WEALTH - Digital Asset Investment Services for Wealthy Investors.";
        }

        public bool IsAmbassadorLinkInPrimesNavigatesCorrectly()
        {
            var element = FindElement(primeLink);
            actions.MoveToElement(element).Perform();

            Click(primeAmbassadorsLink);

            return driver.Url == "https://wallex.global/ambassadors" && driver.Title == "Wallex Ambassador Club";
        }

        // Methods for Labs menu

        public bool IsWallexLabLinkInLabsNavigatesCorrectly()
        {
            var element = FindElement(labsLink);
            actions.MoveToElement(element).Perform();

            Click(labsWallexLabLink);

            return driver.Url == "https://wallexlab.com" && driver.Title == "WallexLab"; // Title to be checked once website is available
        }

        public bool IsVenturesLinkInLabsNavigatesCorrectly()
        {
            var element = FindElement(labsLink);
            actions.MoveToElement(element).Perform();

            Click(labsVenturesLink);

            return driver.Url == "https://wallex.global/wallex_ventures" && driver.Title == "WALLEX VENTURES - Embracing the Digital Assets Economy.";
        }

        public bool IsFoundationLinkInLabsNavigatesCorrectly()
        {
            var element = FindElement(labsLink);
            actions.MoveToElement(element).Perform();

            Click(labsFoundationLink);

            return driver.Url == "https://wallex.global/foundation/" && driver.Title == "Wallex Foundation - EMBRACING THE WEB3 ERA.";
        }

        // Methods for Labs menu

        public bool IsHelpLinkInResourcesNavigatesCorrectly()
        {
            var element = FindElement(resourcesLink);
            actions.MoveToElement(element).Perform();

            Click(resourcesHelpLink);

            return driver.Url == "https://intercom.help/platform-faq/en" && driver.Title == "Wallex Help Center";
        }

        public bool IsCustomerExperienceCenterLinkInResourcesNavigatesCorrectly()
        {
            var element = FindElement(resourcesLink);
            actions.MoveToElement(element).Perform();

            Click(resourcesCustomerExperienceCenterLink);

            return driver.Url == "https://experience.wallex.global/wallex" && driver.Title == "Explore Wallex | Wallex Global";
        }

        public bool IsSystemStatusLinkInResourcesNavigatesCorrectly()
        {
            var element = FindElement(resourcesLink);
            actions.MoveToElement(element).Perform();

            Click(resourcesSystemStatusLink);

            return driver.Url == "https://experience.wallex.global/wallex/system-status" && driver.Title == "System Status | Wallex Global";
        }

        public bool IsWallexPediaLinkInResourcesNavigatesCorrectly()
        {
            var element = FindElement(resourcesLink);
            actions.MoveToElement(element).Perform();

            Click(resourcesWallexpediaLink);

            return driver.Url == "https://wallex.global/wallexpedia" && driver.Title == "Wallexpedia";
        }

        public bool IsWallexWhitePaperLinkInResourcesNavigatesCorrectly()
        {
            var element = FindElement(resourcesLink);
            actions.MoveToElement(element).Perform();

            Click(resourcesWallexWhitepaperLink);

            return driver.Url == "https://experience.wallex.global/wallex/whitepaper" && driver.Title == "WhitePaper | Wallex Global";
        }

        public bool IsCareersLinkInResourcesNavigatesCorrectly()
        {
            var element = FindElement(resourcesLink);
            actions.MoveToElement(element).Perform();

            Click(resourcesCareersLink);

            return driver.Url == "https://wallex.global/careers" && driver.Title == "WALLEX CAREERS - Join us in our mission to provide more options, freedom, and chances to people globally.";
        }
    }
}
