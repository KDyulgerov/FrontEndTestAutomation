namespace IdeaCenterTestProject.Pages
{
    public class MyIdeasPage : BasePage
    {
        public MyIdeasPage(IWebDriver driver) :base(driver)
        {
        }

        public string PageUrl = BaseUrl + "/Ideas/MyIdeas";

        // Locating My Ideas Page Elements

        protected readonly By ideasCards = By.XPath("//div[@class='card mb-4 box-shadow']");

        protected ReadOnlyCollection<IWebElement> IdeaCards => FindElements(ideasCards);

        protected IWebElement viewButtonLastIdea => IdeaCards.Last().FindElement(By.XPath(".//a[contains(@href, '/Ideas/Read')]"));
        protected IWebElement editButtonLastIdea => IdeaCards.Last().FindElement(By.XPath(".//a[contains(@href, '/Ideas/Edit')]"));
        protected IWebElement deleteButtonLastIdea => IdeaCards.Last().FindElement(By.XPath(".//a[contains(@href, '/Ideas/Delete')]"));
        public IWebElement descriptionLastIdea => IdeaCards.Last().FindElement(By.XPath(".//p[@class='card-text']"));


        // Methods
        public void OpenPage()
        {
            driver.Navigate().GoToUrl(PageUrl);
        }

        public bool IsDescriptionLastIdeaTextCorrect(string lastCreatedIdeaDescription)
        {
            return descriptionLastIdea.Text == lastCreatedIdeaDescription;
        }

    }
}
