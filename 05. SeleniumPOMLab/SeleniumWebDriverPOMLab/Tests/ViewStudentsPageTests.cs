using SeleniumWebDriverPOMLab.Pages;

namespace SeleniumWebDriverPOMLab.Tests
{
    public class ViewStudentsPageTests : BaseTest
    {
        [Test, Order(1)]
        public void Test_ViewStudentsPage_VerifyingContent()
        {
            var page = new ViewStudentsPage(driver);
            page.OpenPage();

            var currentPageTitle = page.GetPageTitle();
            var currentPageHeadingText = page.GetPageHeadingText();
            var currentStudentsList = page.GetStudentsList();

            Assert.That(currentPageTitle, Is.EqualTo("Students"), $"The title was expected to be 'Students' but was {currentPageTitle}");

            Assert.That(currentPageHeadingText, Is.EqualTo("Registered Students"), $"The heading was expected to be 'Registered Students' but was {currentPageHeadingText}");

            Assert.IsTrue(currentStudentsList.Contains("Stavri Stavriev (stavri@example.com)"));

            // Verifying that each student record contains '(' and finishes with ')'
            foreach (var st in currentStudentsList)
            {
                Assert.IsTrue(st.IndexOf("(") > 0);
                Assert.IsTrue(st.LastIndexOf(")") == st.Length - 1);
            }
        }

        [Test, Order(2)]
        public void Test_ViewStudentsPage_VerifyingLinks()
        {
            var page = new ViewStudentsPage(driver);
            page.OpenPage();
            Assert.IsTrue(page.LinkHomePage.Displayed);
            Assert.IsTrue(page.LinkViewStudentsPage.Displayed);
            Assert.IsTrue(page.LinkAddStudentsPage.Displayed);
        }
    }
}
