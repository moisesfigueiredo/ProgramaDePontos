using Domain.SaldosPontos;
using Service.Bases;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Service.SaldosPontosService
{
    public interface ISaldoPontoService : IService
    {
        List<SaldoPonto> Obter(int idUsuario);
    }
}
