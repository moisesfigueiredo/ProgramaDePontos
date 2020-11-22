using AutoMapper;
using Domain.EnderecosEntrega;
using Microsoft.AspNetCore.Mvc;
using Service.EnderecosEntrega;
using System.Collections.Generic;
using WebAPI.ViewModels;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoEntregaController : ControllerBase
    {
        private readonly IEnderecoEntregaService _enderecoEntregaService;
        private readonly IMapper _mapper;

        public EnderecoEntregaController(IEnderecoEntregaService enderecoEntregaService, IMapper mapper)
        {
            _enderecoEntregaService = enderecoEntregaService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var objeto = _enderecoEntregaService.GetById(id);

            if (objeto == null)
                return NotFound();

            var retorno = _mapper.Map<List<EnderecoEntregaViewModel>>(objeto);

            return Ok(retorno);
        }
        [HttpPost]
        public IActionResult Post([FromBody] EnderecoEntregaViewModel model)
        {
            var objeto = _mapper.Map<EnderecoEntrega>(model);

            _enderecoEntregaService.Insert(objeto);

            var retorno = _mapper.Map<EnderecoEntregaViewModel>(objeto);

            return CreatedAtAction("Get", new { id = retorno.Id }, retorno);
        }
    }
}
