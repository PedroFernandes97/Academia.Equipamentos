using Academia.Equipamentos.Dominio;
using Academia.Equipamentos.Dados.Entity.TypeConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Equipamentos.Dados.Entity.Context
{
    public class EquipamentoDbContext : DbContext
    {
        public DbSet<Equipamento> Equipamentos { get; set; }

        public EquipamentoDbContext()//construtor apenas para otimizar o processamento das migrations
                               //porém é dispensável.
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EquipamentoTypeConfiguration());
        }      
    }
}
