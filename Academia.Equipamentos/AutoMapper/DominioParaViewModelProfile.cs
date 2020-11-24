using Academia.Equipamentos.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Academia.Equipamentos.ViewModels.Equipamento;

namespace Academia.Equipamentos.AutoMapper
{
    public class DominioParaViewModelProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Equipamento, EquipamentoIndexViewModel>()
                .ForMember(p => p.Nome, opt =>
                {
                    opt.MapFrom(src =>
                    string.Format("{0} {1}", src.Nome, src.Ano.ToString ())
                    );
                });
            Mapper.CreateMap<Equipamento, EquipamentoIndexViewModel>();
        }
    }
}