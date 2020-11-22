using Domain.EnderecosEntrega;
using Service.Bases;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.EnderecosEntrega
{
    public interface IEnderecoEntregaService: IService
    {
        void Insert(EnderecoEntrega item);
        EnderecoEntrega GetById(int id);
    }
}
