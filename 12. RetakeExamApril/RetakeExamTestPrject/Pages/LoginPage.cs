namespace RetakeExamTestPrject.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver) { }

        public readonly string PageUrl = BaseUrl + "/User/LoginRegister";

        // Locating Login Page Elements

        protected readonly By loginButton = By.XPath("//a[@id='tab-login']");

        protected readonly By emailInput = By.XPath("//input[@id='loginName']");

        protected readonly By passwordInput = By.XPath("//input[@id='loginPassword']");

        protected readonly By signInButton = By.XPath("//button[@class='btn btn-primary btn-block mb-4']");

        // Methods

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(PageUrl);
        }

        public void Login(string email, string password)
        {
            Click(loginButton);
            Type(emailInput, email);
            Type(passwordInput, password);
            Click(signInButton);
        }
    }
}
