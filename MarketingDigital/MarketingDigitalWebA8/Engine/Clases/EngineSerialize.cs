using MarketingDigitalWebA8.Engine.Interfaces;
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
                Observacion = body,
                PathLecturaArchivo = string.Empty
            };
            return model;
        }
    }
}
