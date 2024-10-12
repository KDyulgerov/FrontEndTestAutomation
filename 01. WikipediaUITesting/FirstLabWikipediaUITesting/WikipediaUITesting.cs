using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace NUnitTestingWiki
{
    public class WikipediaUITests
    {
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddUserProfilePreference("profile.password_manager_enabled", false);

            driver = new ChromeDriver(chromeOptions);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Manage().Window.Maximize();
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }


        [Test]
        public void VerifyQualityAssuranceTitle()
        {
            driver.Navigate().GoToUrl("https://www.wikipedia.org/");

            driver.FindElement(By.Id("searchInput")).SendKeys("Quality Assurance" + Keys.Enter);

            Assert.That(driver.Title, Is.EqualTo("Quality assurance - Wikipedia"));
        }

        [Test]
        public void VerifyQualityAssurancePageTitle()
        {
            driver.Navigate().GoToUrl("https://www.wikipedia.org/");

            driver.FindElement(By.Id("searchInput")).SendKeys("Quality Assurance" + Keys.Enter);

            var pageTitle = driver.FindElement(By.ClassName("mw-page-title-main"));

            Assert.That(pageTitle.Text, Is.EqualTo("Quality assurance"));
        }
    }
}