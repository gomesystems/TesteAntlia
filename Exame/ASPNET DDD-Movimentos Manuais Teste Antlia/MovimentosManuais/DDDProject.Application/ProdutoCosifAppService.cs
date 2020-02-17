using DDDProject.Application.Interface;
using DDDProject.Domain.Entities;
using DDDProject.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDProject.Application
{
    public class ProdutoCosifAppService : AppServiceBase<ProdutoCosif>, IProdutoCosifAppService
    {
        private readonly IProdutoCosifService _produtoCosifService;

        public ProdutoCosifAppService(IProdutoCosifService produtoCosifService) : base(produtoCosifService)
        {
            _produtoCosifService = produtoCosifService;
        }

        public IEnumerable<ProdutoCosif> SearchName(string name)
        {
            return _produtoCosifService.SearchName(name);
        }
    }
}
