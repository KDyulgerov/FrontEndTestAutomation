using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HandlingFormInputs
{
    public class HandlingFormInputs
    {
        WebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://practice.bpbonline.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }

        [Test]
        public void CreatingAccountWithFormHandling()
        {
            driver.FindElement(By.XPath("//a[@id='tdb3']//span[@class='ui-button-text']")).Click();

            driver.FindElement(By.XPath("//a[@id='tdb4']//span[@class='ui-button-text']")).Click();

            driver.FindElement(By.XPath("//input[@type='radio'][@value='m']")).Click();

            driver.FindElement(By.XPath("//input[@name='firstname']")).SendKeys("MyFirstName");

            driver.FindElement(By.XPath("//input[@name='lastname']")).SendKeys("MyLastName");

            // Using date picker created by us
            DatePicker datePicker = new DatePicker(driver);
            datePicker.OpenDatePicker(By.Id("dob"));

            datePicker.SelectDate("Jan", "1994", 1);

            // Fill in date
            // driver.FindElement(By.Id("dob']")).SendKeys("01/01/1994");

            // Generate an unique email address
            Random rnd = new Random();
            // Generate a random number between 1000 and 9999
            int num = rnd.Next(1000, 9999);
            string email = "fiona.apple" + num.ToString() + "@example.com";

            driver.FindElement(By.XPath("//input[@name='email_address']")).SendKeys(email);

            driver.FindElement(By.XPath("//input[@name='company']")).SendKeys("MyCompanyName");

            driver.FindElement(By.XPath("//input[@name='street_address']")).SendKeys("MyStreet");

            driver.FindElement(By.XPath("//input[@name='suburb']")).SendKeys("MySuburb");

            driver.FindElement(By.XPath("//input[@name='postcode']")).SendKeys("MyPostcode");

            driver.FindElement(By.XPath("//input[@name='city']")).SendKeys("MyCityName");

            driver.FindElement(By.XPath("//input[@name='state']")).SendKeys("MyStateName");

            new SelectElement(driver.FindElement(By.Name("country"))).SelectByText("Bulgaria");

            driver.FindElement(By.XPath("//input[@name='telephone']")).SendKeys("0888888888");

            driver.FindElement(By.XPath("//input[@name='fax']")).SendKeys("123456");

            driver.FindElement(By.XPath("//input[@name='newsletter']")).Click();

            driver.FindElement(By.XPath("//input[@name='password']")).SendKeys("password_123456");

            driver.FindElement(By.XPath("//input[@name='confirmation']")).SendKeys("password_123456");

            driver.FindElement(By.XPath("//button[@id='tdb4']//span[@class='ui-button-text']")).Click();

            // Assert account creation is success

            IWebElement accountCreatedMessage = driver.FindElement(By.XPath("//div[@id='bodyContent']//h1"));

            Assert.That(accountCreatedMessage.Text, Is.EqualTo("Your Account Has Been Created!"), "Account creation failed.");

            // Click on the [Log out] button
            driver.FindElement(By.XPath("//a[@id='tdb4']//span[@class='ui-button-text']")).Click();

            // Click on the [Continue] button
            driver.FindElement(By.XPath("//a[@id='tdb4']//span[@class='ui-button-text']")).Click();

            // Assert back to the home page

            IWebElement homePageH1Title = driver.FindElement(By.XPath("//div[@id='bodyContent']//h1"));

            Assert.That(homePageH1Title.Text, Is.EqualTo("Welcome to BPB Online"), "Home page is not loaded as expected");

            // Printing final message
            Console.WriteLine("User Account Created Succesfully with email: " + email);
        }
    }
}