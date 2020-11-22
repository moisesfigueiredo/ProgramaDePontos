using Domain.Usuarios;

namespace Infra.Repositorios.Usuarios
{
    public class UsuarioRepositorio : RepositorioBase<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(ProjetoDbContext context) : base(context)
        {

        }
    }
}
