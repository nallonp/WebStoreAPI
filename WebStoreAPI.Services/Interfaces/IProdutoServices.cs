using System;
using System.Collections.Generic;
using System.Text;
using WebStoreAPI.Domain;

namespace WebStoreAPI.Services.Interfaces
{
    public interface IProdutoServices
    {
        List<Produto> List();

        void Add(Produto produto);
    }
}
