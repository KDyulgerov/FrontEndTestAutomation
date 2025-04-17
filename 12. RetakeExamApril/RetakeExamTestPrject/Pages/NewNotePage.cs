namespace RetakeExamTestPrject.Pages
{
    public class NewNotePage : BasePage
    {
        public NewNotePage(IWebDriver driver) : base(driver) { }

        public readonly string PageUrl = BaseUrl + "/Note/New";

        // Locating New Note Page Elements

        protected readonly By createNoteButton = By.XPath("//a[@class='btn btn-info']");

        protected readonly By noteCards = By.XPath("//div[@class='card text-center']");

        // protected readonly By noteCards = By.XPath("//div[contains(@class, 'card') and contains(@class, 'text-center')]");
        public ReadOnlyCollection<IWebElement> NoteCards => (ReadOnlyCollection<IWebElement>)FindElements(noteCards);

        // public ReadOnlyCollection<IWebElement> NoteCards => new ReadOnlyCollection<IWebElement>(FindElements(noteCards).ToList());

        public IWebElement LastCreatedNoteTitle => NoteCards.Last().FindElement(By.XPath(".//h5[@class='card-title']"));
        public IWebElement LastCreatedNoteDescription => NoteCards.Last().FindElement(By.XPath(".//p[@class='card-text']"));
        public IWebElement LastCreatedNoteSetDoneButton => NoteCards.Last().FindElement(By.XPath(".//a[@class='btn btn-primary']"));
        public IWebElement LastCreatedNoteEditButton => NoteCards.Last().FindElement(By.XPath(".//a[@class='btn btn-info' and contains(text(), 'Edit')]"));
        public IWebElement LastCreatedNoteDeleteButton => NoteCards.Last().FindElement(By.XPath(".//a[@class='btn btn-danger']"));


        // Methods

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(PageUrl);
        }

        public void NavigateToCreateNotePage()
        {
            Click(createNoteButton);
        }
    }
}
