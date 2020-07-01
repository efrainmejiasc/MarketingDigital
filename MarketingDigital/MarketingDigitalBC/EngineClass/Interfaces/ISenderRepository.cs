using MarketingDigitalBC.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarketingDigitalBC.EngineClass.Interfaces
{
    public interface ISenderRepository
    {
        Task<SBRecoverSender> GetRecoverSender();
        Task<SBResponse> CreateNewSender(string jsonContent);
    }
}
