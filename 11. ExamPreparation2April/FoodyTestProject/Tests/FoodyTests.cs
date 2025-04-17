namespace FoodyTestProject.Tests
{
    public class FoodyTests : BaseTest
    {
        [Test, Order(1)]
        public void Test_AddFoodWithInvalidData_ShouldThrowErrorMessages()
        {
            Assert.That(addFoodPage.IsUrlCorrect("http://softuni-qa-loadbalancer-2137572849.eu-north-1.elb.amazonaws.com:85/"), Is.True, "URL is not correct");

            addFoodPage.OpenPage();
            addFoodPage.AddFood("", "", "");

            Assert.That(driver.Url, Is.EqualTo(addFoodPage.PageUrl));

            Assert.Multiple(() =>
            {
                Assert.That(addFoodPage.IsMainErrorMessageCorrect(), Is.True, "The main error message is not as expected.");
                Assert.That(addFoodPage.IsNameErrorMessageCorrect(), Is.True, "The name error message is not as expected.");
                Assert.That(addFoodPage.IsDescriptionErrorMessageCorrect(), Is.True, "The description error message is not as expected.");
            });
        }
    }
}
