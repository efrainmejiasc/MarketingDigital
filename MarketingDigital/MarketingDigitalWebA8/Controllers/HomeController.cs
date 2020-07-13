using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarketingDigitalWebA8.Engine.Interfaces;
using MarketingDigitalWebA8.Models.ObjModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace MarketingDigitalWebA8.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEngineSerialize EngineSerialize;
        private readonly IEngineNotify EngineNotify;
        private readonly IWebHostEnvironment env;

        public HomeController(IEngineNotify _EngineNotify , IEngineSerialize _EngineSerialize, IWebHostEnvironment _env)
        {
            this.EngineNotify = _EngineNotify;
            this.EngineSerialize = _EngineSerialize;
            this.env = _env;
        }

        [HttpPost]
        public IActionResult SendEmail(string emailTo, string subject, string body, string name)
        {
            string n = "";

            var estructuraEmail = EngineSerialize.SerializeEmailBodyRespuestaConsulta(emailTo, subject, body, name);
            var  resultado = EngineNotify.EnviarMailNotificacion(estructuraEmail, env);
            estructuraEmail = EngineSerialize.SerializeEmailBodyConsulta(emailTo, subject, body, name);
            resultado = EngineNotify.EnviarNotificacionEmailOutlook(estructuraEmail, env);
            var result = new RespuestaModel()
            {
                Result = resultado,
            };
            return Json(result);
        }
    }
}
