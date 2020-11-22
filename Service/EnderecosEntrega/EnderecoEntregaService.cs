using Domain.EnderecosEntrega;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.EnderecosEntrega
{
    public class EnderecoEntregaService : IEnderecoEntregaService
    {
        private readonly IEnderecoEntregaRepositorio _repositorioEnderecoEntrega;

        public EnderecoEntregaService(IEnderecoEntregaRepositorio repositorioEnderecoEntrega)
        {
            _repositorioEnderecoEntrega = repositorioEnderecoEntrega;
        }

        public EnderecoEntrega GetById(int id)
        {
            return _repositorioEnderecoEntrega.ObterPorId(id);
        }

        public void Insert(EnderecoEntrega item)
        {
            _repositorioEnderecoEntrega.Gravar(item);
        }

    }
}
