using MarketingDigitalWebA8.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketingDigitalWebA8.Engine.Interfaces
{
    public interface  IAppLogRepository
    {
        AppLog AddAppLog(AppLog model);
    }
}
