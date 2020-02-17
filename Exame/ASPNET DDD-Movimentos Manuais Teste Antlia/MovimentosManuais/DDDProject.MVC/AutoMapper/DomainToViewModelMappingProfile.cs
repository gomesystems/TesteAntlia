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
    public class DomainToViewModelMappingProfile : Profile
    {
        //public override string ProfileName
        //{
        //    get { return "ViewModelToDomainMappingProfile";  }
        //}

        public static void NewMapperProfile()
        {
            Mapper.Initialize(x =>
            {
                x.CreateMap<ProdutoCosifViewModel, ProdutoCosif>();
                x.CreateMap<ProdutoViewModel, Produto>();
                x.CreateMap<MovimentoManualViewModel, MovimentoManual>();
            });
        }
    }
}