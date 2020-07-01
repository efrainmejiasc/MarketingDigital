using MarketingDigitalBC.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarketingDigitalBC.EngineClass.Interfaces
{
    public interface IFolderRepository
    {
        Task<SBResponse> CreateNewFolder(string jsonContent);
        Task<SBRecoverFolder> GetRecoverFolder();
    }
}
