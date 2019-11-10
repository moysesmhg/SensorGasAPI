using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Negocio
{
    public interface IAvaliacaoRepositorio
    {
        #region Tela de Avaliação do Paciente

        Task<IEnumerable<ListaAvaliacoesPacienteProjecao>> ListaAvaliacoesPaciente(long aCodigoPaciente);
        Task<AvaliacaoPacienteProjecao> RecuperarDetalheAvaliacao(long aCodigoConsulta);
        Task SalvarAvaliacao(AvaliacaoDados aAvaliacaoPaciente);

        #endregion


        #region Tela de Reputação do Profissional

        Task<IEnumerable<ListaReputacaoProjecao>> ListaReputacao(long aCodigoProfissional);
        Task<ReputacaoProjecao> RecuperarDetalheReputacao(long aCodigoConsulta);

        #endregion

        #region Tela de Detalhe do Profissional

        Task<NumerosProfissionalProjecao> RecuperarNumerosProfissional(long aCodigoProfissional);

        #endregion
    }
}