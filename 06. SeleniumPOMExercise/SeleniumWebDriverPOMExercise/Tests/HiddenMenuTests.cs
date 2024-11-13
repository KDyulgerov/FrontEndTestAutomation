﻿namespace SeleniumWebDriverPOMExercise.Tests
{
    public class HiddenMenuTests : BaseTest
    {
        [SetUp]
        public void HiddenMenuTestsSetUp()
        {
            Login("standard_user", "secret_sauce");
        }

        [Test]
        public void TestOpenMenu()
        {
            hiddenMenuPage.ClickMenuButton();

            Assert.IsTrue(hiddenMenuPage.IsMenuOpen(), "The hidden menu is not open as expected.");
        }

        [Test]
        public void TestLogout()
        {
            hiddenMenuPage.ClickMenuButton();

            hiddenMenuPage.ClickLogoutButton();

            Assert.IsTrue(driver.Url.Equals("https://www.saucedemo.com/"));
        }
    }
}
