using Domain.Bases;
using Domain.EnderecosEntrega;
using Domain.Resgates;
using System.Collections.Generic;

namespace Domain.Usuarios
{
    public class Usuario : EntidadeBase
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Regiao { get; set; }
        public virtual ICollection<EnderecoEntrega> EnderecoEntrega { get; set; }
        public virtual ICollection<Resgate> Resgates { get; set; }
    }
}
