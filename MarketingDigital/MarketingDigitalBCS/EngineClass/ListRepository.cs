using MarketingDigitalBCS.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MarketingDigitalBCS.EngineClass.Interfaces;

namespace MarketingDigitalBCS.EngineClass
{
    public class ListRepository : IListRepository
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

        public async Task<SBResponse> CreateNewList(string jsonContent)
        {
            var response = new SBResponse();
            string respuesta = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("api-key", AppConfiguration.SbApiKey);
                HttpResponseMessage request = await client.PostAsync(AppConfiguration.EndPointCreateRecipientList, new StringContent(jsonContent, Encoding.UTF8, "application/json"));
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
