using Academia.Equipamentos.Dominio;
using Academia.Equipamentos.Generica.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Equipamentos.Dados.Entity.TypeConfiguration
{
    class EquipamentoTypeConfiguration : AcademiaEntityAbstractConfig<Equipamento>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.IdEquipamento)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations
                                           .Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Nome");

            Property(p => p.Marca)
                .IsRequired()
                .HasColumnName("Ano");

            Property(p => p.AgrupamentoFoco)
                .IsOptional()
                .HasMaxLength(1000)
                .HasColumnName("Descricao");

            Property(p => p.VidaUtilEmAnos)
                .IsRequired()
                .HasColumnName("Email");

        }

        protected override void ConfigurarChaveEstrangeira()
        {
            
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.IdEquipamento);
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("Equipamento");
        }
    }
}
