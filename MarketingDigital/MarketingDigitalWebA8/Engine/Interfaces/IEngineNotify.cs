using MarketingDigitalWebA8.Models.ObjModels;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketingDigitalWebA8.Engine.Interfaces
{
    public interface IEngineNotify
    {
        bool EnviarMailNotificacion(EstructuraMail model, IWebHostEnvironment env);
        bool EnviarNotificacionEmailOutlook(EstructuraMail model, IWebHostEnvironment env);
    }
}
