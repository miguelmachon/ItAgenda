using ItAgenda.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItAgenda.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _dataContext;

        public SeedDb(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public async Task SeedAsync()
        {

            await _dataContext.Database.EnsureCreatedAsync();
            await CheckDepartamentoAsync();
            await CheckEmpresaAsync();
            await CheckItAsync();
            await CheckSistemaAsync();
            await CheckTipoPrioridadAsync();

        }

        private async Task CheckTipoPrioridadAsync()
        {
            if (!_dataContext.TipoPrioridades.Any())
            {
                 _dataContext.TipoPrioridades.Add(new TipoPrioridad { 
                    Nombre = "Normal"
                });

                _dataContext.TipoPrioridades.Add(new TipoPrioridad
                {
                    Nombre = "Alta"
                });


                await _dataContext.SaveChangesAsync();
            }
        }

        private async  Task CheckDepartamentoAsync()
        {
            if (!_dataContext.Departamentos.Any())
            {
                _dataContext.Add(new Departamento { 
                   Nombre = "Atencion Cliente"
                });

                await _dataContext.SaveChangesAsync();

            }
        }

        private async Task CheckItAsync()
        {

            if (!_dataContext.Its.Any())
            {
                var empresa = _dataContext.Empresas.FirstOrDefault();

                _dataContext.Its.Add(
                new It
                {
                    Apellido = "Aguilar Machon",
                    Celular = "7746207",
                    Email = "miguelmachon@gmail.com",
                    Nombre = "Miguel Eduardo",
                    Empresa =empresa

                });

                await _dataContext.SaveChangesAsync();
            }

        }



        private async  Task CheckEmpresaAsync()
        {

            _dataContext.Empresas.Add(new Empresa { 
                Direccion = "Santa Ana",
                Email="correo@gmail.com",
                Nit = "0",
                Nombre = "IVAN S.A. DE C.V.",
                Nrc ="0",
                RazonSocial = "IVAN S.A. DE C.V.",
                Telefono = "2484-4001",
               

            });

            await _dataContext.SaveChangesAsync();

        }

        private async Task CheckSistemaAsync()
        {
            
            if (!_dataContext.Sistemas.Any())
            {
                _dataContext.Sistemas.Add(new Sistema {

                    Nombre = "LOTES"                

                });

               await _dataContext.SaveChangesAsync();
            }
            
        }

    }
}
