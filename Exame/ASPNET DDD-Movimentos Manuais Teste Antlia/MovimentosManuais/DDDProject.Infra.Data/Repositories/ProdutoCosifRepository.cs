using DDDProject.Domain.Entities;
using DDDProject.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDProject.Infra.Data.Repositories
{
    public class ProdutoCosifRepository : RepositoryBase<ProdutoCosif>, IProdutoCosifRepository
    {
        public IEnumerable<ProdutoCosif> SearchName(string name)
        {
            return Db.ProdutosCosif.Where(p => p.COD_PRODUTO == name);
        }
    }
}
