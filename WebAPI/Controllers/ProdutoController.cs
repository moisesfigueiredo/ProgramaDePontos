using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Service.Produtos;
using System.Collections.Generic;
using WebAPI.ViewModels;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : Controller
    {
        private readonly IProdutoService _produtoService;
        private readonly IMapper _mapper;

        public ProdutoController(IProdutoService produtoService, IMapper mapper)
        {
            _produtoService = produtoService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var objetos = _produtoService.Obter();

            var retorno = _mapper.Map<List<ProdutoViewModel>>(objetos);

            return Ok(retorno);
        }
    }
}
