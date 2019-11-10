using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Repositorio
{
    public class AvaliacaoRepositorio : IAvaliacaoRepositorio
    {

        #region Tela de Avaliação do Paciente

        public async Task<IEnumerable<ListaAvaliacoesPacienteProjecao>> ListaAvaliacoesPaciente(long aCodigoPaciente)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new AvaliacaoDAL().ListaAvaliacoesPaciente(aCodigoPaciente);
        }

        public async Task<AvaliacaoPacienteProjecao> RecuperarDetalheAvaliacao(long aCodigoConsulta)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new AvaliacaoDAL().RecuperarDetalheAvaliacao(aCodigoConsulta);
        }

        public async Task SalvarAvaliacao(AvaliacaoDados aAvaliacaoPaciente)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            new AvaliacaoDAL().SalvarAvaliacao(aAvaliacaoPaciente);
        }

        #endregion

        #region Tela de Reputação do Profissional

        public async Task<IEnumerable<ListaReputacaoProjecao>> ListaReputacao(long aCodigoProfissional)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new AvaliacaoDAL().ListaReputacao(aCodigoProfissional);
        }

        public async Task<ReputacaoProjecao> RecuperarDetalheReputacao(long aCodigoConsulta)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new AvaliacaoDAL().RecuperarDetalheReputacao(aCodigoConsulta);
        }

        #endregion

        #region Tela de Detalhe do Profissional

        public async Task<NumerosProfissionalProjecao> RecuperarNumerosProfissional(long aCodigoProfissional)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new AvaliacaoDAL().RecuperarNumerosProfissional(aCodigoProfissional);
        }

        #endregion

    }
}