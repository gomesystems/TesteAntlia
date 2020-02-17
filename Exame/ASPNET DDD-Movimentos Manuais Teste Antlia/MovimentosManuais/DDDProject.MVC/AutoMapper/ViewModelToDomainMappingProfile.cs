using AutoMapper;
using DDDProject.Domain.Entities;
using DDDProject.MVC.ViewModels;
using MovimentosManuais.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DDDProject.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public static void NewMapperProfile()
        {
            Mapper.Initialize(x =>
            {
                x.CreateMap<Produto, ProdutoViewModel>();
                x.CreateMap<ProdutoCosif, ProdutoCosifViewModel>();
                x.CreateMap<MovimentoManual, MovimentoManualViewModel>();
            });
        }
    }
}