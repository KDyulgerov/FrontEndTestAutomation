namespace MovieCatalogWebDriverTestProject.Pages
{
    public class EditMoviePage : BasePage
    {
        // Locators
        protected readonly By editTitleInput = By.XPath("//input[@name='Title']");

        protected readonly By editDescriptionInput = By.XPath("//textarea[@name='Description']");

        protected readonly By editPosterUrlInput = By.XPath("//input[@name='PosterUrl']");

        protected readonly By editYouTubeTrailerInput = By.XPath("//input[@name='TrailerLink']");

        protected readonly By editMarkAsWatchedCheckbox = By.XPath("//input[@class='form-check-input']");

        protected readonly By editButton = By.XPath("//button[@type='submit' and contains(text(), 'Edit')]");

        protected readonly By toastSuccessMessage = By.XPath("//div[@class='toast-message']");
        public IWebElement ToastSuccessMessage => FindElement(toastSuccessMessage);

        public EditMoviePage(IWebDriver driver) : base(driver)
        {
        }

        // Methods
        public void EditTitle(string newTitle)
        {
            Type(editTitleInput, newTitle);

            var EditButton = FindElement(editButton);
            actions.ScrollToElement(EditButton).Perform();
            EditButton.Click();
        }

        public bool IsToastSuccessMessageCorrect(string expectedMessage)
        {
            return GetText(toastSuccessMessage) == expectedMessage;
        }
    }
}
