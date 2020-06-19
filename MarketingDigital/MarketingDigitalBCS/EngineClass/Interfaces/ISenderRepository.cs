using MarketingDigitalBCS.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarketingDigitalBCS.EngineClass.Interfaces
{
    public interface ISenderRepository
    {
        Task<SBResponse> CreateNewSender(string jsonContent);
    }
}
