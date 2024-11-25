namespace WllxTextingProject.Pages
{
    public class BasePage
    {
        protected readonly IWebDriver driver;

        protected readonly WebDriverWait wait;

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

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(this.PageUrl);
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

        public bool IsNavigationBarLinksDisplayed()
        {
            return FindElement(buyCryptoLink).Displayed &&
            FindElement(marketsLink).Displayed;
        }

        public bool IsHomeLogoButtonDisplayed()
        {
            return FindElement(homeLogoButton).Displayed;
        }
    }
}
