using DDDProject.Application.Interface;
using DDDProject.Domain.Entities;
using DDDProject.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace DDDProject.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _ProdutoAppService;

        public ProdutoAppService(IProdutoService produtoAppService) : base(produtoAppService)
        {
            _ProdutoAppService = produtoAppService;
        }

        public IEnumerable<Produto> SearchName(string name)
        {
            return _ProdutoAppService.SearchName(name);
        }
    }
}
