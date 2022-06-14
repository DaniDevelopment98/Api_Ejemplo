using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using api_Ejemplo.Models;

namespace api_Ejemplo.Data
{
    public class api_EjemploContext : DbContext
    {
        public api_EjemploContext (DbContextOptions<api_EjemploContext> options)
            : base(options)
        {
        }

        public DbSet<api_Ejemplo.Models.Clientes> Clientes { get; set; }
    }
}
