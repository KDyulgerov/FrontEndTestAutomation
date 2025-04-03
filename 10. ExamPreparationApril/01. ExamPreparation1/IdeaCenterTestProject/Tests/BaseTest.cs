using NUnit.Framework.Constraints;

namespace IdeaCenterTestProject.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;

        protected BasePage basePage;

        protected LoginPage loginPage;

        protected CreateIdeaPage createIdeaPage;

        protected MyIdeasPage myIdeasPage;

        protected ReadIdeaPage readIdeaPage;

        protected EditIdeaPage editIdeaPage;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var options = new ChromeOptions();
            options.AddUserProfilePreference("profile.password_manager_enabled", false);
            options.AddArgument("--disable-search-engine-choice-screen");
            options.AddArgument("--disable-features=PasswordLeakDetection");
            options.AddArgument("guest");

            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            basePage = new BasePage(driver);
            loginPage = new LoginPage(driver);
            createIdeaPage = new CreateIdeaPage(driver);
            myIdeasPage = new MyIdeasPage(driver);
            readIdeaPage = new ReadIdeaPage(driver);
            editIdeaPage = new EditIdeaPage(driver);

            loginPage.OpenPage();
            loginPage.Login("alabala@example.com", "123456");
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
