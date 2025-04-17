namespace FoodyTestProject.Pages
{
    public class EditProfilePage : BasePage
    {
        public EditProfilePage(IWebDriver driver) : base(driver) {}

        public readonly string PageUrl = BaseUrl + "/Profile/Edit";

        // Locating Edit Profile Page Elements

        protected readonly By editProfileFirstNameInput = By.XPath("//input[@id='FirstName']");

        protected readonly By editProfileMiddleNameInput = By.XPath("//input[@id='MiddleName']");

        protected readonly By editProfileLastNameInput = By.XPath("//input[@id='LastName']");

        protected readonly By editProfileAboutInput = By.XPath("//input[@id='About']");

        protected readonly By editProfilePictureUrlInput = By.XPath("//input[@id='PictureUrl']");

        protected readonly By editProfileAddButton = By.XPath("//button[@class='btn btn-primary btn-block fa-lg gradient-custom-2 mb-3']");

        // Methods
    }
}
