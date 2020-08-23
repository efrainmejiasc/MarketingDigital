using MarketingDigitalWebA8.Engine.Interfaces;
using MarketingDigitalWebA8.Models;
using MarketingDigitalWebA8.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketingDigitalWebA8.Engine.Clases.Repositories
{
    public class AppLogRepository: IAppLogRepository
    {
        private readonly AppDataContext AppDataContext;

        public AppLogRepository(AppDataContext _AppDataContext)
        {
            AppDataContext = _AppDataContext;
        }

        public AppLog AddAppLog(AppLog model)
        {
            AppDataContext.AppLog.Add(model);
            AppDataContext.SaveChanges();
            return model;
        }
    }
}
