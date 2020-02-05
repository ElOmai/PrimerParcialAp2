using Microsoft.EntityFrameworkCore;
using PrimerParcialAp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcialAp2.Data
{
    public class Context : DbContext
    {
        public DbSet<Entidad> entidad { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = DESKTOP-GFIDBJA\SQLEXPRESS; Database = PrestamosDb; Trusted_Connection = True;");

        }
    }
}
