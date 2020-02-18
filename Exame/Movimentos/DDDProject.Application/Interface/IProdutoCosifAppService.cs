using DDDProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDProject.Application.Interface
{
   
    public interface IProdutoCosifAppService : IAppServiceBase<ProdutoCosif>
    {
        IEnumerable<ProdutoCosif> SearchName(string name);
    }
}
