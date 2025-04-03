using IdeaCenterTestProject.Pages;
using OpenQA.Selenium.Support.UI;

namespace IdeaCenterTestProject.Tests
{
    public class IdeaCenterTests : BaseTest
    {
        private static string? lastCreatedIdeaTitle;
        private static string? lastCreatedIdeaDescription;
        private static string? updatedDescription;

        [Test, Order(1)]
        public void Test_CreateIdeaWithInvalidData_ShouldThrowErrorMessages()
        {
            createIdeaPage.OpenPage();
            createIdeaPage.CreateIdea("", "", "");

            Assert.Multiple(() =>
            {
                Assert.That(createIdeaPage.IsMainErrorMesssageCorrect(), Is.True, "The main error message is not as expected.");
                Assert.That(createIdeaPage.IsTitleErrorMessageCorrect(), Is.True, "The title error message is not as expected.");
                Assert.That(createIdeaPage.IsDescriptionErrorMessageCorrect(), Is.True, "The description error message is not as expected.");
            });

            Assert.That(driver.Url, Is.EqualTo(createIdeaPage.PageUrl), "The page was redirected incorrectly.");
        }

        [Test, Order(2)]
        public void Test_CreateRandomIdea_ShouldSucceed()
        {
            lastCreatedIdeaTitle = "Idea " + GenerateRandomString(5);
            lastCreatedIdeaDescription = "Description " + GenerateRandomString(10);

            createIdeaPage.OpenPage();
            createIdeaPage.CreateIdea(lastCreatedIdeaTitle, "https://www.planetware.com/wpimages/2020/02/france-in-pictures-beautiful-places-to-photograph-eiffel-tower.jpg", lastCreatedIdeaDescription);

            Assert.That(myIdeasPage.IsUrlCorrect(myIdeasPage.PageUrl), Is.True, "URL is not correct");

            Assert.That(myIdeasPage.IsDescriptionLastIdeaTextCorrect(lastCreatedIdeaDescription), Is.True, "The last created idea description is not as expected");
        }

        [Test, Order(3)]
        public void Test_ViewLastCreatedIdea_ShouldHaveCorrectTitleAndDescription()
        {
            myIdeasPage.OpenPage();
            myIdeasPage.ViewButtonLastIdea.Click();

            Assert.That(readIdeaPage.IsIdeaTitleCorrect(lastCreatedIdeaTitle), Is.True, "The title of the last created idea is not as expected in read page.");
            Assert.That(readIdeaPage.IsIdeaDescriptionCorrect(lastCreatedIdeaDescription), Is.True, "The description of the last created idea is not as expected in read page.");
        }

        [Test, Order(4)]
        public void Test_EditLastCreatedIdeaTitle_ShouldSucceed()
        {
            myIdeasPage.OpenPage();
            myIdeasPage.EditButtonLastIdea.Click();

            string updatedTitle = "Changed Title: " + lastCreatedIdeaTitle;
            editIdeaPage.ChangeTitleTo(updatedTitle);

            Assert.That(myIdeasPage.IsUrlCorrect(myIdeasPage.PageUrl), Is.True, "URL is not correct");

            myIdeasPage.ViewButtonLastIdea.Click();

            Assert.That(readIdeaPage.IsIdeaTitleCorrect(updatedTitle), Is.True, "The title was not updated as expected.");
        }

        [Test, Order(5)]
        public void Test_EditLastCreatedIdeaDescription_ShouldSucceed()
        {
            myIdeasPage.OpenPage();
            myIdeasPage.EditButtonLastIdea.Click();

            updatedDescription = "Changed Description: " + lastCreatedIdeaDescription;
            editIdeaPage.ChangeDescriptionTo(updatedDescription);

            Assert.That(myIdeasPage.IsUrlCorrect(myIdeasPage.PageUrl), Is.True, "URL is not correct");

            myIdeasPage.ViewButtonLastIdea.Click();

            Assert.That(readIdeaPage.IsIdeaDescriptionCorrect(updatedDescription), Is.True, "The description was not updated as expected.");
        }

        [Test, Order(6)]
        public void Test_DeleteLastCreatedIdea_ShouldSucceed()
        {
            myIdeasPage.OpenPage();
            myIdeasPage.DeleteButtonLastIdea.Click();

            Assert.That(myIdeasPage.IsIdeaDeleted(updatedDescription), Is.True, "The idea was not deleted as expected.");
        }
    }
}
