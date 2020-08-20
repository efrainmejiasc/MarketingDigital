using MarketingDigitalWebA8.Engine.Interfaces;
using MarketingDigitalWebA8.Models;
using MarketingDigitalWebA8.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketingDigitalWebA8.Engine.Clases.Repositories
{
    public class EmpresaClienteRepository : IEmpresaClienteRepository
    {
        private readonly AppDataContext AppDataContext;

        public EmpresaClienteRepository(AppDataContext _AppDataContext)
        {
            AppDataContext = _AppDataContext;
        }

        public EmpresaCliente AddEmpresaCliente (EmpresaCliente model)
        {
            using (AppDataContext)
            {
                AppDataContext.EmpresaCliente.Add(model);
                AppDataContext.SaveChanges();
            }
            return model;
        }

        public EmpresaCliente UpdateStatusEmpresaCliente(string name, string lastName, string email,bool status)
        {
            var model = new EmpresaCliente();
            using (AppDataContext)
            {
                model = AppDataContext.EmpresaCliente.Where(x => x.Name == name && x.LastName == lastName && x.Email == email).FirstOrDefault();
                if (model != null)
                {
                    AppDataContext.EmpresaCliente.Attach(model);
                    model.Status = status;
                    AppDataContext.SaveChanges();
                }
              
            }
            return model;
        }

    }
}
