using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TwitterTests.Utils
{
    public static class RestClientExtension
    {
        public static async Task<IRestResponse<T>> ExecuteAsyncRequest<T>(this RestClient client, IRestRequest request) where T : class, new()
        {
            var taskCompletionSource = new TaskCompletionSource<IRestResponse<T>>();

            client.ExecuteAsync<T>(request, restResponse =>
            {
                taskCompletionSource.SetResult(restResponse);
            });

            return await taskCompletionSource.Task;
        }
    }
}
