using Domain.EnderecosEntrega;
using Domain.Resgates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Mapping;

namespace WebAPI.ViewModels
{
    public class EnderecoEntregaViewModel : IViewModelComId<EnderecoEntrega>
    {
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public int Numero { get; set; }
        public string CEP { get; set; }
        public  int UsuarioId { get; set; }
        public int Id { get; set; }
    }
}
