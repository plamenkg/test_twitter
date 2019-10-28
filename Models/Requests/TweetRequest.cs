namespace TwitterTests.Models.Requests
{
    public class TweetRequest
    {        
        public string status { get; set; }
        public string in_reply_to_status_id { get; set; }

        public TweetRequest(string tweetText)
        {
            this.status = tweetText;
        }

        public TweetRequest(string tweetText, string originTweetId)
        {
            this.status = tweetText;
            this.in_reply_to_status_id = originTweetId;
        }
    }
}