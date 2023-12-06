using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;

namespace Revisao.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class JogoMegaSenaController : ControllerBase
	{

		private readonly IRegistroJogoService _registroJogoService;
		private readonly IMapper _mapper;

		public JogoMegaSenaController(IRegistroJogoService registroJogoService, IMapper mapper)
		{
			_registroJogoService = registroJogoService;
			_mapper = mapper;
		}

		[HttpGet(Name = "ObterTodosOsJogos")]
		public IActionResult ObterTodosOsJogos()
		{
            return Ok(_registroJogoService.ObterTodosOsJogos());
        }


		[HttpPost(Name = "RegistrarJogo")]
		public IActionResult RegistrarJogo(NovoRegistroJogoViewModel registroJogoViewModel)
		{
            _registroJogoService.RegistrarJogo(registroJogoViewModel);

            return Ok();
        }
	}
}
