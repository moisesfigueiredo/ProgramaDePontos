using Domain.Bases;
using System;

namespace Domain.Produtos
{
    public class Produto : EntidadeBase
    {
        public string NomeProduto { get; set; }
        public string TipoProduto { get; set; }
        public int PontosNecessarioResgate { get; set; }
        public int QuantidadeDisponivel { get; set; }
        public bool Disponivel { get; set; }
        public DateTime ResgateValidoAte { get; set; }
    }
}
