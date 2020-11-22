using Domain.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Mapping;

namespace WebAPI.ViewModels
{
    public class ProdutoViewModel : IViewModelComId<Produto>
    {
        public int Id { get; set; }
        public string NomeProduto { get; set; }
        public string TipoProduto { get; set; }
        public int PontosNecessarioResgate { get; set; }
        public bool Disponivel { get; set; }
        public DateTime ResgateValidoAte { get; set; }
    }
}