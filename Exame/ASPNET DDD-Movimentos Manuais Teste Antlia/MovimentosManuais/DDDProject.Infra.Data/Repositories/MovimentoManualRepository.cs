using DDDProject.Domain.Entities;
using DDDProject.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDProject.Infra.Data.Repositories
{
    public class MovimentoManualRepository : RepositoryBase<MovimentoManual>, IMovimentoManualRepository
    {
        public IEnumerable<MovimentoManual> SearchName(string name)
        {
            return Db.MovimentosManual.Where(p => p.COD_PRODUTO == name);
        }
    }
}
