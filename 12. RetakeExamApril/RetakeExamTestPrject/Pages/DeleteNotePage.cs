namespace RetakeExamTestPrject.Pages
{
    public class DeleteNotePage : BasePage
    {
        public DeleteNotePage(IWebDriver driver) : base(driver) { }

        // Locating Delete Note Page Elements

        protected readonly By deleteNotePageHeading = By.XPath("//p[@class='display-4']");

        protected readonly By confirmDeleteNoteButton = By.XPath("//button[@type='submit']");

        protected readonly By rejectDeleteNoteButton = By.XPath("//a[@class='btn btn-danger btn-block mb-4 col-6']");

        // Methods

        public bool IsDeleteNotePageHeadingCorrect(string heading)
        {
            return GetText(deleteNotePageHeading) == heading;
        }

        public void ConfirmNoteDeletion()
        {
            Click(confirmDeleteNoteButton);
        }
    }
}
