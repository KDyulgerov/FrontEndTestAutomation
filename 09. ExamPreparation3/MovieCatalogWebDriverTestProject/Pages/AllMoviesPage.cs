namespace MovieCatalogWebDriverTestProject.Pages
{
    public class AllMoviesPage : BasePage
    {
        public readonly string PageUrl = BaseUrl + "/Catalog/All#all";

        // Locators
        protected readonly By pagesIndex = By.XPath("//a[@class='page-link']");

        protected readonly By allMovies = By.XPath("//div[@class='col-lg-4']");

        public ReadOnlyCollection<IWebElement> AllMovies => FindElements(allMovies);

        public IWebElement LastMovieTitle => AllMovies.Last().FindElement(By.XPath(".//h2"));
        public IWebElement LastMovieEditButton => AllMovies.Last().FindElement(By.XPath(".//a[@class='btn btn-outline-success']"));
        public IWebElement LastMovieDeleteButton => AllMovies.Last().FindElement(By.XPath(".//a[@class='btn btn-danger']"));
        public IWebElement LastMovieMarkButton => AllMovies.Last().FindElement(By.XPath(".//a[@class='btn btn-info']"));

        protected readonly By confirmDeleteMovieButton = By.XPath("//button[@type='submit' and contains(text(), 'Yes')]");

        protected readonly By toastMeesageDeletedMovie = By.XPath("//div[@class='toast-message']");
        public AllMoviesPage(IWebDriver driver) : base(driver)
        {
        }

        // Methods
        public void OpenPage()
        {
            driver.Navigate().GoToUrl(PageUrl);
        }

        public void NavigateToLastPage()
        {
            var pages = FindElements(pagesIndex);
            pages.Last().Click();
        }

        public bool IsMoveTitleCorrect(string title)
        {
            return LastMovieTitle.Text.Trim() == title.Trim();
        }

        public void DeleteLastMovie()
        {
            LastMovieDeleteButton.Click();
            FindElement(confirmDeleteMovieButton).Click();
        }

        public bool IsToastMessageDeletedMovieCorrect(string expectedMessage)
        {
            return GetText(toastMeesageDeletedMovie) == expectedMessage;
        }
    }
}
