using Domain.SaldosPontos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repositorios.SaldosPontos
{
    public class SaldoPontoRepositorio : RepositorioBase<SaldoPonto>, ISaldoPontoRepositorio
    {
        public SaldoPontoRepositorio(ProjetoDbContext context) : base(context)
        {

        }
    }
}
