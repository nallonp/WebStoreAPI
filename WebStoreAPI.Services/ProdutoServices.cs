using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using WebStoreAPI.Business.Interfaces;
using WebStoreAPI.Domain;
using WebStoreAPI.Repository;
using WebStoreAPI.Services.Interfaces;

namespace WebStoreAPI.Services
{
    public sealed class ProdutoServices : IProdutoServices
    {
        private readonly IProdutoBusiness _produtoBusiness;

        public ProdutoServices(IProdutoBusiness produtoBusiness)
        {
            _produtoBusiness = produtoBusiness;
        }
        public List<Produto> List()
        {
            return _produtoBusiness.List();
        }

        public void Add(Produto produto)
        {
            _produtoBusiness.Add(produto);
        }
    }
}
