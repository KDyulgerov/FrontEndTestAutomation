namespace UITestingPlaygroundTestProject.Pages
{
    public class HiddenLayersPage : BasePage
    {
        public readonly string PageUrl = BaseUrl + "/hiddenlayers";

        // Locators
        protected readonly By pageHeading = By.XPath("//h3");

        protected readonly By greenButton = By.XPath("//button[@id='greenButton']");

        protected readonly By blueButton = By.XPath("//button[@id='blueButton']");

        public HiddenLayersPage(IWebDriver driver) : base(driver)
        {
        }

        // Methods
        public void OpenPage()
        {
            driver.Navigate().GoToUrl(PageUrl);
        }
        
        public void ClickGreenButton()
        {
            Click(greenButton);
        }

        public bool IsExceptionThrownAfterGreenButtonSecondClick()
        {
            var GreenButton = FindElement(greenButton);

            var exceptionThrown = false;

            try
            {
                GreenButton.Click(); // Attempting a second click
            }
            catch (ElementClickInterceptedException)
            {
                exceptionThrown = true;
            }

            return exceptionThrown;
        }

        public bool IsBlueButtonEnabledAndDisplayed()
        {
            var BlueButton = FindElement(blueButton);
            return BlueButton.Enabled && BlueButton.Displayed;
        }

        public bool IsPageHeadingCorrect()
        {
            return IsPageHeadingTextCorrect(pageHeading, "Hidden Layers");
        }
    }
}
