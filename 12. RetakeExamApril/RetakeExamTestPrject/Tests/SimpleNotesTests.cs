namespace RetakeExamTestPrject.Tests
{
    public class SimpleNotesTests : BaseTest
    {
        private static string? lastCreatedNoteTitle;
        private static string? lastCreatedNoteDescription;
        private static string? updatedTitle;

        [Test, Order(1)]
        public void Test_AddNoteWithInvalidData_ShouldThrowErrorMessages()
        {
            newNotePage.OpenPage();
            newNotePage.NavigateToCreateNotePage();
            createNotePage.createNote("", "", "New");

            Assert.That(driver.Url, Is.EqualTo(createNotePage.PageUrl), "The page was redirected incorrectly.");

            Assert.That(createNotePage.IsToastErrorMessageDisplayed(), Is.True, "The error toast message is not displayed as expected.");

            Assert.That(createNotePage.IsToastMessageTextCorrect("The Title field is required. The Description field is required."), Is.True, "The error text message is not as expected.");
        }

        [Test, Order(2)]
        public void Test_AddNoteWithValidData_ShouldSucceed()
        {
            lastCreatedNoteTitle = "Note " + GenerateRandomString(10);
            lastCreatedNoteDescription = "Description " + GenerateRandomString(32);

            newNotePage.OpenPage();
            newNotePage.NavigateToCreateNotePage();
            createNotePage.createNote(lastCreatedNoteTitle, lastCreatedNoteDescription, "New");

            Assert.That(createNotePage.IsToastMessageTextCorrect("Note created successfully!"), Is.True, "The error text message is not as expected.");
        }

        [Test, Order(3)]
        public void Test_EditLastCreatedNoteTitle_ShouldSucceed()
        {
            updatedTitle = "Changed: " + lastCreatedNoteTitle;

            newNotePage.OpenPage();
            newNotePage.LastCreatedNoteEditButton.Click();
            editNotePage.ChangeTitleTo(updatedTitle);

            newNotePage.OpenPage();
            Assert.That(newNotePage.LastCreatedNoteTitle.Text.Trim(), Is.EqualTo(updatedTitle), "The title was not edited as expected.");
        }

        [Test, Order(4)]
        public void Test_MoveEditedNoteToDone_ShouldSucceed()
        {
            newNotePage.OpenPage();
            newNotePage.LastCreatedNoteSetDoneButton.Click();

            Assert.That(createNotePage.IsToastMessageTextCorrect("Note status changed successfully!"), Is.True, "The error text message is not as expected.");

            doneNotesPage.OpenPage();

            Assert.That(doneNotesPage.LastCreatedNoteTitle.Text.Trim(), Is.EqualTo(updatedTitle), "The last created note is not presented in the done list.");
        }

        [Test, Order(5)]
        public void Test_DeleteEditedNote_ShouldSucceed()
        {
            doneNotesPage.OpenPage();
            doneNotesPage.LastCreatedNoteDeleteButton.Click();

            Assert.That(deleteNotePage.IsDeleteNotePageHeadingCorrect("Are you sure you want to delte this note?"), Is.True, "The delete page heading is not correct.");

            deleteNotePage.ConfirmNoteDeletion();

            Assert.That(doneNotesPage.IsToastMessageTextCorrect("Note deleted successfully!"), Is.True, "The error text message is not as expected.");
        }

        [Test, Order(6)]
        public void Test_VerifyLogoutProcess_ShouldSucceed()
        {
            homePage.OpenPage();
            homePage.Logout();

            Assert.That(driver.Url, Is.EqualTo("https://d5wfqm7y6yb3q.cloudfront.net/"), "The user is not redirected to the landing page.");
            
            //Assert.That(basePage.IsPageHeadingTextCorrect("Simple Notes"), Is.True, "The user is not redirected to the landing page.");

            newNotePage.OpenPage();

            Assert.That(basePage.IsAccessDeniedElementDisplayed(), Is.True, "Access denied message is not showed to the user as expected.");
        }
    }
}
