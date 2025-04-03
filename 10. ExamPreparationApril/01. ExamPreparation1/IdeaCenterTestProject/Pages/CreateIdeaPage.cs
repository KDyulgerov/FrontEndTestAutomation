namespace IdeaCenterTestProject.Pages
{
    public class CreateIdeaPage : BasePage
    {
        public CreateIdeaPage(IWebDriver driver) : base(driver)
        {
        }

        public readonly string PageUrl = BaseUrl + "/Ideas/Create";

        // Logating create idea page elements

        protected readonly By titleInput = By.XPath("//input[@name='Title']");

        protected readonly By urlInput = By.XPath("//input[@name='Url']");

        protected readonly By descriptionInput = By.XPath("//textarea[@name='Description']");

        protected readonly By createButton = By.XPath("//button[@class='btn btn-primary btn-lg']");

        protected readonly By mainErrorMessage = By.XPath("//div[@class='text-danger validation-summary-errors']/ul/li");

        protected readonly By titleErrorMessage = By.XPath("//span[@data-valmsg-for='Title']");

        protected readonly By descriptionErrorMessage = By.XPath("//span[@data-valmsg-for='Description']");

        // Methods

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(PageUrl);
        }

        public void CreateIdea(string title, string url, string description)
        {
            Type(titleInput, title);
            Type(urlInput, url);
            Type(descriptionInput, description);
            Click(createButton);
        }

        public bool IsMainErrorMesssageCorrect()
        {
            return GetText(mainErrorMessage) == "Unable to create new Idea!";
        }

        public bool IsTitleErrorMessageCorrect()
        {
            return GetText(titleErrorMessage) == "The Title field is required.";
        }

        public bool IsDescriptionErrorMessageCorrect()
        {
            return GetText(descriptionErrorMessage) == "The Description field is required.";
        }
    }
}
