using MarketingDigitalWebA8.Engine.Interfaces;
using MarketingDigitalWebA8.Models.DbModels;
using MarketingDigitalWebA8.Models.ObjModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketingDigitalWebA8.Engine.Clases
{
    public class EngineSerialize : IEngineSerialize
    {

        public EstructuraMail SerializeEmailBodyRespuestaConsulta(string emailTo, string subject, string body, string name)
        {
            var model = new EstructuraMail()
            {
                Saludo = "Hola: " + name,
                Fecha = DateTime.UtcNow.ToString("dd/MM/yyyy"),
                EmailDestinatario = emailTo,
                Asunto = "Respuesta a (y/o) consulta",
                Observacion = "Recibimos su consulta: " +  subject,
                Descripcion = "Responderemos lo antes posible , gracias por cotactarnos! ...",
                PathLecturaArchivo = "EmailBodyQuery.cshtml"
            };
            return model;
        }

        public EstructuraMail SerializeEmailBodyConsulta(string emailTo, string subject, string body, string name)
        {
            var model = new EstructuraMail()
            {
                Saludo = "Efrain en buena hora tienes una consulta!...",
                Fecha = DateTime.UtcNow.ToString("dd/MM/yyyy"),
                EmailDestinatario = "emcingenieriadesoftware@outlook.com",
                Descripcion = "Desde: " + emailTo,
                Asunto = subject,
                Observacion = subject + "<br>" + body,
                PathLecturaArchivo = "EmailBodyQuery.cshtml"
            };
            return model;
        }

        public EmpresaCliente SerializeEmpresaCliente(string name, string lastName, string email, string password, string company, string phone)
        {
            var model = new EmpresaCliente()
            {
              Name=name,
              LastName = lastName,
              Email = email,
              Password = password,
              Company = company,
              Phone = phone,
              Status = false,
              CreateDate = DateTime.UtcNow
            };

            return model;
        }

        public EstructuraMail SerializeEmailRegisteredUser(string emailTo,string name,string lastName,string link)
        {
            var model = new EstructuraMail()
            {
                Saludo = "Hola: " + name,
                Fecha = DateTime.UtcNow.ToString("dd/MM/yyyy"),
                EmailDestinatario = emailTo,
                Asunto = "Activa tu cuenta en EMC Ingenieria de Software",
                Observacion = "Haz Click en el siguiente link !!",
                Descripcion = "http://joselelu-001-site2.etempurl.com/Home/Index?ide=" + link,
                PathLecturaArchivo = "EmailBodyQuery.cshtml"
            };
            return model;
        }
    }
}
