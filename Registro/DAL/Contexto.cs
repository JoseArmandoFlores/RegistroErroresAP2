using Microsoft.EntityFrameworkCore;
using Registro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Registro.DAL
{
    public class Contexto:DbContext
    {
        public DbSet<Errores> Errores { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = DATA\Hallazgo.db");
        }
    }
}
