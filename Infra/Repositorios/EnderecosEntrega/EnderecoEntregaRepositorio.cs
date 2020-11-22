using Domain.EnderecosEntrega;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositorios.EnderecosEntrega
{
    public class EnderecoEntregaRepositorio : RepositorioBase<EnderecoEntrega>, IEnderecoEntregaRepositorio
    {
        public EnderecoEntregaRepositorio(ProjetoDbContext context) : base(context)
        {

        }
    }
}
