using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Negocio
{
    public interface IAppService
    {

        #region Avaliação

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

        #endregion

        #region Cadastro Profissional

        Task Insert(CadastroProfissionalProjecao aCadastroProfissional);
        Task Update(CadastroProfissionalProjecao aCadastroProfissional);

        #endregion

        #region Cadastro Usuário

        Task Insert(CadastroUsuarioProjecao aCadastroUsuario);
        Task Update(CadastroUsuarioProjecao aCadastroUsuario);

        #endregion

        #region Classe Profissional

        Task<IEnumerable<ClasseProfissionalDados>> TodasClasses();
        Task<ClasseProfissionalDados> Select(long aCodigo);
        Task<ClasseProfissionalDados> Select(string aConselho);
        Task Insert(ClasseProfissionalDados aClasseProfissional);
        Task Update(ClasseProfissionalDados aClasseProfissional);
        Task Delete(long aCodigo);

        #endregion

        #region Configuração

        #region Tela de Detalhe do Profissional

        Task<ConfiguracaoConsultaDados> RecuperarPrecoConsulta(long aCodigoProfissional);

        #endregion

        #endregion

        #region Consulta

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

        #endregion

        #region Email


        #region Serviço de E-Mail

        Task<CheckEmailDados> SelectCheckEMail(long aCodigoPaciente);
        Task InsertCheckEMail(long aCodigoConsulta);

        #endregion

        #endregion

        #region Endereço

        Task<IEnumerable<EstadoDados>> ListaEstados();
        Task<IEnumerable<MunicipioDados>> ListaMunicipios(long aCodigoEstado);

        #endregion

        #region Especialidade Profissional

        Task<IEnumerable<EspecialidadeDados>> TodasEspecialidades();
        Task<IEnumerable<EspecialidadeDados>> ListarEspecialidades(long? aCodigoClasseProfissional);

        #endregion

        #region Imagem

        Task<ImagensDados> RecuperarImagem(long aCodigoUsuario);
        Task AtualizarImagem(ImagensDados aImagem);

        #endregion

        #region Paciente

        Task<string> RecuperarNomePaciente(long aCodigoPaciente);
        Task<PacienteProjecao> RecuperarContatoPaciente(long aCodigoPaciente);

        #endregion

        #region Profissional

        Task<IEnumerable<ListaProfissionaisProjecao>> TodosProfissionais();
        Task<IEnumerable<ListaProfissionaisProjecao>> ListarProfissionais(string aNomeProfissional,
                                                                          long? aCodigoClasseProfissional,
                                                                          long? aCodigoEspecialidadeProfissional);
        Task<DetalheProfissionalProjecao> DetalheProfissional(long aCodigoProfissional);
        Task<string> RecuperarNomeProfissional(long aCodigoProfissional);

        #endregion

        #region Tratamento

        Task<IEnumerable<ListaTratamentoProjecao>> ListaDefinirTratamento(long aCodigoPaciente);
        Task<DetalheTratamentoProjecao> DetalheTratamento(long aCodigoConsulta);
        Task SalvarTratamento(TratamentoDados aAvaliacaoPaciente);
        Task<IEnumerable<TratamentoDados>> ListaTratamentosAviso(long aCodigoPaciente);

        #endregion

        #region Usuário Global

        Task<UsuarioGlobalDados> CheckUsuarioGlobal();
        Task InserirUsuarioGlobal(UsuarioGlobalDados aUsuarioGlobal);

        #endregion

        #region Usuário

        Task<LoginProjecao> ValidarLogin(UsuarioDados aUsuario);

        #endregion

    }
}