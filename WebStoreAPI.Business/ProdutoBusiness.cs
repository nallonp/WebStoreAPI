using System;
using System.Collections.Generic;
using WebStoreAPI.Business.Interfaces;
using WebStoreAPI.Domain;
using WebStoreAPI.Repository.Interfaces;

namespace WebStoreAPI.Business
{
    public class ProdutoBusiness : IProdutoBusiness
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoBusiness(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public List<Produto> List()
        {
            return _produtoRepository.List();
        }

        public void Add(Produto produto)
        {
            _produtoRepository.Add(produto);
        }
    }
}
