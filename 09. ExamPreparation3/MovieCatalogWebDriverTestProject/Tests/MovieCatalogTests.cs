namespace MovieCatalogWebDriverTestProject.Tests
{
    public class MovieCatalogTests : BaseTest
    {
        string? lastCreatedMovieTitle;
        string? lastCreatedMovieDescription;
        string? updatedTitle;

        [Test, Order(1)]
        public void Test_AddMovieWithoutTitle_ShouldThrowErrorMessage()
        {
            addMoviePage.OpenPage();

            addMoviePage.AddMovie("", "Description", "http://www.pictures.com/picture.jpg", "");

            Assert.IsTrue(addMoviePage.IsToastMessageCorrect("The Title field is required."), "The error message is not as expected.");
        }

        [Test, Order(2)]
        public void Test_AddMovieWithoutDescription_ShouldThrowErrorMessage()
        {
            addMoviePage.OpenPage();

            string randomTitle = "TITLE: " + GenerateRandomString(5);

            addMoviePage.AddMovie(randomTitle, "", "http://www.pictures.com/picture.jpg", "");

            Assert.IsTrue(addMoviePage.IsToastMessageCorrect("The Description field is required."), "The error message is not as expected.");
        }

        [Test, Order(3)]
        public void Test_AddMovieWithValidData_ShouldAddMovie()
        {
            lastCreatedMovieTitle = "TITLE: " + GenerateRandomString(5);
            lastCreatedMovieDescription = "Description: " + GenerateRandomString(10);

            addMoviePage.OpenPage();

            addMoviePage.AddMovie(lastCreatedMovieTitle, lastCreatedMovieDescription, "http://www.pictures.com/picture.jpg", "");

            allMoviesPage.OpenPage();
            allMoviesPage.NavigateToLastPage();

            Assert.True(allMoviesPage.IsMoveTitleCorrect(lastCreatedMovieTitle), "The title of the last created movie is not as expected.");
        }

        [Test, Order(4)]
        public void Test_EditLastMovieTitle_ShouldSucceed()
        {
            allMoviesPage.OpenPage();
            allMoviesPage.NavigateToLastPage();

            updatedTitle = "UPDATED " + lastCreatedMovieTitle;

            allMoviesPage.LastMovieEditButton.Click();

            editMoviePage.EditTitle(updatedTitle);

            Assert.That(editMoviePage.IsToastSuccessMessageCorrect("The Movie is edited successfully!"), Is.True, "The error message is not as expected.");

            allMoviesPage.NavigateToLastPage();

            Assert.True(allMoviesPage.IsMoveTitleCorrect(updatedTitle), "The title of the edited movie is not as expected.");
        }

        [Test, Order(5)]
        public void Test_MarkLastAddedMovieAsWatched()
        {
            allMoviesPage.OpenPage();
            allMoviesPage.NavigateToLastPage();

            allMoviesPage.LastMovieMarkButton.Click();

            watchedMoviesPage.OpenPage();
            watchedMoviesPage.NavigateToLastPage();

            Assert.That(watchedMoviesPage.IsMoveTitleCorrect(updatedTitle), Is.True, "The title of the watched movie is not as expected.");
        }

        [Test, Order(6)]
        public void Test_DeleteLastAddedMovie()
        {
            allMoviesPage.OpenPage();
            allMoviesPage.NavigateToLastPage();

            allMoviesPage.DeleteLastMovie();

            Assert.That(allMoviesPage.IsToastMessageDeletedMovieCorrect("The Movie is deleted successfully!"), Is.True, "The error message is not as expected.");
        }
    }
}
