using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valets.LojaVirtual.Dominio.Entidades;

namespace Valets.LojaVirtual.Dominio.Repositorio
{
    public class EfDbContext : DbContext //classe que inclui todos DBSets
    {
        public DbSet<Produto> Produtos { get; set; } //Referencia da Entity classe Produto 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("Produtos");
        }
    }
}
