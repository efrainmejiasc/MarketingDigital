using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketingDigitalWebA8.Engine.Interfaces
{
    public interface IEngineTool
    {
        string ConvertirBase64(string cadena);
        string DecodeBase64(string base64EncodedData);
    }
}
