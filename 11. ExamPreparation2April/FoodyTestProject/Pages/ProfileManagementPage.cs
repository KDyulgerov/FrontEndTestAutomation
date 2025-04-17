namespace FoodyTestProject.Pages
{
    public class ProfileManagementPage : BasePage
    {
        public ProfileManagementPage(IWebDriver driver) : base(driver) { }

        public readonly string PageUrl = BaseUrl + "/Profile";

        // Locating Profile Management Elements

        protected readonly By profileUsername = By.XPath("//h5[@class='my-3']");

        protected readonly By profileFullName = By.XPath("(//p[@class='text-muted mb-0'])[1]");

        protected readonly By profileEmail = By.XPath("(//p[@class='text-muted mb-0'])[2]");

        protected readonly By totalRevuesCount = By.XPath("(//p[@class='text-muted mb-0'])[3]");

        // Methods
    }
}
