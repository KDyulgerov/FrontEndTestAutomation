namespace MovieCatalogWebDriverTestProject.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;

        protected WebDriverWait wait;

        protected Actions actions;

        public static readonly string BaseUrl = "http://moviecatalog-env.eba-ubyppecf.eu-north-1.elasticbeanstalk.com";

        // Locating Elements

        protected readonly By aboutUsLink = By.XPath("//a[@class='nav-link js-scroll-trigger active']");

        protected readonly By ourServicesLinlk = By.XPath("//a[@class='nav-link js-scroll-trigger' and contains(text(), 'Our Services')]");

        protected readonly By loginLink = By.XPath("//a[@class='nav-link js-scroll-trigger' and contains(text(), 'Login')]");

        protected readonly By registerLink = By.XPath("//a[@class='nav-link js-scroll-trigger' and contains(text(), 'Register')]");

        protected readonly By copyrightsLink = By.XPath("//a[@class='nav-link js-scroll-trigger' and contains(text(), 'Copyrights')]");

        protected readonly By loginHereButton = By.XPath("//a[@id='loginBtn']");


        public BasePage(IWebDriver driver)
        {
            this.driver = driver;

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            actions = new Actions(driver);

        }

        // Methods
        public IWebElement FindElement(By by)
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return driver.FindElements(by);
        }

        public void Type(By by, string text)
        {
            var element = FindElement(by);
            element.Clear();
            element.SendKeys(text);
        }

        public void Click(By by)
        {
            FindElement(by).Click();
        }

        public string GetText(By by)
        {
            return FindElement(by).Text.Trim();
        }
    }
}
