using MarketingDigitalBCS.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarketingDigitalBCS.EngineClass.Interfaces
{
    public interface IFolderRepository
    {
        Task<SBResponse> CreateNewFolder(string jsonContent);
        Task<SBRecoverFolder> GetRecoverFolder();
    }
}
