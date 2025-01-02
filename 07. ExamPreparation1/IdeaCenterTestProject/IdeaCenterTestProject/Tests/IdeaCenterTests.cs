namespace IdeaCenterTestProject.Tests
{
    public class IdeaCenterTests : BaseTest
    {
        private static string lastCreatedIdeaTitle;
        private static string lastCreatedIdeaDescription;

        [Test, Order(1)]
        public void Test_CreateIdeaWithInvalidData()
        {
            createIdeaPage.OpenPage();

            createIdeaPage.CreateIdea("", "", "");

            Assert.True(createIdeaPage.IsMainErrorMessageCorrect(), "The main error message is not as expected.");

            Assert.True(createIdeaPage.IsTitleErrorMessageCorrect(), "The title error message is not as expected.");

            Assert.True(createIdeaPage.IsDescriptionErrorMessageCorrect(), "The description error message is not as expected.");
        }

        [Test, Order(2)]
        public void Test_CreateRandomIdeaShouldSucceed()
        {
            lastCreatedIdeaTitle = "Idea " + GenerateRandomString(5);
            lastCreatedIdeaDescription = "Description " + GenerateRandomString(10);

            createIdeaPage.OpenPage();

            createIdeaPage.CreateIdea(lastCreatedIdeaTitle, "http://www.pictures.com/picture.jpg", lastCreatedIdeaDescription);

            Assert.That(driver.Url, Is.EqualTo(myIdeasPage.PageUrl), "URL is not correct");

            Assert.True(myIdeasPage.IsDescriptionLastIdeaTextCorrect(lastCreatedIdeaDescription), "The last created idea description is not as expected");
        }
    }
}
