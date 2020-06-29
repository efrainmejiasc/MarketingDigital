using MarketingDigitalBCS.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarketingDigitalBCS.EngineClass.Interfaces
{
    public interface IContactRepository
    {
        Task<SBResponseAllContacts> GetAllContacts();
        Task<SBResponseContactInList> GetContactInList(string idLista);
        Task<bool> CreateAddContactAsync(string name, string surname, string email, string phoneNumber, int idList, bool updateEnable);
    }
}
