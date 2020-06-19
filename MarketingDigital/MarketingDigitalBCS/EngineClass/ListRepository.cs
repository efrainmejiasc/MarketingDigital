using MarketingDigitalBCS.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MarketingDigitalBCS.EngineClass
{
    public class ListRepository
    {
        public async Task<SBRecoverList> GetRecoverList()
        {
            var response = new SBRecoverList();
            string respuesta = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("api-key",AppConfiguration.SbApiKey);
                HttpResponseMessage request = await client.GetAsync(AppConfiguration.EndPointRecoverList);

                if (request.IsSuccessStatusCode)
                {
                    respuesta = await request.Content.ReadAsStringAsync();
                    response = JsonConvert.DeserializeObject<SBRecoverList>(respuesta);
                }
            }
            return response;
        }

        public async Task<SBResponse> CreateNewList(string jsonContent, string apiKey, string endPoint)
        {
            var response = new SBResponse();
            string respuesta = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("api-key", apiKey);
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

            return response;
        }
    }
}
