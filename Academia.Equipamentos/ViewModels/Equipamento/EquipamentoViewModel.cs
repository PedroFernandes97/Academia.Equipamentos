using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Academia.Equipamentos.ViewModels.Equipamento
{
    public class EquipamentoViewModel
    {
        [Required(ErrorMessage ="O Id não pode ficar em branco")]
        public long Id { get; set; }


        [Display(Name = "Nome do Equipamento")]
        [Required(ErrorMessage ="Preencha o nome do Equipamento")]
        [MaxLength(100, ErrorMessage ="O nome do equipamento deve ter no maximo 100 caracteres.")]
        public string NomeFilme { get; set; }
    }
}