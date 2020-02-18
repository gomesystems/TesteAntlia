using DDDProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDProject.Domain.Interfaces.Repositories
{
    public interface IProdutoCosifRepository : IRepositoryBase<ProdutoCosif>
    {
        IEnumerable<ProdutoCosif> SearchName(string name);
    }
}