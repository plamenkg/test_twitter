using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow;
using TwitterTests.Clients;
using TwitterTests.Models;
using TwitterTests.Models.Responses;

namespace TwitterTests.Steps
{
    [Binding]
    public sealed class CreteTweetSteps
    {
        private readonly DeleteTweetContext context;

        public CreteTweetSteps(DeleteTweetContext injectedContext)
        {
            context = injectedContext;
        }

        [Given("I have initialized my OAuth parameters")]
        public void GivenIHaveInitializedAuthCredentials(Table table)
        {
            this.context.authParameters = table.CreateInstance<OAuthParameters>();
        }

        [Given("I have initialized my tweet client with (.*)")]
        public void GivenIHaveInitializedTwitterClient(string apiEndpoint)
        {
            this.context.twitterClient = new TweetClient(apiEndpoint, this.context.authParameters);
        }

        [Given("I created a tweet with text (.*)")]
        public void GivenIHaveCreatedTweet(string text)
        {
           this.context.previousTweet = this.context.twitterClient.PostTweet(text);
        }
        [Given("I replied to the tweet with comment (.*)")]
        public void GivenIHaveCommentedMyTweet(string comment)
        {
            TweetResponse commentResponse = this.context.twitterClient.PostComment(this.context.previousTweet.Id_str, comment);
        }
    }
}
