using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia.Equipamentos.Dominio
{
    public class Equipamento
    {
        public long IdEquipamento { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public int VidaUtilEmAnos { get; set; }
        public string AgrupamentoFoco { get; set; }
    }
}
