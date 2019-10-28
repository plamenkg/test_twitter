using OpenQA.Selenium;
using TwitterTests.Clients;
using TwitterTests.Models.Responses;
using TwitterTests.PageFragments;

namespace TwitterTests.Models
{
    public class DeleteTweetContext
    {        
        public IWebDriver driver { get; set; }        
        public TweetFragment commentTweet { get; set; }        
        public TweetFragment originalTweet { get; set; }        
        public TweetClient twitterClient { get; set; }        
        public OAuthParameters authParameters { get; set; }        
        public TweetResponse previousTweet { get; set; }        
    }
}