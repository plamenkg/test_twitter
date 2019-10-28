using OpenQA.Selenium;
using System;
using TwitterTests.PageObjects;

namespace TwitterTests.PageFragments
{
    public class SideMenuFragment
    {
        private IWebDriver driver = null;
        private IWebElement menuElement = null;

        private IWebElement homeBtn => menuElement.FindElement(By.XPath(@".//span[text()=""Home""]"));

        public SideMenuFragment(IWebDriver driver)
        {
            this.driver = driver;
            this.menuElement = driver.FindElement(By.XPath(@"//nav[@aria-label=""Primary""]"));
        }

        public HomePage NavigateToHome()
        {
            homeBtn.Click();

            return new HomePage(driver);
        }

    }
}
