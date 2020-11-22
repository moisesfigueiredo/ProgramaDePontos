using Domain.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Produtos
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepositorio _repositorioProduto;

        public ProdutoService(IProdutoRepositorio repositorioProduto)
        {
            _repositorioProduto = repositorioProduto;
        }

        public List<Produto> Obter()
        {
            var resultado = _repositorioProduto.Obter(p => p.Disponivel).ToList();

            return resultado;
        }
    }
}
