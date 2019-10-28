using OpenQA.Selenium;

namespace TwitterTests.PageFragments
{
    public class TweetFragment
    {
        #region Private Fileds
        public string articleQuery = string.Empty;
        public string text = string.Empty;
        private IWebDriver driver = null;
        private IWebElement tweetElement = null;
        #endregion

        #region UI Elements
        private IWebElement showThreadBtn => tweetElement.FindElement(By.XPath(@".//span[text()=""Show this thread""]"));

        private IWebElement menuBtn => tweetElement.FindElement(By.XPath(@".//div[@aria-label=""More"" and @role=""button""]"));

        private IWebElement delMenuItem => tweetElement.FindElement(By.XPath(@"//div[@role=""menuitem""]//span[text()=""Delete""]"));

        private IWebElement delBtn => tweetElement.FindElement(By.XPath(@"//div[@role=""button""]//span[text()=""Delete""]"));
        #endregion   

        public TweetFragment(IWebDriver driver, string tweetString)
        {
            this.driver = driver;
            this.text = tweetString;
            this.articleQuery = $@"//article[.//span[text()=""{tweetString}""]]";
            this.tweetElement = driver.FindElement(By.XPath(articleQuery));
        }

        public void OpenComments()
        {
            showThreadBtn.Click();
        }

        public void Delete()
        {
            menuBtn.Click();
            delMenuItem.Click();
            delBtn.Click();            
        }
    }
}
