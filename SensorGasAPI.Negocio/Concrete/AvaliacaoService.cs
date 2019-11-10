using System.Collections.Generic;
using System.Threading.Tasks;

namespace SensorGasAPI.Negocio
{
    public class AvaliacaoService : IAvaliacaoService
    {
        private readonly IAvaliacaoRepositorio _repository;
        public AvaliacaoService(IAvaliacaoRepositorio repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<ListaAvaliacoesPacienteProjecao>> ListaAvaliacoesPaciente(long aCodigoPaciente)
        {
            return await _repository.ListaAvaliacoesPaciente(aCodigoPaciente);
        }

        public async Task<IEnumerable<ListaReputacaoProjecao>> ListaReputacao(long aCodigoProfissional)
        {
            return await _repository.ListaReputacao(aCodigoProfissional);
        }

        public async Task<AvaliacaoPacienteProjecao> RecuperarDetalheAvaliacao(long aCodigoConsulta)
        {
            return await _repository.RecuperarDetalheAvaliacao(aCodigoConsulta);
        }

        public async Task<ReputacaoProjecao> RecuperarDetalheReputacao(long aCodigoConsulta)
        {
           return await _repository.RecuperarDetalheReputacao(aCodigoConsulta);
        }

        public async Task<NumerosProfissionalProjecao> RecuperarNumerosProfissional(long aCodigoProfissional)
        {
            return await _repository.RecuperarNumerosProfissional(aCodigoProfissional);
        }

        public async Task SalvarAvaliacao(AvaliacaoDados aAvaliacaoPaciente)
        {
            await _repository.SalvarAvaliacao(aAvaliacaoPaciente);
        }
    }
}