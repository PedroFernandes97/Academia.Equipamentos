using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Academia.Equipamentos.ViewModels.Equipamento
{
    public class EquipamentoIndexViewModel
    {
        
        public long Id { get; set; }


        [Display (Name ="Nome do Filme")]
        public string Nome { get; set; }
    }
}