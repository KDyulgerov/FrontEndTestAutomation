namespace RetakeExamTestPrject.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver) { }

        public readonly string PageUrl = BaseUrl + "/Home/Main";

        // Locating Home Page Elements

        protected readonly By createNoteButton = By.XPath("//a[@href='/Note/New']");

        protected readonly By doneNotesButton = By.XPath("//a[@href='/Note/Done']");

        protected readonly By logoutButton = By.XPath("//a[@href='/User/Logout']");

        // Methods

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(PageUrl);
        }

        public void NavigateToCreateNote()
        {
            Click(createNoteButton);
        }

        public void NavigateToDoneNotes()
        {
            Click(doneNotesButton);
        }

        public void Logout()
        {
            Click(logoutButton);
        }
    }
}
