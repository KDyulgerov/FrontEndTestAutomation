﻿using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;

namespace UITestingPlaygroundTestProject.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;

        protected WebDriverWait wait;

        protected Actions actions;

        public static readonly string BaseUrl = "http://www.uitestingplayground.com";

        // Locators
        protected readonly By loadDelayButton = By.LinkText("Load Delay");
        public IWebElement LoadDelayButton => FindElement(loadDelayButton);

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            actions = new Actions(driver);
        }

        // Methods
        public void OpenBasePage()
        {
            driver.Navigate().GoToUrl(BaseUrl);
        }
        public IWebElement FindElement(By by)
        {
            return wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        public IReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return wait.Until(ExpectedConditions.PresenceOfAllElementsLocatedBy(by));
        }

        public void Type(By by, string text)
        {
            var element = FindElement(by);
            element.Clear();
            element.SendKeys(text);
        }

        public void Click(By by)
        {
            FindElement(by).Click();
        }

        public string GetText(By by)
        {
            return FindElement(by).Text.Trim();
        }

        public bool IsPageHeadingTextCorrect(By by, string pageHeading)
        {
            return GetText(by).Equals(pageHeading);
        }

        public IWebElement FindElementWithCustomTimeout(By by, int timeoutInSeconds)
        {
            var customWait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return customWait.Until(ExpectedConditions.ElementIsVisible(by));
        }
    }
}