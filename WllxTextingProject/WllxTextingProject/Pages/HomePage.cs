namespace WllxTextingProject.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageUrl => "https://wallex.global/";

        protected readonly By homePageBankingHeading = By.XPath("//h1[@class='display-1 text-center']");

        protected readonly By homePageBankingDescription = By.XPath("//div[@class='row mt-lg-5 my-2']//p[@class='text-center']");

        protected readonly By homePageWallexLogoSignUpButton = By.XPath("//div[@class='row d-flex flex-row align-items-center justify-content-center box-grad-buttons dark-buttons']//a[@class='btn btn-outline-light square-btn me-3']");

        protected readonly By homePageGooglePlayButton = By.XPath("//div[@class='row d-flex flex-row align-items-center justify-content-center box-grad-buttons dark-buttons']//a[@class='btn btn-outline-light square-btn'][@data-bs-target]");

        protected readonly By homePageAppStoreButton = By.XPath("//div[@class='row d-flex flex-row align-items-center justify-content-center box-grad-buttons dark-buttons']//a[@class='btn btn-outline-light square-btn mx-3']");

        protected readonly By homePageArrowExploreButton = By.XPath("//a[@href='/explore'][@class='btn btn-outline-light square-btn']");

        // Locating Phone Slider Element and Phones & Tablets
        protected readonly By homePagePhoneSliderElement = By.XPath("//div[@class='slider']");

        protected readonly By sliderNeobankingPhone = By.XPath("//div[@class='slider']//a[@href='/neobanking']");

        protected readonly By sliderCustodyProPhone = By.XPath("//div[@class='slider']//a[@href='/custody-pro']");

        protected readonly By sliderSmartCustodyPhone = By.XPath("//div[@class='slider']//a[@href='/smart-custody']");

        protected readonly By sliderSelfManagedCustodyPhone = By.XPath("//div[@class='slider']//a[@href='/self-managed-custody']");

        protected readonly By sliderWallexPayTablet = By.XPath("//div[@class='slider']//a[@href='/wallex-pay']");

        protected readonly By sliderNftTablet = By.XPath("//div[@class='slider']//a[@href='https://nft.wallex.global/']");

        // Locating Home Page Elements & Cards
        protected readonly By homePageHeadingElevate = By.XPath("//h2[@class='display-1' and contains(., 'ELEVATE')]");

        protected readonly By homePageDescriptionElevate = By.XPath("//div[@class='col pt-5']//p");

        // Locating Cards Card & Details
        protected readonly By homePageCardsCard = By.XPath("//div[@class='card-body d-flex flex-column justify-content-between p-xxl-5 p-4 py-4' and contains(., 'CARDS')]");

        protected readonly By homePageCardsCardArrowButton = By.XPath("//div[@class='text-end pb-lg-0']//a[@href='/card']");

        // Creating BuyCryptoPage class

        // Creating MarketsPage class

        // Creating ProductNeobankingPage class

        // Creating ProductCustodyProPage class

        // Creating ProductSmartCustodyPage class

        // Creating ProductSelfManagedCustodyPage class

        // Creating ProductWallexPayPage class

        // Creating TO DO MORE! class


        // Methods TO DO! ---------------------

        public bool IsElevateHeadingAndDescriptionTextCorrect()
        {
            return GetText(homePageHeadingElevate).Trim() == "ELEVATE YOUR FINANCES." &&
            GetText(homePageDescriptionElevate).Trim() == "Our incredibly intuitive features guide you through your daily needs and in planning your future.";
        }

        public bool IsCardsCardHeadingAndDescriptionTextCorrect()
        {
            string cardText = GetText(homePageCardsCard);

            return cardText.Contains("CARDS.") &&
            cardText.Contains("Spend your crypto easily.");
        }
    }
}
