using MarketingDigitalBC.EngineClass.Interfaces;
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
    public class CampanaEmailRepository : ICampanaEmailRepository
    {
        public async Task<SBResponse> CreateEmailCampana(string jsonContent)
        {
            var response = new SBResponse();
            string respuesta = string.Empty;

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("api-key", AppConfiguration.SbApiKey);
                HttpResponseMessage request = await client.PostAsync(AppConfiguration.EndPointCreateEmailCampaing, new StringContent(jsonContent, Encoding.UTF8, "application/json"));
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

        public async Task<SBRecoverEmailCampaing> GetRecoverAllCampanaEmail()
        {
            var response = new SBRecoverEmailCampaing();
            string respuesta = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("api-key", AppConfiguration.SbApiKey);
                HttpResponseMessage request = await client.GetAsync(AppConfiguration.EndPointRecoverEmailCampaing);

                if (request.IsSuccessStatusCode)
                {
                    respuesta = await request.Content.ReadAsStringAsync();
                    response = JsonConvert.DeserializeObject<SBRecoverEmailCampaing>(respuesta);
                }
            }
            return response;
        }


        public async Task<bool> SendEmailCampana(string jsonContent,string idCampaing)
        {
            bool response = true;
            string respuesta = string.Empty;

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("api-key", AppConfiguration.SbApiKey);
                HttpResponseMessage request = await client.PostAsync(AppConfiguration.EndPointSendEmailCampaing.Replace("ID",idCampaing), new StringContent(jsonContent, Encoding.UTF8, "application/json"));
                if (request.IsSuccessStatusCode)
                    response = false;
            }

            return response;
        }
    }
}
