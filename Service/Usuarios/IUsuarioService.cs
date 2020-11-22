using Domain.Usuarios;
using Service.Bases;
using System.Collections.Generic;

namespace Service.Usuarios
{
    public interface IUsuarioService : IService
    {
        void Insert(Usuario item);
        Usuario GetById(int id);
        List<Usuario> GetAll();
    }
}