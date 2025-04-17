namespace FoodyTestProject.Pages
{
    public class AddFoodPage : BasePage
    {
        public AddFoodPage(IWebDriver driver) : base(driver) { }

        public readonly string PageUrl = BaseUrl + "/Food/Add";

        // Locating Add Food Page Elements

        protected readonly By foodNameInput = By.XPath("//input[@id='name']");

        protected readonly By describeFoodInput = By.XPath("//input[@id='description']");

        protected readonly By pictureUrlInput = By.XPath("//input[@id='url']");

        protected readonly By addFoodButton = By.XPath("//button[@class='btn btn-primary btn-block fa-lg gradient-custom-2 mb-3']");

        protected readonly By mainErrorMessage = By.XPath("//div[@class='text-danger validation-summary-errors']/ul/li");

        protected readonly By nameErrorMessage = By.XPath("//span[@data-valmsg-for='Name']");

        protected readonly By descriptionErrorMessage = By.XPath("//span[@data-valmsg-for='Description']");

        // Methods

        public void OpenPage()
        {
            driver.Navigate().GoToUrl(PageUrl);
        }

        public void AddFood(string foodName, string foodDescription, string foodPictureUrl)
        {
            Type(foodNameInput, foodName);
            Type(describeFoodInput, foodDescription);
            Type(pictureUrlInput, foodPictureUrl);
            Click(addFoodButton);
        }

        public bool IsMainErrorMessageCorrect()
        {
            return GetText(mainErrorMessage) == "Unable to add this food revue!";
        }

        public bool IsNameErrorMessageCorrect()
        {
            return GetText(nameErrorMessage) == "The Name field is required.";
        }

        public bool IsDescriptionErrorMessageCorrect()
        {
            return GetText(descriptionErrorMessage) == "The Description field is required.";
        }

        public bool IsUrlCorrect(string expectedUrl)
        {
            return WaitUrlToBe(expectedUrl);
        }
    }
}
