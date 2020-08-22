using MarketingDigitalWebA8.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketingDigitalWebA8.Engine.Interfaces
{
    public interface IEmpresaClienteRepository
    {
        EmpresaCliente GetEmpresaCliente(string password);
        EmpresaCliente AddEmpresaCliente(EmpresaCliente model);
        EmpresaCliente UpdateStatusEmpresaCliente(string name, string lastName, string email, bool status);
    }
}
