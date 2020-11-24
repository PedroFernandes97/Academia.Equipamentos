using Academia.Equipamentos.Dados.Entity.Context;
using Academia.Equipamentos.Dominio;
using Academia.Repositorios.Comum.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Academia.Equipamentos.Repositorios.Entity
{
    public class EquipamentosRepositorio : RepositorioGenericoEntity<Equipamento, int>
    {
        public EquipamentosRepositorio(EquipamentoDbContext contexto)
            : base(contexto)
        {

        }

        //public override List<Equipamento> Selecionar()
        //{
        //    return _contexto.Set<Equipamento>().Include(p => p.).ToList();
        //}

        //public override Equipamento SelecionarPorId(int id)
        //{
        //    return _contexto.Set<Equipamento>().Include(p => p.Filmes)
        //        .SingleOrDefault(a => a.Id == id);
        //}
    }
}
