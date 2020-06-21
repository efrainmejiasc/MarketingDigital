using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarketingDigitalBCS.EngineClass.Interfaces
{
    public interface IContactRepository
    {
        Task<bool> CreateAddContactAsync(string name, string surname, string email, string phoneNumber, int idList, bool updateEnable);
    }
}
