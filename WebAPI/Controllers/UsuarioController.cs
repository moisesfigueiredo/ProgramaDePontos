using AutoMapper;
using Domain.Usuarios;
using Microsoft.AspNetCore.Mvc;
using Service.Usuarios;
using System.Collections.Generic;
using WebAPI.ViewModels;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;
        private readonly IMapper _mapper;

        public UsuarioController(IUsuarioService usuarioService, IMapper mapper)
        {
            _usuarioService = usuarioService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var objetos = _usuarioService.GetAll();

            var retorno = _mapper.Map<List<UsuarioViewModel>>(objetos);

            return Ok(retorno);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var objeto = _usuarioService.GetById(id);

            if (objeto == null)
                return NotFound();

            var retorno = _mapper.Map<List<UsuarioViewModel>>(objeto);

            return Ok(retorno);
        }

        [HttpPost]
        public IActionResult Post([FromBody] UsuarioViewModel model)
        {
            var objeto = _mapper.Map<Usuario>(model);

            _usuarioService.Insert(objeto);

            var retorno = _mapper.Map<UsuarioViewModel>(objeto);

            return CreatedAtAction("Get", new { id = retorno.Id }, retorno);
        }
    }
}
