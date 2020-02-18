using DDDProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDProject.Application.Interface
{

    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> SearchName(string name);
    }
}
