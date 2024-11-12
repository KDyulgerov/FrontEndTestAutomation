namespace SeleniumWebDriverPOMExercise.Tests
{
    public class CartTests : BaseTest
    {
        [Test, Order(1)]
        public void TestCartItemDisplayed()
        {
            Login("standard_user", "secret_sauce");

            inventoryPage.AddToCartByName("Sauce Labs Bike Light");

            inventoryPage.ClickCartLink();

            Assert.IsTrue(cartPage.IsCartItemDisplayed(), "The added item is not displayed in the cart as expected.");
        }

        [Test, Order(2)]
        public void TestClickCheckout()
        {
            Login("standard_user", "secret_sauce");

            inventoryPage.AddToCartByName("Sauce Labs Bike Light");

            inventoryPage.ClickCartLink();

            cartPage.ClickCheckout();

            Assert.IsTrue(checkoutPage.IsPageLoaded(), "The checkout page is not loaded as expected.");
        }
    }
}
