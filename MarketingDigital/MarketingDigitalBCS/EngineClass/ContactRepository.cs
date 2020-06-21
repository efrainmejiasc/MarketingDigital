
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
    public class ContactRepository
    {
        public async Task<bool> CreateContact(string email, string name, string surname, string phoneNumber, int idList, bool updateEnable)
        {
            var serializeModel = new SerializeModel();
            string dataContact = string.Empty;
            var response = new SBResponse();
            response = await GetObjectSB(AppConfiguration.EndPointGetInformationContact.Replace("EMAIL", email));
            if (response.exception)
            {
                dataContact = serializeModel.SerializerDataNewContact(email, name, surname, phoneNumber, idList, updateEnable);
                response = new SBResponse();
                response = await PostObjectSB(dataContact, AppConfiguration.EndPointCreateContact);
            }
            else
            {
                dataContact = serializeModel.SerializerDataAddContact(email);
                response = new SBResponse();
                response = await PostObjectSB(dataContact, AppConfiguration.EndPointAddContactToList.Replace("ID", idList.ToString()));
            }
            return response.exception;
        }

        private async Task<SBResponse> GetObjectSB(string endPoint)
        {
            var response = new SBResponse();
            string respuesta = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("api-key", AppConfiguration.SbApiKey);
                HttpResponseMessage request = await client.GetAsync(endPoint);

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

        private async Task<SBResponse> PostObjectSB(string jsonContent, string endPoint)
        {
            SBResponse response = new SBResponse();
            string respuesta = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("api-key", AppConfiguration.SbApiKey);
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
