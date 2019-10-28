using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterTests.Utils
{
    public static class Deserializer
    {
        public static T Deserialize<T>(IRestResponse<T> restResponse)
        {
            var deserial = new JsonDeserializer();

            return deserial.Deserialize<T>(restResponse);
        }
    }
}
