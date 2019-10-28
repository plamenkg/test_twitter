using TwitterTests.Clients;
using TwitterTests.Models.Responses;

namespace TwitterTests.Models
{
    public class DeleteTweetContext
    {              
        public TweetClient twitterClient { get; set; }        
        public OAuthParameters authParameters { get; set; }        
        public TweetResponse previousTweet { get; set; }        
    }
}