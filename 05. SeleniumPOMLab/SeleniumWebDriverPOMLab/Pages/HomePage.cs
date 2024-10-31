namespace SeleniumWebDriverPOMLab.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageUrl => "http://softuni-qa-loadbalancer-2137572849.eu-north-1.elb.amazonaws.com:82";

        public IWebElement ElementStudentsCount => driver.FindElement(By.XPath("//p//b"));

        public string GetStudentsCount()
        {
            return ElementStudentsCount.Text;
        }
    }
}
