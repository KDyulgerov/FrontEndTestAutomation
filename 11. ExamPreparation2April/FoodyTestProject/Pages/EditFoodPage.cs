namespace FoodyTestProject.Pages
{
    public class EditFoodPage : BasePage
    {
        public EditFoodPage(IWebDriver driver) : base(driver) { }

        // Locating Edit Food Page Elements

        protected readonly By foodNameInput = By.XPath("//input[@id='name']");

        protected readonly By foodDescriptionInput = By.XPath("//input[@id='description']");

        protected readonly By foodUrlInput = By.XPath("//input[@id='url']");

        protected readonly By addButton = By.XPath("//button[@class='btn btn-primary btn-block fa-lg gradient-custom-2 mb-3']");

        // Methods
    }
}
