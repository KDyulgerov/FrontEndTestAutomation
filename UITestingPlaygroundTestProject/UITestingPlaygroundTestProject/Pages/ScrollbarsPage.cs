namespace UITestingPlaygroundTestProject.Pages
{
    public class ScrollbarsPage : BasePage
    {
        public readonly string PageUrl = BaseUrl + "/scrollbars";

        // Locators
        protected readonly By pageHeading = By.XPath("//h3");

        protected readonly By hiddenButton = By.XPath("//button[@class='btn btn-primary']");

        protected readonly By scrollSection = By.XPath("//td[@style='width:300px;']");

        public ScrollbarsPage(IWebDriver driver) : base(driver)
        {
        }

        // Methods
        public void OpenPage()
        {
            driver.Navigate().GoToUrl(PageUrl);
        }

        public bool IsPageHeadingCorrect()
        {
            return IsPageHeadingTextCorrect(pageHeading, "Scrollbars");
        }

        public bool IsHiddentButtonDisplayed()
        {
            return FindElement(hiddenButton).Displayed;
        }

        public bool IsHiddenButtonClickable()
        {
            var notExceptionThrown = true;

            try
            {
                Click(hiddenButton);
            }
            catch
            {
                notExceptionThrown = false;
            }

            return notExceptionThrown;
        }

        public void ScrollToHiddenElement()
        {
            var ScrollSection = FindElement(scrollSection);
            WheelInputDevice.ScrollOrigin scrollOrigin = new WheelInputDevice.ScrollOrigin
            {
                Element = ScrollSection
            };
            new Actions(driver)
                .ScrollFromOrigin(scrollOrigin, 220, 60)
                .Perform();
        }
    }
}
