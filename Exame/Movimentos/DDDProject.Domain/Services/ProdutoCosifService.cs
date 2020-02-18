using DDDProject.Domain.Entities;
using DDDProject.Domain.Interfaces.Repositories;
using DDDProject.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDProject.Domain.Services
{
    public class ProdutoCosifService : ServiceBase<ProdutoCosif>, IProdutoCosifService
    {
        private readonly IProdutoCosifRepository _produtoCosifRepository;

        public ProdutoCosifService(IProdutoCosifRepository produtoCosifRepository) : base(produtoCosifRepository)
        {
            _produtoCosifRepository = produtoCosifRepository;
        }

        public IEnumerable<ProdutoCosif> SearchName(string name)
        {
            return _produtoCosifRepository.SearchName(name);
        }
    }
}
