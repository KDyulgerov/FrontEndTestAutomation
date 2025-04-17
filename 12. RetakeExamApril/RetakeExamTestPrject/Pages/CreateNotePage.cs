namespace RetakeExamTestPrject.Pages
{
    public class CreateNotePage : BasePage
    {
        public CreateNotePage(IWebDriver driver) : base(driver) { }

        public readonly string PageUrl = BaseUrl + "/Note/Create";

        // Locating Create Note Page Elements

        protected readonly By titleInput = By.XPath("//input[@id='form4Example1']");

        protected readonly By descriptionInput = By.XPath("//textarea[@id='form4Example3']");

        protected readonly By dropDownMenu = By.XPath("//select[@id='form4Example3']");

        protected readonly By createButton = By.XPath("//button[@type='submit']");

        protected readonly By errorToastMessage = By.XPath("//div[@id='toast-container']");

        // Methods

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(PageUrl);
        }

        public void createNote(string title, string description, string status)
        {
            Type(titleInput, title);
            Type(descriptionInput, description);
            var dropdown = FindElement(dropDownMenu);
            var selectElement = new SelectElement(dropdown);
            selectElement.SelectByText(status);
            Click(createButton);
        }

        public bool IsToastErrorMessageDisplayed()
        {
            return FindElement(errorToastMessage).Displayed;
        }

        public bool IsToastMessageTextCorrect(string errorMessage)
        {
            return GetText(errorToastMessage) == errorMessage;
        }
    }
}
