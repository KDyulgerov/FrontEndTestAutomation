namespace SeleniumWebDriverPOMExercise.Tests
{
    public class InventoryTests : BaseTest
    {
        [Test, Order(1)]
        public void TestInventoryDisplay()
        {
            Login("standard_user", "secret_sauce");

            Assert.IsTrue(inventoryPage.IsInventoryDisplayed(), "The items are not displayed as expected.");

            Assert.IsTrue(inventoryPage.IsPageLoaded(), "The inventory page is not loaded as expected.");
        }

        [Test, Order(2)]
        public void TestAddToCartByIndex()
        {
            Login("standard_user", "secret_sauce");

            inventoryPage.AddToCartByIndex(1);

            inventoryPage.ClickCartLink();

            Assert.That(driver.PageSource.Contains("Sauce Labs Backpack"), "The page does not contains the title of the added item");

            Assert.IsTrue(cartPage.IsCartItemDisplayed(), "The cart items section is empty after adding item by index");
        }

        [Test, Order(3)]
        public void TestAddToCartByName()
        {
            Login("standard_user", "secret_sauce");

            inventoryPage.AddToCartByName("Sauce Labs Bike Light");

            inventoryPage.ClickCartLink();

            Assert.That(driver.PageSource.Contains("Sauce Labs Bike Light"), "The page does not contains the title of the added item.");

            Assert.IsTrue(cartPage.IsCartItemDisplayed(), "The cart items section is empty after adding item by name.");
        }

        [Test, Order(4)]
        public void TestInventoryPageTitle()
        {
            Login("standard_user", "secret_sauce");

            Assert.That(inventoryPage.IsPageLoaded(), Is.True, "Inventory page is not loaded as expected.");
        }
    }
}
