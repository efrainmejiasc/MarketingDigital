using MarketingDigitalBCS.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarketingDigitalBCS.EngineClass.Interfaces
{
    public interface ICampanaEmailRepository
    { 
        Task<SBResponse> CreateEmailCampana(string jsonContent);
        Task<SBRecoverEmailCampaing> GetRecoverAllCampanaEmail();
    }
}
