using MarketingDigitalWebA8.Models.ObjModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketingDigitalWebA8.Engine.Interfaces
{
    public interface IEngineSerialize
    {
        EstructuraMail SerializeEmailBodyRespuestaConsulta(string emailTo, string subject, string body, string name);

        EstructuraMail SerializeEmailBodyConsulta(string emailTo, string subject, string body, string name);
    }
}
