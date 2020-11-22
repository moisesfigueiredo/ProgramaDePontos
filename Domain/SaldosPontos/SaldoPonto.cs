using Domain.Bases;
using Domain.Usuarios;
using System;

namespace Domain.SaldosPontos
{
    public class SaldoPonto : EntidadeBase
    {
        public DateTime DataPontos { get; set; }
        public int TotalPontos { get; set; }
        public virtual int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
