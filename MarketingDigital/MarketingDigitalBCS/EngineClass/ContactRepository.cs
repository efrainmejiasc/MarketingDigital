
using MarketingDigitalBCS.EngineClass.Interfaces;
using MarketingDigitalBCS.Response;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MarketingDigitalBCS.EngineClass
{
    public class ContactRepository : IContactRepository
    {
        public async Task<bool> CreateAddContactAsync( string name, string surname, string email, string phoneNumber, int idList, bool updateEnable)
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

        public async Task<SBResponseContactInList> GetContactInList(string idLista)
        {
            var response = new SBResponseContactInList();
            string respuesta = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("api-key", AppConfiguration.SbApiKey);
                HttpResponseMessage request = await client.GetAsync(AppConfiguration.EndPointRecoverContactInList.Replace("ID",idLista));

                if (request.IsSuccessStatusCode)
                {
                    respuesta = await request.Content.ReadAsStringAsync();
                    response = JsonConvert.DeserializeObject<SBResponseContactInList>(respuesta);
                }
            }
            return response;
        }

        public async Task<SBResponseAllContacts> GetAllContacts()
        {
            var response = new SBResponseAllContacts();
            string respuesta = string.Empty;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("api-key", AppConfiguration.SbApiKey);
                HttpResponseMessage request = await client.GetAsync(AppConfiguration.EndPointRecoverAllContacts);

                if (request.IsSuccessStatusCode)
                {
                    respuesta = await request.Content.ReadAsStringAsync();
                    response = JsonConvert.DeserializeObject<SBResponseAllContacts>(respuesta);
                }
            }
            return response;
        }

        public async Task<bool> DeleteContact(string email)
        {
            bool result = true;
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("api-key", AppConfiguration.SbApiKey);
                HttpResponseMessage request = await client.DeleteAsync(AppConfiguration.EndPointDeleteContact.Replace("EMAIL","email"));

                if (request.IsSuccessStatusCode)
                {
                    result = false;
                }
            }
            return result;
        }

        public async Task<bool> UpdateContact(string jsonContent, string email)
        {
            bool result = true;
            var client = new RestClient(AppConfiguration.EndPointUpdateContact.Replace("EMAIL",email));
            var request = new RestRequest(Method.PUT);
            request.AddHeader("accept", "application/json");
            request.AddHeader("content-type", "application/json");
            request.AddHeader("api-key", AppConfiguration.SbApiKey);
            request.AddJsonBody(jsonContent);
            IRestResponse response = await client.ExecuteAsync(request);
            if (response.StatusCode.ToString() == "204")
            {
                result = false;
            }
            return result;
        }

    }
}
