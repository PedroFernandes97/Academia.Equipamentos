using AutoMapper;
using Academia.Equipamentos.Dominio;
using Academia.Equipamentos.ViewModels.Equipamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Academia.Equipamentos.AutoMapper
{
    public class ViewModelParaDominioProfile : Profile
    {
        protected void Configure()
        {
            CreateMap<EquipamentoViewModel, Equipamento>();
        }
    }
}