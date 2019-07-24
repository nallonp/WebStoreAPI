using System;
using System.Collections.Generic;
using System.Text;
using WebStoreAPI.Domain;

namespace WebStoreAPI.Repository.Interfaces
{
    public interface IProdutoRepository
    {
        List<Produto> List();

        void Add(Produto produto);
    }
}
