using Domain.Bases;
using Domain.Usuarios;

namespace Domain.EnderecosEntrega
{
    public class EnderecoEntrega : EntidadeBase
    {
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public int Numero { get; set; }
        public string CEP { get; set; }
        public virtual int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
