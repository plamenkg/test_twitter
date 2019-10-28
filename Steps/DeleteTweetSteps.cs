using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TwitterTests.PageFragments;
using TwitterTests.PageObjects;
using TwitterTests.Models;

namespace TwitterTests.Steps
{
    [Binding]
    public sealed class DeleteTweetSteps
    {
        private readonly DeleteTweetContext context;        

        public DeleteTweetSteps(DeleteTweetContext injectedContext)
        {
            context = injectedContext;
        }
        
        [BeforeScenario("DeleteComment")]
        public void InitializeDriver()
        {                     
            this.context.driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
            this.context.driver.Manage().Window.Maximize();
            this.context.driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(10);
        }

        [Given("I have logged into (.*) with username (.*) and password (.*)")]
        public void GivenIHaveLoggedIntoTwitter(string twitterUrl, string userName, string password)
        {   
            this.context.driver.Navigate().GoToUrl(twitterUrl);

            var loginPage = new LoginPage(this.context.driver);
            loginPage.LogInto(userName, password);
        }

        [Given("I have navigated to (.*) tweet comments")]
        public void GivenIHaveNavigatedToTweetComments(string tweetText)
        {
            this.context.originalTweet = new TweetFragment(this.context.driver, tweetText);
            this.context.originalTweet.OpenComments();
        }

        [When("I delete the comment (.*)")]
        public void WhenIDeleteTheComment(string comment)
        {
            this.context.commentTweet = new TweetFragment(this.context.driver, comment);
            this.context.commentTweet.Delete();
        }

        [Then("it should not be present on the Home page")]
        public void ThenItShouldNotBePresent()
        {
            var menuFragment = new SideMenuFragment(this.context.driver);
            HomePage homePage = menuFragment.NavigateToHome();

            var tweetFound = homePage.FindTweet(this.context.commentTweet.articleQuery);
            Assert.AreEqual(false, tweetFound, "Deleted comment does not exist");
        }      

        [AfterScenario("DeleteComment")]
        public void CleanUpTweet()
        {
            var tweet = new TweetFragment(this.context.driver, this.context.originalTweet.text);
            tweet.Delete(); 
              
            Thread.Sleep(500);
            this.context.driver.Quit();        
        }  
    }
}