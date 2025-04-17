namespace FoodyTestProject.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;

        protected BasePage basePage;

        protected LoginPage loginPage;

        protected HomePage homePage;

        protected AddFoodPage addFoodPage;

        protected EditFoodPage editFoodPage;

        protected ProfileManagementPage profileManagementPage;

        protected EditProfilePage editProfilePage;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var options = new ChromeOptions();
            options.AddUserProfilePreference("profile.password_manager_enabled", false);
            options.AddArgument("--disable-search-engine-choice-screen");
            options.AddArgument("--disable-features=PasswordLeakDetection");
            options.AddArgument("guest");
            // options.AddArgument("--headless");

            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            basePage = new BasePage(driver);
            loginPage = new LoginPage(driver);
            homePage = new HomePage(driver);
            addFoodPage = new AddFoodPage(driver);
            editFoodPage = new EditFoodPage(driver);
            profileManagementPage = new ProfileManagementPage(driver);
            editProfilePage = new EditProfilePage(driver);

            loginPage.OpenPage();
            loginPage.Login("Alabala456", "123456abcD");
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

        protected static string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
