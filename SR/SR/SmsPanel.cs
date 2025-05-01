using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using DataModel.SRModel;
using Newtonsoft.Json;

namespace SR
{
    public class SmsPanel 
    {
        private readonly HttpClient _httpClient;
        private readonly SmsConfig_VM _config; 

        public SmsPanel(SmsConfig_VM config)
        {
            _config = config;
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(config.BaseUrl),
            };
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> SendSmsAsync(string recipient, string message)
        {
            try
            {
                var requestData = new
                {
                    username = _config.Username,
                    password = _config.Password,
                    to = recipient,
                    from = _config.SenderNumber,
                    text = message,
                };

                var json = JsonConvert.SerializeObject(requestData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                using(_httpClient)
                {
                    var response = await _httpClient.PostAsync("api/send/simple/213a67b00f114b2c965431ea07966249", content).ConfigureAwait(false);
                    if (!response.IsSuccessStatusCode)
                    {
                        throw new Exception($"API request failed with status: {response.StatusCode}");
                    }

                    return await response.Content.ReadAsStringAsync();
                }
            }
            catch (HttpRequestException ex)
            {
                throw new Exception($"HTTP error: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to send SMS: {ex.Message}", ex);
            }
        }
        public void Dispose()
        {
            _httpClient?.Dispose();
        }

    }
}
