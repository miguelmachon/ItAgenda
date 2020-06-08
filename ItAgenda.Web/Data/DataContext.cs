using ItAgenda.Web.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItAgenda.Web.Data
{
    public class DataContext : IdentityDbContext<Usuario>
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Departamento> Departamentos { get; set; }

        public DbSet<Empleado> Empleados { get; set; }


        public DbSet<Empresa> Empresas { get; set; }

        public DbSet<It> Its { get; set; }

        public DbSet<Manager> Managers  { get; set; }

        public DbSet<Requerimento> Requerimentos { get; set; }

        public DbSet<RequerimientoDetalle> RequerimientoDetalles { get; set; }

        public DbSet<Sistema> Sistemas { get; set; }

        public DbSet<TipoPrioridad> TipoPrioridades { get; set; }

        public DbSet<TipoRequerimiento> TipoRequerimientos { get; set; }

                     
    }
}
