using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Equipamentos.Generica.Entity
{
   public abstract class AcademiaEntityAbstractConfig<TEntidade> : EntityTypeConfiguration<TEntidade>
        where TEntidade : class
    {
        public AcademiaEntityAbstractConfig()
        {
            ConfigurarNomeTabela();
            ConfigurarCamposTabela();
            ConfigurarChavePrimaria();
            ConfigurarChaveEstrangeira();
        }

        protected abstract void ConfigurarChaveEstrangeira();

        protected abstract void ConfigurarChavePrimaria();

        protected abstract void ConfigurarCamposTabela();
        
        protected abstract void ConfigurarNomeTabela();

    }
}
