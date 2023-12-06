using AutoMapper;
using Revisao.Data.Providers.Collections;
using Revisao.Data.Providers.Interfaces;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.Repositories
{
    public class RegistroJogoRepository : IRegistroJogoRepository
    {
        private readonly IMongoRepository<RegistroJogoCollection> _registroJogoRepository;
        private readonly IMapper _mapper;
        #region - Construtores
        public RegistroJogoRepository(IMongoRepository<RegistroJogoCollection> jogoRepository, IMapper mapper)
        {
            _registroJogoRepository = jogoRepository;
            _mapper = mapper;
        }

        #endregion

        #region - Funções
        public async Task RegistrarJogo(RegistroJogo jogo)
        {
            await _registroJogoRepository.InsertOneAsync(_mapper.Map<RegistroJogoCollection>(jogo));
        }


        public IEnumerable<RegistroJogo> ObterTodosOsJogos()
        {
            var jogoList = _registroJogoRepository.FilterBy(filter => true);

            return _mapper.Map<IEnumerable<RegistroJogo>>(jogoList);
        }
 
        #endregion


    }
}
