using Domain.SaldosPontos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Mapping;

namespace WebAPI.ViewModels
{
    public class SaldoPontoViewModel : IViewModelComId<SaldoPonto>
    {
        public DateTime DataPontos { get; set; }
        public int Id { get; set; }
        public virtual int UsuarioId { get; set; }
    }
}
