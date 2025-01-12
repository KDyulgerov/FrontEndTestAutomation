namespace UITestingPlaygroundTestProject.Pages
{
    public class AjaxDataPage : BasePage
    {
        public readonly string PageUrl = BaseUrl + "/ajax";

        // Locators
        protected readonly By pageHeading = By.XPath("//h3");

        protected readonly By buttonTriggeringAjax = By.XPath("//button[@id='ajaxButton']");

        protected readonly By succeesDataField = By.XPath("//p[@class='bg-success']");

        public AjaxDataPage(IWebDriver driver) : base(driver)
        {
        }

        // Methods
        public void OpenPage()
        {
            driver.Navigate().GoToUrl(PageUrl);
        }

        public bool IsPageHeadingCorrect()
        {
            return IsPageHeadingTextCorrect(pageHeading, "AJAX Data");
        }

        public bool IsAjaxDataDisplayedWithCorrectMessage()
        {
            Click(buttonTriggeringAjax);
            var SuccessDataField = FindElementWithCustomTimeout(succeesDataField, 16);
            return SuccessDataField.Displayed && SuccessDataField.Text == "Data loaded with AJAX get request.";

        }
    }
}
