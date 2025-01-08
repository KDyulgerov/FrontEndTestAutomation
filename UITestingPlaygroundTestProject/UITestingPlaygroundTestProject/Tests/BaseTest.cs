namespace UITestingPlaygroundTestProject.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;

        protected Actions actions;

        protected BasePage basePage;

        protected HiddenLayersPage hiddenLayersPage;

        protected LoadDelayPage loadDelayPage;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference("profile.password_manager_enabled", false);
            chromeOptions.AddArgument("--disable-search-engine-choice-screen");

            driver = new ChromeDriver(chromeOptions);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            actions = new Actions(driver);
            basePage = new BasePage(driver);
            hiddenLayersPage = new HiddenLayersPage(driver);
            loadDelayPage = new LoadDelayPage(driver);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }

        public string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
