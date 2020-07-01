using System;
using System.Collections.Generic;
using System.Text;

namespace MarketingDigitalBC.EngineClass.Interfaces
{
    public interface IToolApp
    {
        bool EmailEsValido(string email);
        string ConvertirBase64(string cadena);
    }
}
