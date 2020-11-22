using Domain.Resgates;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositorios.Resgates
{
    public class ResgateRepositorio : RepositorioBase<Resgate>, IResgateRepositorio
    {
        public ResgateRepositorio(ProjetoDbContext context) : base(context)
        {

        }
    }
}