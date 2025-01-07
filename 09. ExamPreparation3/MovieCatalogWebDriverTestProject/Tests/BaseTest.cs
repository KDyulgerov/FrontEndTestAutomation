

namespace MovieCatalogWebDriverTestProject.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;

        protected Actions actions;

        protected BasePage basePage;

        protected LoginPage loginPage;

        protected AddMoviePage addMoviePage;

        protected AllMoviesPage allMoviesPage;

        protected EditMoviePage editMoviePage;

        protected WatchedMoviesPage watchedMoviesPage;


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
            loginPage = new LoginPage(driver);
            addMoviePage = new AddMoviePage(driver);
            allMoviesPage = new AllMoviesPage(driver);
            editMoviePage = new EditMoviePage(driver);
            watchedMoviesPage = new WatchedMoviesPage(driver);

            // Performing Login
            loginPage.OpenPage();
            loginPage.Login("stavriuser@example.com", "123456");
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
