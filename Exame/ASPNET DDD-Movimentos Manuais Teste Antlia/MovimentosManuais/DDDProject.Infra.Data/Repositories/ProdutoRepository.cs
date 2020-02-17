using DDDProject.Domain.Entities;
using DDDProject.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDProject.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> SearchName(string name)
        {
            return Db.Produtos.Where(p => p.COD_PRODUTO == name);
        }
    }
}
