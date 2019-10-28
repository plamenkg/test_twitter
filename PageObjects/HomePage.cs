using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterTests.PageObjects
{
    public class HomePage
    {
        private IWebDriver driver = null;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public bool FindTweet(string tweetQuery)
        {
            var foundTweets = this.driver.FindElements(By.XPath(tweetQuery));

            if(foundTweets.Count == 0)
            {
                return false;
            }

            return true;
        }
    }
}
