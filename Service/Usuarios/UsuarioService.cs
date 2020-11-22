using Domain.Usuarios;
using System.Collections.Generic;

namespace Service.Usuarios
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepositorio _repositorioUsuario;

        public UsuarioService(IUsuarioRepositorio repositorioUsuario)
        {
            _repositorioUsuario = repositorioUsuario;
        }

        public List<Usuario> GetAll()
        {
            return _repositorioUsuario.ObterTodos();
        }

        public Usuario GetById(int id)
        {
            return _repositorioUsuario.ObterPorId(id);
        }

        public void Insert(Usuario item)
        {
            _repositorioUsuario.Gravar(item);
        }
    }
}