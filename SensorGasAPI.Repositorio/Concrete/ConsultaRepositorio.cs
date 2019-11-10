using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Repositorio
{
    public class ConsultaRepositorio : IConsultaRepositorio
    {

        #region Tela de Configuração de Consulta

        public async Task<ConfiguracaoConsultaDados> RecuperarDadosConsulta(long aCodigoProfissional)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ConsultaDAL().RecuperarDadosConsulta(aCodigoProfissional);
        }

        // TODO: mudar para Task?
        public async Task SalvarDadosConsulta(ConfiguracaoConsultaDados aDadosConsulta)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            new ConsultaDAL().SalvarDadosConsulta(aDadosConsulta);

        }

        #endregion

        #region Tela de Configuração de Horários

        public async Task<List<ConfiguracaoHorarioDados>> ListaDadosConfiguracaoHorario(long aCodigoProfissional)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ConsultaDAL().ListaDadosConfiguracaoHorario(aCodigoProfissional);
        }

        public async Task<ConfiguracaoHorarioDados> RecuperarDadosConfiguracaoHorario(long aCodigoProfissional, long aCodigoDiaConsulta)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ConsultaDAL().RecuperarDadosConfiguracaoHorario(aCodigoProfissional, aCodigoDiaConsulta);
        }

        // TODO: mudar para Task?
        public async Task SalvarDadosConfiguracaoHorario(ConfiguracaoHorarioDados aConfiguracaoHorarioDados)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            new ConsultaDAL().SalvarDadosConfiguracaoHorario(aConfiguracaoHorarioDados);

        }

        #endregion

        #region Telas de Agenda

        public async Task<ConsultaDados> VerificarExistenciaConsulta(ConsultaDados aConsultaDados)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ConsultaDAL().VerificarExistenciaConsulta(aConsultaDados);
        }

        public async Task<List<ConsultaDados>> SelecionarConsultas(long aCodigoProfissional, string aDataSelecionadaCalendario)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ConsultaDAL().SelecionarConsultas(aCodigoProfissional, aDataSelecionadaCalendario);
        }

        public async Task<List<ConsultaDados>> SelecionarConsultasPaciente(long aCodigoProfissional, long aCodigoPaciente, string aDataSelecionadaCalendario)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ConsultaDAL().SelecionarConsultasPaciente(aCodigoProfissional, aCodigoPaciente, aDataSelecionadaCalendario);
        }

        public async Task<List<StatusDatasProjecao>> BuscarSituacaoDatasConsulta(long aCodigoProfissional, string aDataInicio, string aDataFim)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ConsultaDAL().BuscarSituacaoDatasConsulta(aCodigoProfissional, aDataInicio, aDataFim);
        }

        public async Task AtualizarConsulta(ConsultaDados aConsulta)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            new ConsultaDAL().AtualizarConsulta(ref aConsulta);
        }

        #endregion

        #region Tela Minhas Consultas

        public async Task<List<ListaMinhasConsultasProjecao>> ListaMinhasConsultas(long aCodigoPaciente)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ConsultaDAL().ListaMinhasConsultas(aCodigoPaciente);
        }

        public async Task<MinhasConsultasProjecao> DetalheMinhasConsultas(long aCodigoConsulta)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ConsultaDAL().DetalheMinhasConsultas(aCodigoConsulta);
        }

        #endregion

        #region Tela Gerenciar Consultas

        public async Task<List<ListaGerenciarConsultasProjecao>> ListaGerenciarConsultas(long aCodigoProfissional)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ConsultaDAL().ListaGerenciarConsultas(aCodigoProfissional);
        }

        public async Task<DetalheGerenciarConsultasProjecao> DetalheGerenciarConsultas(long aCodigoConsulta)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ConsultaDAL().DetalheGerenciarConsultas(aCodigoConsulta);
        }

        #endregion

        #region Serviço de E-Mail

        public async Task<List<ConsultaServicoEmailProjecao>> RecuperarConsultaServicoEmail(long aCodigoPaciente)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ConsultaDAL().RecuperarConsultaServicoEmail(aCodigoPaciente);
        }

        #endregion

    }
}