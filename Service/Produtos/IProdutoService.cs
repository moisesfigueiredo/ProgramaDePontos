using Domain.Produtos;
using Service.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Produtos
{
    public interface IProdutoService : IService
    {
        List<Produto> Obter();
    }
}
