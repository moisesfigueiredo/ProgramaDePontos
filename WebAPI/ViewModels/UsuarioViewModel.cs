using Domain.Usuarios;
using WebAPI.Mapping;

namespace WebAPI.ViewModels
{
    public class UsuarioViewModel : IViewModelComId<Usuario>
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
    }
}
