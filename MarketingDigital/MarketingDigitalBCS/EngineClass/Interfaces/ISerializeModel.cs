using MarketingDigitalBCS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarketingDigitalBCS.EngineClass.Interfaces
{
    public interface ISerializeModel
    {
        string SerializeCreateNewSender(string nombre, string email);
    }
}
