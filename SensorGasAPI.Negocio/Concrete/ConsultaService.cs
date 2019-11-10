using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SensorGasAPI.Negocio
{
    public class ConsultaService : IConsultaService
    {
        private readonly IConsultaRepositorio _repository;
        public ConsultaService(IConsultaRepositorio repository)
        {
            _repository = repository;
        }

        #region Tela de Configuração de Consulta

        public async Task<ConfiguracaoConsultaDados> RecuperarDadosConsulta(long aCodigoProfissional)
        {
            return await _repository.RecuperarDadosConsulta(aCodigoProfissional);
        }

        public async Task SalvarDadosConsulta(ConfiguracaoConsultaDados aDadosConsulta)
        {
            await _repository.SalvarDadosConsulta(aDadosConsulta);

        }

        #endregion

        #region Tela de Configuração de Horários

        public async Task<List<ConfiguracaoHorarioDados>> ListaDadosConfiguracaoHorario(long aCodigoProfissional)
        {
            return await _repository.ListaDadosConfiguracaoHorario(aCodigoProfissional);
        }

        public async Task<ConfiguracaoHorarioDados> RecuperarDadosConfiguracaoHorario(long aCodigoProfissional, long aCodigoDiaConsulta)
        {
            return await _repository.RecuperarDadosConfiguracaoHorario(aCodigoProfissional, aCodigoDiaConsulta);
        }

        public async Task SalvarDadosConfiguracaoHorario(ConfiguracaoHorarioDados aConfiguracaoHorarioDados)
        {
            await _repository.SalvarDadosConfiguracaoHorario(aConfiguracaoHorarioDados);
        }

        #endregion

        #region Telas de Agenda

        public async Task<ConsultaDados> VerificarExistenciaConsulta(ConsultaDados aConsultaDados)
        {
            return await _repository.VerificarExistenciaConsulta(aConsultaDados);
        }

        public async Task<List<ConsultaDados>> SelecionarConsultas(long aCodigoProfissional, string aDataSelecionadaCalendario)
        {
            return await _repository.SelecionarConsultas(aCodigoProfissional, aDataSelecionadaCalendario);
        }

        public async Task<List<ConsultaDados>> SelecionarConsultasPaciente(long aCodigoProfissional, long aCodigoPaciente, string aDataSelecionadaCalendario)
        {
            return await _repository.SelecionarConsultasPaciente(aCodigoProfissional, aCodigoPaciente, aDataSelecionadaCalendario);
        }

        public async Task<List<StatusDatasProjecao>> BuscarSituacaoDatasConsulta(long aCodigoProfissional, string aDataInicio, string aDataFim)
        {
            return await _repository.BuscarSituacaoDatasConsulta(aCodigoProfissional, aDataInicio, aDataFim);
        }

        public async Task AtualizarConsulta(ConsultaDados aConsulta)
        {
            await _repository.AtualizarConsulta(aConsulta);
        }

        #endregion

        #region Tela Minhas Consultas

        public async Task<List<ListaMinhasConsultasProjecao>> ListaMinhasConsultas(long aCodigoPaciente)
        {
            return await _repository.ListaMinhasConsultas(aCodigoPaciente);
        }

        public async Task<MinhasConsultasProjecao> DetalheMinhasConsultas(long aCodigoConsulta)
        {
            return await _repository.DetalheMinhasConsultas(aCodigoConsulta);
        }

        #endregion

        #region Tela Gerenciar Consultas

        public async Task<List<ListaGerenciarConsultasProjecao>> ListaGerenciarConsultas(long aCodigoProfissional)
        {
            return await _repository.ListaGerenciarConsultas(aCodigoProfissional);
        }

        public async Task<DetalheGerenciarConsultasProjecao> DetalheGerenciarConsultas(long aCodigoConsulta)
        {
            return await _repository.DetalheGerenciarConsultas(aCodigoConsulta);
        }

        #endregion

        #region Serviço de E-Mail

        public async Task<List<ConsultaServicoEmailProjecao>> RecuperarConsultaServicoEmail(long aCodigoPaciente)
        {
            return await _repository.RecuperarConsultaServicoEmail(aCodigoPaciente);
        }

        #endregion

    }

}