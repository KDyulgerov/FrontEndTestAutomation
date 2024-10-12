using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ExerciseSeleniumWebDriver
{
    public class WorkingWithWebElements
    {
        WebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://practice.bpbonline.com/");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}