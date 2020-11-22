using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Service.SaldosPontosService;
using System.Collections.Generic;
using WebAPI.ViewModels;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaldoPontoController : Controller
    {
        private readonly ISaldoPontoService _saldoPontoService;
        private readonly IMapper _mapper;

        public SaldoPontoController(ISaldoPontoService saldoPontoService, IMapper mapper)
        {
            _saldoPontoService = saldoPontoService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var objeto = _saldoPontoService.Obter(id);

            if (objeto == null)
                return NotFound();

            var retorno = _mapper.Map<List<SaldoPontoViewModel>>(objeto);

            return Ok(retorno);
        }
    }
}
