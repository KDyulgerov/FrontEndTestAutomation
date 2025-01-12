namespace UITestingPlaygroundTestProject.Pages
{
    public class VisibilityPage : BasePage
    {
        public readonly string PageUrl = BaseUrl + "/visibility";

        // Locators
        protected readonly By pageHeading = By.XPath("//h3");

        protected readonly By hideButton = By.XPath("//button[@id='hideButton']");

        protected readonly By removedButton = By.XPath("//button[@id='removedButton']");

        protected readonly By zeroWidthButton = By.XPath("//button[@id='zeroWidthButton']");

        protected readonly By overlappedButton = By.XPath("//button[@id='overlappedButton']");

        protected readonly By opacityButton = By.XPath("//button[@id='transparentButton']");

        protected readonly By visibilityHiddenButton = By.XPath("//button[@id='invisibleButton']");

        protected readonly By visibilityNoneButton = By.XPath("//button[@id='notdisplayedButton']");

        protected readonly By offscreenButton = By.XPath("//button[@id='offscreenButton']");


        public VisibilityPage(IWebDriver driver) : base(driver)
        {
        }

        // Methods
        public void OpenPage()
        {
            driver.Navigate().GoToUrl(PageUrl);
        }

        public bool IsPageHeadingCorrect()
        {
            return IsPageHeadingTextCorrect(pageHeading, "Visibility");
        }

        public void ClickHideButton()
        {
            Click(hideButton);
        }

        private bool IsElementVisible(By by)
        {
            try
            {
                var element = driver.FindElement(by);
                return element.Displayed && element.Size.Width > 0 && element.Size.Height > 0 && !IsElementCovered(element);
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            catch (StaleElementReferenceException)
            {
                return false;
            }
            catch (WebDriverTimeoutException)
            {
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private bool IsElementCovered(IWebElement element)
        {
            return element.GetDomAttribute("style").Contains("visibility: hidden") ||
                   element.GetDomAttribute("style").Contains("opacity: 0") ||
                   element.GetDomAttribute("style").Contains("display: none");
        }

        public bool IsRemovedButtonDisplayed()
        {
            return IsElementVisible(removedButton);
        }

        public bool IsZeroWidthButtonDisplayed()
        {
            return IsElementVisible(zeroWidthButton);
        }

        public bool IsOverlappedButtonDisplayed()
        {
            return IsElementVisible(overlappedButton);
        }

        public bool IsOpacityButtonDisplayed()
        {
            return IsElementVisible(opacityButton);
        }

        public bool IsVisibilityHiddenButtonDisplayed()
        {
            return IsElementVisible(visibilityHiddenButton);
        }

        public bool IsVisibilityNoneButtonDisplayed()
        {
            return IsElementVisible(visibilityNoneButton);
        }

        public bool IsOffscreenButtonDisplayed()
        {
            return IsElementVisible(offscreenButton);
        }
    }
}
