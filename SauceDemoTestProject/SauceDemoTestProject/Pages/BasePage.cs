namespace SauceDemoTestProject.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;

        protected WebDriverWait wait;

        protected Actions actions;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            actions = new Actions(driver);
        }

        public static readonly string BaseUrl = "https://www.saucedemo.com";

    }
}
