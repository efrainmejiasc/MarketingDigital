using MarketingDigitalBC.Response;
using Newtonsoft.Json;
using System;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MarketingDigitalBC.EngineClass
{
    public class FolderRepository
    {
        public async Task<SBRecoverFolder> GetRecoverFolder(string apiKey, string endPoint)
        {
            var response = new SBRecoverFolder();
            string respuesta = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("api-key", AppConfiguration.SbApiKey);
                HttpResponseMessage request = await client.GetAsync(AppConfiguration.EndPointRecoverFolder);

                if (request.IsSuccessStatusCode)
                {
                    respuesta = await request.Content.ReadAsStringAsync();
                    response = JsonConvert.DeserializeObject<SBRecoverFolder>(respuesta);
                }
            }
            return response;
        }

        public async Task<SBResponse> CreateNewFolder(string jsonContent)
        {
            var response = new SBResponse();
            string respuesta = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("api-key", AppConfiguration.SbApiKey);
                HttpResponseMessage request = await client.PostAsync(AppConfiguration.EndPointCreateFolder, new StringContent(jsonContent, Encoding.UTF8, "application/json"));
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
