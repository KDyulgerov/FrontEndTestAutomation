namespace RetakeExamTestPrject.Pages
{
    public class DoneNotesPage : BasePage
    {
        public DoneNotesPage(IWebDriver driver) : base(driver) { }

        public readonly string PageUrl = BaseUrl + "/Note/Done";

        // Locating Done Notes Page Elements

        protected readonly By noteCards = By.XPath("//div[@class='card text-center']");
        public ReadOnlyCollection<IWebElement> NoteCards => (ReadOnlyCollection<IWebElement>)FindElements(noteCards);

        public IWebElement LastCreatedNoteTitle => NoteCards.Last().FindElement(By.XPath(".//h5[@class='card-title']"));
        public IWebElement LastCreatedNoteDescription => NoteCards.Last().FindElement(By.XPath(".//p[@class='card-text']"));
        public IWebElement LastCreatedNoteDeleteButton => NoteCards.Last().FindElement(By.XPath(".//a[@class='btn btn-danger']"));

        protected readonly By toastMessage = By.XPath("//div[@id='toast-container']");

        // Methods

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(PageUrl);
        }

        public bool IsToastMessageTextCorrect(string message)
        {
            return GetText(toastMessage) == message;
        }
    }
}
