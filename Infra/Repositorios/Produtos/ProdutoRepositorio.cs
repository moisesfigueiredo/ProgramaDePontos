using Domain.Produtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositorios.Produtos
{
    public class ProdutoRepositorio : RepositorioBase<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(ProjetoDbContext context) : base(context)
        {

        }
    }
}