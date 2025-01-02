using IdeaCenterTestProject.Pages;

namespace IdeaCenterTestProject.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;

        protected LoginPage loginPage;

        protected CreateIdeaPage createIdeaPage;

        protected MyIdeasPage myIdeasPage;

        [OneTimeSetUp]
        public void OneTimeSetUp() 
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference("profile.password_manager_enabled", false);
            chromeOptions.AddArgument("--disable-search-engine-choice-screen");

            driver = new ChromeDriver(chromeOptions);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            loginPage = new LoginPage(driver);
            createIdeaPage = new CreateIdeaPage(driver);
            myIdeasPage = new MyIdeasPage(driver);

            // Login to the application
            loginPage.OpenPage();
            loginPage.Login("emailtest@example.com", "123456");
        }

        [OneTimeTearDown]
        public void OneTimeTearDown() 
        { 
            driver.Quit();
            driver.Dispose();
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
