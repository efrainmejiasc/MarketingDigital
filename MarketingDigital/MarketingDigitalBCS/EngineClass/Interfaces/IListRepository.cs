using MarketingDigitalBCS.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarketingDigitalBCS.EngineClass.Interfaces
{
    public interface IListRepository
    {
        Task<SBRecoverList> GetRecoverList();
        Task<SBResponse> CreateNewList(string jsonContent);
        Task<SBRecoverListInFolder> GetRecoverListInFolder(string id);
    }
}
