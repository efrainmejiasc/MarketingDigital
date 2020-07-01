using MarketingDigitalBC.Response;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MarketingDigitalBC.EngineClass.Interfaces
{
    public interface IContactRepository
    {
        Task<bool> DeleteContact(string email);
        Task<SBResponseAllContacts> GetAllContacts();
        Task<bool> UpdateContact(string jsonContent, string email);
        Task<SBResponseContactInList> GetContactInList(string idLista);
        Task<bool> CreateAddContactAsync(string name, string surname, string email, string phoneNumber, int idList, bool updateEnable);
    }
}
