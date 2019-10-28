using RestSharp;
using RestSharp.Authenticators;
using TwitterTests.Models;
using TwitterTests.Models.Requests;
using TwitterTests.Models.Responses;
using TwitterTests.Utils;

namespace TwitterTests.Clients
{
    public class TweetClient
    {
        private readonly string ApiUri = "/1.1/statuses/update.json"; 
        
        private string ApiEndpoint { get; set; }
        private RestClient apiClient { get; set; }

        public TweetClient(string apiEndpoint, OAuthParameters authParams)
        {            
            this.ApiEndpoint = apiEndpoint;
            this.apiClient = new RestClient(apiEndpoint)
            {
                Authenticator = OAuth1Authenticator.ForProtectedResource(
                                    authParams.ApiKey, 
                                    authParams.ApiSecretKey, 
                                    authParams.Token, 
                                    authParams.TokenSecret)
            };
        }

        public TweetResponse PostTweet(string tweetText)
        {
            var tweetRequest = new TweetRequest(tweetText);
            var request = RestRequestExtension.CreateRequest(ApiUri, Method.POST, tweetRequest);
            var result = apiClient.ExecuteAsyncRequest<TweetResponse>(request).GetAwaiter().GetResult();

            return Deserializer.Deserialize<TweetResponse>(result);
        }

        public TweetResponse PostComment(string tweetId, string comment)
        {
            var tweetRequest = new TweetRequest(comment, tweetId);
            var request = RestRequestExtension.CreateRequest(ApiUri, Method.POST, tweetRequest);
            var result = apiClient.ExecuteAsyncRequest<TweetResponse>(request).GetAwaiter().GetResult();

            return Deserializer.Deserialize<TweetResponse>(result);
        }
    }
}
