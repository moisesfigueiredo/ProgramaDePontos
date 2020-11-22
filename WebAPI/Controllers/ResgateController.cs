using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Service.Resgates;
using System.Collections.Generic;
using WebAPI.ViewModels;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResgateController : Controller
    {
        private readonly IResgateService _resgateService;
        private readonly IMapper _mapper;

        public ResgateController(IResgateService resgateService, IMapper mapper)
        {
            _resgateService = resgateService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get(int id)
        {
            var objetos = _resgateService.Obter(id);

            var retorno = _mapper.Map<List<ResgateViewModel>>(objetos);

            return Ok(retorno);
        }
    }
}
