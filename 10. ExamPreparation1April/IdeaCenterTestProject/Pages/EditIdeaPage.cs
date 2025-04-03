namespace IdeaCenterTestProject.Pages
{
    public class EditIdeaPage : BasePage
    {
        public EditIdeaPage(IWebDriver driver) :base(driver)
        {
        }

        // Locating edit idea page elemets
        protected readonly By editTitleInput = By.XPath("//input[@name='Title']");

        protected readonly By editUrlInput = By.XPath("//input[@name='Url']");

        protected readonly By editDescriptionInput = By.XPath("//textarea[@name='Description']");

        protected readonly By editIdeaButton = By.XPath("//button[@class='btn btn-primary btn-lg']");

        // Methods

        public void ChangeTitleTo(string updatedTitle)
        {
            Type(editTitleInput, updatedTitle);
            Click(editIdeaButton);
        }

        public void ChangeDescriptionTo(string updatedDescription)
        {
            Type(editDescriptionInput, updatedDescription);
            Click(editIdeaButton);
        }
    }
}
