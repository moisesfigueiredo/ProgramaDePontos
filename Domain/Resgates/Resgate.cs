using Domain.Bases;
using Domain.Produtos;
using Domain.Usuarios;
using System;

namespace Domain.Resgates
{
    public class Resgate : EntidadeBase
    {
        public DateTime DataResgate { get; set; }
        public bool StatusEntrega { get; set; }
        public string EnderecoEntrega { get; set; }
        public string ProdutoEntrega { get; set; }
        public virtual int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
