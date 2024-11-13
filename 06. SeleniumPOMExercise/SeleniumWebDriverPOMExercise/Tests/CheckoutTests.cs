﻿namespace SeleniumWebDriverPOMExercise.Tests
{
    public class CheckoutTests : BaseTest
    {
        [SetUp]
        public void CheckoutTestsSetUp()
        {
            Login("standard_user", "secret_sauce");

            inventoryPage.AddToCartByIndex(1);

            inventoryPage.ClickCartLink();

            cartPage.ClickCheckout();
        }

        [Test]
        public void TestCheckoutPageLoaded()
        {
            Assert.IsTrue(driver.Url.Contains("checkout-step-one.html"), "The checkout page is not loaded as expected.");
        }

        public void TestContinueToNextStep()
        {
            checkoutPage.EnterFirstName("TestFirstName");
            checkoutPage.EnterLastName("TestLastName");
            checkoutPage.EnterPostalCode("1234");

            checkoutPage.ClickContinueButton();

            Assert.IsTrue(driver.Url.Contains("checkout-step-two.html"), "The second checkout page is not loaded after pressing the 'continue' button.");
        }

        public void TestCompleteOrder()
        {
            checkoutPage.EnterFirstName("TestFirstName");
            checkoutPage.EnterLastName("TestLastName");
            checkoutPage.EnterPostalCode("1234");

            checkoutPage.ClickContinueButton();

            checkoutPage.ClickFinishButton();

            Assert.IsTrue(driver.Url.Contains("checkout-complete.html"), "The complete page is not loaded after pressing the 'finish' button.");

            Assert.IsTrue(checkoutPage.IsPageComplete(), "The order is not completed and the finish page is not loaded.");
        }
    }
}
