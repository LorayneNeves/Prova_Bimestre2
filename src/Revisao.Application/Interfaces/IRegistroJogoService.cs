using Revisao.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Interfaces
{
	public interface IRegistroJogoService
	{
		public Task RegistrarJogo(NovoRegistroJogoViewModel registroJogoViewModel);

		IEnumerable<RegistroJogoViewModel> ObterTodosOsJogos();
	}
}
