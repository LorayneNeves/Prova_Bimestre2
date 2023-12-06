using AutoMapper;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Services
{
	public class RegistroJogoService : IRegistroJogoService
	{
		private readonly IRegistroJogoRepository _registroJogoRepository;
		private readonly IMapper _mapper;

		public RegistroJogoService(IRegistroJogoRepository registroJogoRepository, IMapper mapper)
		{
			_registroJogoRepository = registroJogoRepository;
			_mapper = mapper;
		}

		public async Task RegistrarJogo(NovoRegistroJogoViewModel registroJogoViewModel)
		{
            var novoJogo = _mapper.Map<RegistroJogo>(registroJogoViewModel);
            RegistroJogo c = new RegistroJogo
            (
               registroJogoViewModel.primeiroNumero, registroJogoViewModel.segundoNumero, registroJogoViewModel.terceiroNumero, registroJogoViewModel.quartoNumero, registroJogoViewModel.quintoNumero, registroJogoViewModel.sextoNumero
            );
            await _registroJogoRepository.RegistrarJogo(novoJogo);
        }

		IEnumerable<RegistroJogoViewModel> IRegistroJogoService.ObterTodosOsJogos()
		{
            return _mapper.Map<IEnumerable<RegistroJogoViewModel>>(_registroJogoRepository.ObterTodosOsJogos());
        }
	}
}
