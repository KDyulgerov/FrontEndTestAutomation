namespace FoodyTestProject.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;

        protected WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        protected static readonly string BaseUrl = "http://softuni-qa-loadbalancer-2137572849.eu-north-1.elb.amazonaws.com:85";

        // Locating Base Page Elements

        public readonly By loginButton = By.XPath("//a[@class='nav-link' and contains(text(), 'Log In')]");

        public readonly By signUpButton = By.XPath("//a[@class='nav-link' and contains(text(), 'Sign Up')]");

        public readonly By homeLink = By.XPath("//a[@class='navbar-brand']");

        // Methods

        public void OpenBasePage()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }

        public IWebElement FindElement(By by)
        {
            try
            {
                return wait.Until(ExpectedConditions.ElementIsVisible(by));
            }
            catch (WebDriverTimeoutException e)
            {
                // Log the error with details about the element
                throw new NoSuchElementException($"Element not found: {by}", e);
            }
        }

        public IReadOnlyCollection<IWebElement> FindElements(By by)
        {
            try
            {
                return wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(by));
            }
            catch (WebDriverTimeoutException e)
            {
                // Log the error with details about the element collection
                throw new NoSuchElementException($"Elements not found: {by}", e);
            }
        }

        public bool WaitUrlToBe(string url)
        {
            try
            {
                return wait.Until(ExpectedConditions.UrlToBe(url));
            }
            catch (WebDriverTimeoutException ex)
            {
                Console.WriteLine($"Timeout waiting for URL to be: {url}. Current URL: {driver.Url}");
                throw new Exception($"Expected URL '{url}' but was '{driver.Url}'", ex);
            }
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
