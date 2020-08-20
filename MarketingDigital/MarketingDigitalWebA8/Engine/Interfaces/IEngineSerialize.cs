using MarketingDigitalWebA8.Models.DbModels;
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
        EstructuraMail SerializeEmailBodyConsulta(string emailTo, string subject, string body, string name);
        EstructuraMail SerializeEmailRegisteredUser(string emailTo, string name, string lastName, string link);
        EstructuraMail SerializeEmailBodyRespuestaConsulta(string emailTo, string subject, string body, string name);
        EmpresaCliente SerializeEmpresaCliente(string name, string lastName, string email, string password, string company, string phone);
    }
}
