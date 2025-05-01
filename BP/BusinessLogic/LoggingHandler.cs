using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace BusinessLogic
{
    internal class LoggingHandler : DelegatingHandler
    {
        public LoggingHandler(HttpMessageHandler innerHandler)
        : base(innerHandler)
        {

        }

        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            Debug.WriteLine($"Request: {request.Method} {request.RequestUri}");

            if (request.Content != null)
            {
                var requestBody = await request.Content.ReadAsStringAsync();
                Debug.WriteLine($"Request Body: {requestBody}");
            }

            var response = await base.SendAsync(request, cancellationToken);

            Debug.WriteLine($"Response: {(int)response.StatusCode} {response.ReasonPhrase}");

            if (response.Content != null)
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                Debug.WriteLine($"Response Body: {responseBody}");
            }

            return response;
        }
    }
}
