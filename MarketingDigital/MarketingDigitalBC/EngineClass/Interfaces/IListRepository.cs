﻿using MarketingDigitalBC.Response;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarketingDigitalBC.EngineClass.Interfaces
{
    public interface IListRepository
    {
        Task<SBRecoverList> GetRecoverList();
        Task<SBRecoverList> GetRecoverAllListContact();
        Task<SBResponse> CreateNewList(string jsonContent);
        Task<SBRecoverListInFolder> GetRecoverListInFolder(string id);
    }
}
