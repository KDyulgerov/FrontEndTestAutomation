namespace RetakeExamTestPrject.Pages
{
    public class EditNotePage : BasePage
    {
        public EditNotePage(IWebDriver driver) : base(driver) { }

        // Locating Edit Note Page Elements

        protected readonly By titleInput = By.XPath("//input[@id='form4Example1']");

        protected readonly By descriptionInput = By.XPath("//textarea[@id='form4Example3']");

        protected readonly By dropDownMenu = By.XPath("//select[@id='form4Example3']");

        protected readonly By editButton = By.XPath("//button[@type='submit']");

        // Methods

        public void ChangeTitleTo(string title)
        {
            Type(titleInput, title);
            Click(editButton);
        }
    }
}
