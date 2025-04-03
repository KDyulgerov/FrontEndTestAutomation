namespace IdeaCenterTestProject.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) :base(driver)
        {
        }

        public static readonly string PageUrl = BaseUrl + "/Users/Login";

        // Locating login page elements

        protected readonly By emailInput = By.XPath("//input[@type='email']");

        protected readonly By passwordInput = By.XPath("//input[@type='password']");

        protected readonly By signInButton = By.XPath("//button[@class='btn btn-primary btn-lg btn-block']");

        // Methods

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(PageUrl);
        }

        public void Login(string email, string password)
        {
            Type(emailInput, email);
            Type(passwordInput, password);
            Click(signInButton);
        }
    }
}
