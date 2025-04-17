namespace FoodyTestProject.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver) { }

        // Locating Home Page Elements

        public readonly By homeLinkLoggedUser = By.XPath("//a[@class='navbar-brand']");

        public readonly By myProfileLink = By.XPath("//a[@class='nav-link mx-3']");

        public readonly By addFoodButton = By.XPath("//a[@class='nav-link' and contains(text(), 'Add Food')]");

        public readonly By logoutButton = By.XPath("//a[@class='nav-link' and contains(text(), 'Logout')]");

        public readonly By searchInput = By.XPath("//input[@type='search']");

        public readonly By searchButton = By.XPath("//button[@class='btn btn-primary rounded-pill mt-5 col-2']");

        public readonly By foodCards = By.XPath("row gx-5 align-items-center");

        public readonly By welcomeMessage = By.XPath("//h2[@class='masthead-subheading mb-0']");

        public ReadOnlyCollection<IWebElement> FoodCards => (ReadOnlyCollection<IWebElement>)FindElements(foodCards);
        public IWebElement TitleLastFood => FoodCards.Last().FindElement(By.XPath(".//h2[@class='display-4']"));
        public IWebElement DescriptionLastFood => FoodCards.Last().FindElement(By.XPath(".//p[@class='flex-lg-wrap']"));
        public IWebElement EditButtonLastFood => FoodCards.Last().FindElement(By.XPath(".//a[@class='btn btn-primary btn-xl rounded-pill mt-5' and contains(text(), 'Edit')]"));
        public IWebElement DeleteButtonLastFood => FoodCards.Last().FindElement(By.XPath(".//a[@class='btn btn-primary btn-xl rounded-pill mt-5' and contains(text(), 'Delete')]"));
        
        // Methods

    }
}
