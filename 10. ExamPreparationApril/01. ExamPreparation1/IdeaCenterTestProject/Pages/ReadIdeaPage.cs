namespace IdeaCenterTestProject.Pages
{
    public class ReadIdeaPage : BasePage
    {
        public ReadIdeaPage(IWebDriver driver) : base(driver)
        {
        }

        // Locating read idea page elements

        protected readonly By ideaTitle = By.XPath("//h1[@class='mb-0 h4']");

        protected readonly By ideaDescription = By.XPath("//p[@class='offset-lg-3 col-lg-6']");

        protected readonly By editIdeaButton = By.XPath("//a[@style='background-color: #3b5998;']");

        protected readonly By deleteIdeaButton = By.XPath("//a[@style='background-color: #55acee;']");

        // Methods

        public bool IsIdeaTitleCorrect(string lastCreatedIdeaTitle)
        {
            return GetText(ideaTitle) == lastCreatedIdeaTitle.Trim();
        }

        public bool IsIdeaDescriptionCorrect(string lastCreatedIdeaDescription)
        {
            return GetText(ideaDescription) == lastCreatedIdeaDescription.Trim();
        }
    }
}
