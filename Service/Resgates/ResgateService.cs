using Domain.Resgates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Resgates
{
    public class ResgateService : IResgateService
    {
        private readonly IResgateRepositorio _repositorioResgate;

        public ResgateService(IResgateRepositorio repositorioResgate)
        {
            _repositorioResgate = repositorioResgate;
        }
        public List<Resgate> Obter(int idUsuario)
        {
            var resultado = _repositorioResgate.Obter(r => r.UsuarioId == idUsuario).ToList();

            return resultado;
        }
    }
}
