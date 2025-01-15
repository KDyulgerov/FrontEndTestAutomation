namespace UITestingPlaygroundTestProject.Pages
{
    public class DynamicTable : BasePage
    {
        public readonly string PageUrl = BaseUrl + "/dynamictable";

        // Locators
        protected readonly By pageHeading = By.XPath("//h3");

        protected readonly By chromeRow = By.XPath("//div[@role='row'][span[contains(text(), 'Chrome')]]");
        protected IWebElement ChromeRow => FindElement(chromeRow);

        protected IWebElement CpuValue => ChromeRow.FindElement(By.XPath(".//span[contains(text(), '%')]"));

        protected readonly By chromeCpuResultValue = By.XPath("//p[@class='bg-warning']");

        public DynamicTable(IWebDriver driver) : base(driver)
        {
        }

        // Methods
        public void OpenPage()
        {
            driver.Navigate().GoToUrl(PageUrl);
        }

        public bool IsPageHeadingCorrect()
        {
            return IsPageHeadingTextCorrect(pageHeading, "Dynamic Table");
        }

        public bool IsChromeCpuValueCorrect()
        {
            var ChromeCpuResultValue = FindElement(chromeCpuResultValue).Text.Split(" ");

            return ChromeCpuResultValue[2].Trim() == CpuValue.Text.Trim();
        }
    }
}
