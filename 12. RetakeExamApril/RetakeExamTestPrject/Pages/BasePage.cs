namespace RetakeExamTestPrject.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;

        protected WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
        }

        protected static readonly string BaseUrl = "https://d5wfqm7y6yb3q.cloudfront.net";

        // Locating Base Page Elements

        protected readonly By pageHeading = By.XPath("//h1[@class='mb-14 text-uppercase display-1']");

        protected readonly By accessDeniedElement = By.XPath("//pre[@style='word-wrap: break-word; white-space: pre-wrap;']");

        public readonly By joinUsNowButton = By.XPath("//a[@class='btn btn-outline-light btn-lg mt-5']");

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

        public bool IsPageHeadingTextCorrect(string heading)
        {
            return GetText(pageHeading) == heading;
        }

        public bool IsAccessDeniedElementDisplayed()
        {
            return FindElement(accessDeniedElement).Displayed && GetText(accessDeniedElement) == "Access Denied";
        }
    }
}
