using System;
using System.Collections.Generic;
using WebStoreAPI.Domain;
using WebStoreAPI.Repository.Interfaces;

namespace WebStoreAPI.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly List<Produto> _data;

        public ProdutoRepository()
        {
            _data = new List<Produto>();
        }
        public List<Produto> List()
        {
            return _data;
        }

        public void Add(Produto produto)
        {
            _data.Add(produto);
        }
    }
}
