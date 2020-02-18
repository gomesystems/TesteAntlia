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
    public class MovimentoManualService : ServiceBase<MovimentoManual>, IMovimentoManualService
    {
        private readonly IMovimentoManualRepository _MovimentoManualRepository;

        public MovimentoManualService(IMovimentoManualRepository movimentoManualRepository) : base(movimentoManualRepository)
        {
            _MovimentoManualRepository = movimentoManualRepository;
        }

        public IEnumerable<MovimentoManual> SearchName(string name)
        {
            return _MovimentoManualRepository.SearchName(name);
        }
    }
}
