namespace SeleniumWebDriverPOMLab.Pages
{
    public class ViewStudentsPage : BasePage
    {
        public ViewStudentsPage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageUrl => "http://softuni-qa-loadbalancer-2137572849.eu-north-1.elb.amazonaws.com:82/students";

        public ReadOnlyCollection<IWebElement> ListItemStudents => driver.FindElements(By.XPath("//body//ul//li"));

        public string[] GetStudentsList()
        {
            var elementsStudents = this.ListItemStudents.Select(s => s.Text).ToArray();
            return elementsStudents;
        }
    }
}
