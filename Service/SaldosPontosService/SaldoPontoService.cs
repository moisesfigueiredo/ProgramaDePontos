using Domain.SaldosPontos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Service.SaldosPontosService
{
    public class SaldoPontoService : ISaldoPontoService
    {
        private readonly ISaldoPontoRepositorio _repositorioSaldoPonto;

        public SaldoPontoService(ISaldoPontoRepositorio repositorioSaldoPonto)
        {
            _repositorioSaldoPonto = repositorioSaldoPonto;
        }

        public List<SaldoPonto> Obter(int idUsuario)
        {
            var resultado = _repositorioSaldoPonto.Obter(u => u.UsuarioId == idUsuario).ToList();

            return resultado;
        }
    }
}
