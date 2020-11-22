using Domain.Resgates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Mapping;

namespace WebAPI.ViewModels
{
    public class ResgateViewModel : IViewModelComId<Resgate>
    {
        public int Id { get; set; }
        public DateTime DataResgate { get; set; }
        public bool StatusEntrega { get; set; }
        public string EnderecoEntrega { get; set; }
        public string ProdutoEntrega { get; set; }
    }
}