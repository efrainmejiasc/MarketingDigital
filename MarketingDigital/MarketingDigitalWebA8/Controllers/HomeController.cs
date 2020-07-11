using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarketingDigitalWebA8.Models.ObjModels;
using Microsoft.AspNetCore.Mvc;

namespace MarketingDigitalWebA8.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendEmail(string emailTo, string subject, string body)
        {
            var result = new RespuestaModel()
            {
                Result = true, 
                Description = emailTo + " " + subject + " " + body
            };
            return Json(result);
        }
    }
}
