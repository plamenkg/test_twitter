using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterTests.Models
{
    public struct OAuthParameters
    {

        public string ApiKey;
        public string ApiSecretKey;
        public string Token;
        public string TokenSecret;

        public OAuthParameters(string apiKey, string apiSecretKey, string token, string tokenSecret)
        {
            this.ApiKey = apiKey;
            this.ApiSecretKey = apiSecretKey;
            this.Token = token;
            this.TokenSecret = tokenSecret;
        }
    }
}
