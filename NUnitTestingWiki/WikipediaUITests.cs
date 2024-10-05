using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace NUnitTestingWiki
{
    public class WikipediaUITests
    {
        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();

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
            driver.Navigate().GoToUrl("https://www.google.com");

            driver.FindElement(By.Id("searchInput")).SendKeys("Quality Assurance" + Keys.Enter);

            Assert.That(driver.Title, Is.EqualTo("Quality assurance - Wikipedia"));
        }
    }
}