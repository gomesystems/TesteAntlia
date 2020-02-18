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
    public class MovimentoManualAppService : AppServiceBase<MovimentoManual>, IMovimentoManualAppService
    {
        private readonly IMovimentoManualService _movimentoManualService;

        public MovimentoManualAppService(IMovimentoManualService movimentoManualService) : base(movimentoManualService)
        {
            _movimentoManualService = movimentoManualService;
        }

        public IEnumerable<MovimentoManual> SearchName(string name)
        {
            return _movimentoManualService.SearchName(name);
        }
    }
}
