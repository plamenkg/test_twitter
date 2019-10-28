using OpenQA.Selenium;

namespace TwitterTests.PageObjects
{
    class LoginPage
    {
        private IWebDriver driver = null;

        private IWebElement nameInput => driver.FindElement(By.XPath(@"//input[@type=""text""]"));

        private IWebElement passInput => driver.FindElement(By.XPath(@"//input[@type=""password""]"));

        private IWebElement loginBtn => driver.FindElement(By.XPath(@"//input[@type=""submit"" and @value=""Log in""]"));

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void LogInto(string username, string password)
        {
            nameInput.SendKeys(username);
            passInput.SendKeys(password);
            loginBtn.Click();
        }
    }
}
