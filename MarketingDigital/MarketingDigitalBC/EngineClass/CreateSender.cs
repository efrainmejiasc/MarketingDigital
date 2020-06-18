using MarketingDigitalBC.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MarketingDigitalBC.EngineClass
{
    public class CreateSender
    {
        public async Task<SBResponse> CreateNewSender(string jsonContent, string endPoint, string apiKey)
        {
            var response = new SBResponse();
            string respuesta = string.Empty;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("api-key",apiKey);
                    HttpResponseMessage request = await client.PostAsync(endPoint, new StringContent(jsonContent, Encoding.UTF8, "application/json"));
                    if (request.IsSuccessStatusCode)
                    {
                        respuesta = await request.Content.ReadAsStringAsync();
                        response = JsonConvert.DeserializeObject<SBResponse>(respuesta);
                        response.exception = false;
                    }
                    else
                    {
                        response.exception = true;
                    }
                }
            }
            catch (Exception ex)
            {
                response.messageError = ex.ToString();
            }
            return response;
        }
    }
}
