using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using WebStoreAPI.Domain;
using WebStoreAPI.Repository;

namespace WebStoreAPI.Services
{
    public class ProdutoServices
    {
        public List<Produto> List()
        {
            return ProdutoRepository.Data;
        }

        public void Add(Produto produto)
        {
            ProdutoRepository.Data.Add(produto);
        }
    }
}
