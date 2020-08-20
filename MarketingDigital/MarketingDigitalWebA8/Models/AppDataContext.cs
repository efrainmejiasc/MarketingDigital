using MarketingDigitalWebA8.Models.DbModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketingDigitalWebA8.Models
{
    public class AppDataContext : DbContext
    {
        public AppDataContext()
        {
        }
        public AppDataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<EmpresaCliente> EmpresaCliente{ get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<EmpresaCliente>()
                .HasIndex(u => u.Email)
                .IsUnique();
        }
    }
}
