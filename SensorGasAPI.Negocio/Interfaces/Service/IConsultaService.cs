using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Negocio
{
    public interface IConsultaService
    {

        #region Tela de Configuração de Consulta

        Task<ConfiguracaoConsultaDados> RecuperarDadosConsulta(long aCodigoProfissional);
        Task SalvarDadosConsulta(ConfiguracaoConsultaDados aDadosConsulta);

        #endregion

        #region Tela de Configuração de Horários

        Task<List<ConfiguracaoHorarioDados>> ListaDadosConfiguracaoHorario(long aCodigoProfissional);
        Task<ConfiguracaoHorarioDados> RecuperarDadosConfiguracaoHorario(long aCodigoProfissional, long aCodigoDiaConsulta);
        Task SalvarDadosConfiguracaoHorario(ConfiguracaoHorarioDados aConfiguracaoHorarioDados);

        #endregion

        #region Tela de Agenda
        Task<ConsultaDados> VerificarExistenciaConsulta(ConsultaDados aConsultaDados);
        Task<List<ConsultaDados>> SelecionarConsultas(long aCodigoProfissional, string aDataSelecionadaCalendario);
        Task<List<ConsultaDados>> SelecionarConsultasPaciente(long aCodigoProfissional, long aCodigoPaciente, string aDataSelecionadaCalendario);
        Task<List<StatusDatasProjecao>> BuscarSituacaoDatasConsulta(long aCodigoProfissional, string aDataInicio, string aDataFim);
        Task AtualizarConsulta(ConsultaDados aConsulta);

        #endregion

        #region Tela Minhas Consultas

        Task<List<ListaMinhasConsultasProjecao>> ListaMinhasConsultas(long aCodigoPaciente);
        Task<MinhasConsultasProjecao> DetalheMinhasConsultas(long aCodigoConsulta);

        #endregion

        #region Tela Gerenciar Consultas

        Task<List<ListaGerenciarConsultasProjecao>> ListaGerenciarConsultas(long aCodigoProfissional);
        Task<DetalheGerenciarConsultasProjecao> DetalheGerenciarConsultas(long aCodigoConsulta);

        #endregion

        #region Serviço de E-Mail

        Task<List<ConsultaServicoEmailProjecao>> RecuperarConsultaServicoEmail(long aCodigoPaciente);

        #endregion

    }

}