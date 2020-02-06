using Microsoft.EntityFrameworkCore;
using PrimerParcialAp2.Models;


namespace PrimerParcialAp2.Data
{
    public class Context : DbContext
    {
        public DbSet<Articulo> articulo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = DESKTOP-GFIDBJA\SQLEXPRESS; Database = PrimerParcialAp2Db; Trusted_Connection = True;");

        }
    }
}
