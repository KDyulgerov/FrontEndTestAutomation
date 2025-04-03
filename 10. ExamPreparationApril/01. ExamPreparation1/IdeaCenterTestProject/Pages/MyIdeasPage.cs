using System.Collections.ObjectModel;

namespace IdeaCenterTestProject.Pages
{
    public class MyIdeasPage : BasePage
    {
        public MyIdeasPage(IWebDriver driver) : base(driver)
        {
        }

        public readonly string PageUrl = BaseUrl + "/Ideas/MyIdeas";

        // Locating my ideas page elements

        public readonly By ideasCards = By.XPath("//div[@class='card mb-4 box-shadow']");

        public ReadOnlyCollection<IWebElement> IdeaCards => (ReadOnlyCollection<IWebElement>)FindElements(ideasCards);

        public IWebElement ViewButtonLastIdea => IdeaCards.Last().FindElement(By.XPath(".//a[contains(@href, '/Ideas/Read')]"));
        public IWebElement EditButtonLastIdea => IdeaCards.Last().FindElement(By.XPath(".//a[contains(@href, '/Ideas/Edit')]"));
        public IWebElement DeleteButtonLastIdea => IdeaCards.Last().FindElement(By.XPath(".//a[contains(@href, '/Ideas/Delete')]"));
        public IWebElement DescriptionLastIdea => IdeaCards.Last().FindElement(By.XPath(".//p[@class='card-text']"));

        // Methods
        public void OpenPage()
        {
            driver.Navigate().GoToUrl(PageUrl);
        }

        public bool IsDescriptionLastIdeaTextCorrect(string lastCreatedIdeaDescription)
        {
            return DescriptionLastIdea.Text == lastCreatedIdeaDescription;
        }

        public bool IsUrlCorrect(string expectedUrl)
        {
            return WaitUrlToBe(expectedUrl);
        }

        public bool IsIdeaDeleted(string lastCreatedIdeaDescription)
        {
            try
            {
                return !IdeaCards.Any(card => card.Text.Contains(lastCreatedIdeaDescription));
            }
            catch
            {
                return true;
            }
        }
    }
}
