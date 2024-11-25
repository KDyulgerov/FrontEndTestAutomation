using WllxTextingProject.Pages;

namespace WllxTextingProject.Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;

        protected HomePage homePage;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            homePage = new HomePage(driver);
        }

        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }
    }
}
