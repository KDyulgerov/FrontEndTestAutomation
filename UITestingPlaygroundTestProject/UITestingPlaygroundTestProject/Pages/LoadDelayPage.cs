namespace UITestingPlaygroundTestProject.Pages
{
    public class LoadDelayPage : BasePage
    {
        public readonly string PageUrl = BaseUrl + "/loaddelay";

        public readonly string BasePageUrl = BaseUrl;

        protected readonly By pageHeading = By.XPath("//h3");

        protected readonly By delayButton = By.XPath("//button[@class='btn btn-primary']");

        // Locators
        public LoadDelayPage(IWebDriver driver) : base(driver)
        {
        }

        // Methods
        public void OpenPage()
        {
            driver.Navigate().GoToUrl(PageUrl);
        }

        public bool IsPageHeadingCorrect()
        {
            return IsPageHeadingTextCorrect(pageHeading, "Load Delays");
        }

        public bool IsDelayButtonClicked()
        {
            LoadDelayButton.Click();

            var DelayButton = FindElementWithCustomTimeout(delayButton, 30);

            var buttonClicked = true;

            try
            {
                DelayButton.Click(); // Attempting a click
            }
            catch(ElementClickInterceptedException)
            {
                buttonClicked = false;
            }

            return buttonClicked;
        }
    }
}
