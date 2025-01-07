namespace MovieCatalogWebDriverTestProject.Pages
{
    public class LoginPage : BasePage
    {
        public readonly string PageUrl = BaseUrl + "/User/Login";

        // Locators
        protected readonly By emailField = By.XPath("//input[@type='email']");

        protected readonly By passwordField = By.XPath("//input[@type='password']");

        protected readonly By loginButton = By.XPath("//button[@type='submit']");

        public LoginPage(IWebDriver driver) :base(driver) 
        {
        }

        // Methods
        public void OpenPage()
        {
            driver.Navigate().GoToUrl(PageUrl);
        }

        public void Login(string email, string password)
        {
            Type(emailField, email);
            Type(passwordField, password);
            Click(loginButton);
        }
    }
}
