using SeleniumExtras.WaitHelpers;

namespace SeleniumWebDriverPOMExercise.Pages
{
    public class BasePage
    {
        protected readonly IWebDriver driver;

        protected readonly WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
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
    }
}
