namespace MovieCatalogWebDriverTestProject.Pages
{
    public class AddMoviePage : BasePage
    {
        public readonly string PageUrl = BaseUrl + "/Catalog/Add#add";

        // Locators
        protected readonly By titleInput = By.XPath("//input[@name='Title']");

        protected readonly By descriptionInput = By.XPath("//textarea[@name='Description']");

        protected readonly By posterUrlInput = By.XPath("//input[@name='PosterUrl']");

        protected readonly By youTubeTrailerInput = By.XPath("//input[@name='TrailerLink']");

        protected readonly By markAsWatchedCheckbox = By.XPath("//input[@class='form-check-input']");

        protected readonly By addButton = By.XPath("//button[@type='submit' and contains(text(), 'Add')]");

        protected readonly By toastErrorMessage = By.XPath("//div[@class='toast-message']");

        public AddMoviePage(IWebDriver driver) : base(driver)
        {
        }

        // Methods
        public void OpenPage()
        {
            driver.Navigate().GoToUrl(PageUrl);
        }

        public void AddMovie(string title, string description, string posterUrl, string youTubeTrailer)
        {
            Type(titleInput, title);
            Type(descriptionInput, description);
            Type(posterUrlInput, posterUrl);
            Type(youTubeTrailerInput, youTubeTrailer);

            var AddButton = FindElement(addButton);
            actions.ScrollToElement(AddButton).Perform();
            AddButton.Click();
        }

        public void AddWatchedMovie(string title, string description, string posterUrl, string youTubeTrailer)
        {
            Type(titleInput, title);
            Type(descriptionInput, description);
            Type(posterUrlInput, posterUrl);
            Type(youTubeTrailerInput, youTubeTrailer);

            if (!FindElement(markAsWatchedCheckbox).Selected)
            {
                var MarkAsWatchedCheckbox = FindElement(markAsWatchedCheckbox);
                actions.ScrollToElement(MarkAsWatchedCheckbox).Perform();
                MarkAsWatchedCheckbox.Click();
            }

            var AddButton = FindElement(addButton);
            actions.ScrollToElement(AddButton).Perform();
            AddButton.Click();
        }

        public bool IsToastMessageCorrect(string expectedMessage)
        {
            return GetText(toastErrorMessage) == expectedMessage;
        }

    }
}
