using Domain.Resgates;
using Service.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Resgates
{
    public interface IResgateService : IService
    {
        List<Resgate> Obter(int idUsuario);
    }
}
