namespace RetakeExamTestPrject.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;

        protected BasePage basePage;
        
        protected HomePage homePage;

        protected LoginPage loginPage;

        protected NewNotePage newNotePage;

        protected CreateNotePage createNotePage;

        protected EditNotePage editNotePage;

        protected DoneNotesPage doneNotesPage;

        protected DeleteNotePage deleteNotePage;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var options = new ChromeOptions();
            options.AddUserProfilePreference("profile.password_manager_enabled", false);
            options.AddArgument("--disable-search-engine-choice-screen");
            options.AddArgument("--disable-features=PasswordLeakDetection");
            // options.AddArgument("guest");
            // options.AddArgument("--headless");

            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);

            basePage = new BasePage(driver);
            homePage = new HomePage(driver);
            loginPage = new LoginPage(driver);
            newNotePage = new NewNotePage(driver);
            createNotePage = new CreateNotePage(driver);
            editNotePage = new EditNotePage(driver);
            doneNotesPage = new DoneNotesPage(driver);
            deleteNotePage = new DeleteNotePage(driver);

            loginPage.OpenPage();
            loginPage.Login("genadi123@example.com", "123456abcD");
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
