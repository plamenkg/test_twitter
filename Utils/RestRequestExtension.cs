using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterTests.Utils
{
    static class RestRequestExtension
    {
        public static RestRequest CreateRequest(string apiUri, Method method, object obj)
        {
            var request = new RestRequest(apiUri, method)
            {
                RequestFormat = DataFormat.Json
            };
            request.AddObject(obj);

            return request;
        }
    }
}
