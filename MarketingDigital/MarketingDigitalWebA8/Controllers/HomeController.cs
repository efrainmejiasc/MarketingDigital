using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarketingDigitalWebA8.Engine.Interfaces;
using MarketingDigitalWebA8.Models.DbModels;
using MarketingDigitalWebA8.Models.ObjModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace MarketingDigitalWebA8.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEngineSerialize EngineSerialize;
        private readonly IEngineNotify EngineNotify;
        private readonly IWebHostEnvironment env;
        private readonly IEngineTool EngineTool;
        private readonly IEmpresaClienteRepository EmpresaClienteRepository;

        public HomeController(IEngineNotify _EngineNotify , IEngineSerialize _EngineSerialize, IWebHostEnvironment _env, IEngineTool _EngineTool, IEmpresaClienteRepository _EmpresaClienteRepository)
        {
            this.EngineNotify = _EngineNotify;
            this.EngineSerialize = _EngineSerialize;
            this.EngineTool = _EngineTool;
            this.EmpresaClienteRepository = _EmpresaClienteRepository;
            this.env = _env;
        }

        [HttpPost]
        public IActionResult SendEmail(string emailTo, string subject, string body, string name)
        {
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

        [HttpPost]
        public IActionResult RegisteredUser(string name, string lastName, string email, string password, string phone, string company)
        {
            password = EngineTool.ConvertirBase64(email + password);
            var model = EngineSerialize.SerializeEmpresaCliente(name, lastName, email, password, company, phone);
            var empresaCliente = EmpresaClienteRepository.AddEmpresaCliente(model);
            var resultado = empresaCliente.Id > 0 ? true : false; 
            var result = new RespuestaModel()
            {
                Result = resultado,
            };
            var parameterLink = EngineTool.ConvertirBase64(name + "#" + lastName + "#" + email);
            var estructuraEmail = EngineSerialize.SerializeEmailRegisteredUser(email, name, lastName, parameterLink);
            EngineNotify.EnviarMailNotificacion(estructuraEmail, env);
            return Json(result);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index (string ide)
        {
            if (!string.IsNullOrEmpty(ide))
            {
                ide = EngineTool.DecodeBase64(ide);
                string[] parts = ide.Split("#");
                var model = EmpresaClienteRepository.UpdateStatusEmpresaCliente(parts[0], parts[1], parts[2], true);
                if (model.Id > 0)
                {
                    ViewBag.Result = true;
                    ViewBag.Description = "Tu cuenta fue activada correctamente";
                }
            }
            return this.View();
        }

        [HttpPost]
        public IActionResult Login (string email , string password)
        {
            var respuesta = new RespuestaModel();
            var encodePassword = EngineTool.ConvertirBase64(email + password);
            var empresaCliente = EmpresaClienteRepository.GetEmpresaCliente(encodePassword);
            if (empresaCliente.Id == 0)
            {
                respuesta.Result = false;
                respuesta.Description = "Verifique usuario y contraseña";
            }
            else if (empresaCliente.Status == false)
            {
                respuesta.Result = false;
                respuesta.Description = "La cuenta no ha sido activada";
            } 
            else 
            {
                respuesta.Result = true;
                respuesta.Description = "Autentificado";
            }

            return Json(respuesta);
        }


    }
}
