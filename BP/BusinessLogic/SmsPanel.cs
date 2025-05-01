using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using DataModel.SRModel;
using Newtonsoft.Json;

namespace BusinessLogic
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

        public async Task<string> HttpClient()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://rest.payamak-panel.com/api/SmartSMS/Send");
            var content = new StringContent("{\r\n \"username\":\"09380458367\",\r\n \"password\": \"2809e415-564d-4009-a2ac-6753b234ca5a\",\r\n \"to\":[\"09380458367\"],\r\n \"from\":\"9850002710058367\",\r\n \"text\":\"هک شدی رفت . الان دیگه همه اطلاعاتت تو سرور منه:))))\",\r\n \"fromSupportOne\" : \"\",\r\n \"fromSupportTwo\" : \"\"\r\n}\r\n", null, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
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

                var response = await _httpClient.PostAsync("api/send/simple/213a67b00f114b2c965431ea07966249", content).ConfigureAwait(false);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"API request failed with status: {response.StatusCode}");
                }

                return await response.Content.ReadAsStringAsync();
            }
            //catch (TaskCanceledException ex) when (!ex.CancellationToken.IsCancellationRequested)
            //{
            //    throw new Exception("Request timed out", ex);
            //}
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
