namespace FoodyTestProject.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver) { }

        public readonly string PageUrl = BaseUrl + "/User/Login";

        // Locating Login Page Elements

        protected readonly By usernameInput = By.XPath("//input[@id='username']");

        protected readonly By passwordInput = By.XPath("//input[@id='password']");

        protected readonly By logInButton = By.XPath("//button[@class='btn btn-primary btn-block fa-lg gradient-custom-2 mb-3']");

        // Methods

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(PageUrl);
        }

        public void Login(string username, string password)
        {
            Type(usernameInput, username);
            Type(passwordInput, password);
            Click(logInButton);
        }
    }
}
