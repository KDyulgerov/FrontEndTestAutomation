namespace MovieCatalogWebDriverTestProject.Pages
{
    public class WatchedMoviesPage : BasePage
    {
        public readonly string PageUrl = BaseUrl + "/Catalog/Watched#watched";

        // Locators
        protected readonly By pagesIndex = By.XPath("//a[@class='page-link']");

        protected readonly By allWatchedMovies = By.XPath("//div[@class='col-lg-4']");

        public ReadOnlyCollection<IWebElement> AllMovies => FindElements(allWatchedMovies);

        public IWebElement LastWatchedMovieTitle => AllMovies.Last().FindElement(By.XPath(".//h2"));
        public IWebElement LastWatchedMovieEditButton => AllMovies.Last().FindElement(By.XPath(".//a[@class='btn btn-outline-success']"));
        public IWebElement LastWatchedMovieDeleteButton => AllMovies.Last().FindElement(By.XPath(".//a[@class='btn btn-danger']"));
        public IWebElement LastWatchedMovieMarkButton => AllMovies.Last().FindElement(By.XPath(".//a[@class='btn btn-info']"));

        public WatchedMoviesPage(IWebDriver driver) : base(driver)
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
            return LastWatchedMovieTitle.Text.Trim() == title.Trim();
        }
    }
}
