using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Negocio
{
    public interface IAppRepositorio
    {

        #region Avaliação

        Task<IEnumerable<ListaAvaliacoesPacienteProjecao>> ListaAvaliacoesPaciente(long aCodigoPaciente);
        Task<AvaliacaoPacienteProjecao> RecuperarDetalheAvaliacao(long aCodigoConsulta);
        Task SalvarAvaliacao(AvaliacaoDados aAvaliacaoPaciente);
        Task<IEnumerable<ListaReputacaoProjecao>> ListaReputacao(long aCodigoProfissional);
        Task<ReputacaoProjecao> RecuperarDetalheReputacao(long aCodigoConsulta);
        Task<NumerosProfissionalProjecao> RecuperarNumerosProfissional(long aCodigoProfissional);

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

        Task<ConfiguracaoConsultaDados> RecuperarPrecoConsulta(long aCodigoProfissional);

        #endregion

        #region Consulta

        Task<ConfiguracaoConsultaDados> RecuperarDadosConsulta(long aCodigoProfissional);
        Task SalvarDadosConsulta(ConfiguracaoConsultaDados aDadosConsulta);
        Task<List<ConfiguracaoHorarioDados>> ListaDadosConfiguracaoHorario(long aCodigoProfissional);
        Task<ConfiguracaoHorarioDados> RecuperarDadosConfiguracaoHorario(long aCodigoProfissional, long aCodigoDiaConsulta);
        Task SalvarDadosConfiguracaoHorario(ConfiguracaoHorarioDados aConfiguracaoHorarioDados);
        Task<ConsultaDados> VerificarExistenciaConsulta(ConsultaDados aConsultaDados);
        Task<List<ConsultaDados>> SelecionarConsultas(long aCodigoProfissional, string aDataSelecionadaCalendario);
        Task<List<ConsultaDados>> SelecionarConsultasPaciente(long aCodigoProfissional, long aCodigoPaciente, string aDataSelecionadaCalendario);
        Task<List<StatusDatasProjecao>> BuscarSituacaoDatasConsulta(long aCodigoProfissional, string aDataInicio, string aDataFim);
        Task AtualizarConsulta(ConsultaDados aConsulta);
        Task<List<ListaMinhasConsultasProjecao>> ListaMinhasConsultas(long aCodigoPaciente);
        Task<MinhasConsultasProjecao> DetalheMinhasConsultas(long aCodigoConsulta);
        Task<List<ListaGerenciarConsultasProjecao>> ListaGerenciarConsultas(long aCodigoProfissional);
        Task<DetalheGerenciarConsultasProjecao> DetalheGerenciarConsultas(long aCodigoConsulta);
        Task<List<ConsultaServicoEmailProjecao>> RecuperarConsultaServicoEmail(long aCodigoPaciente);

        #endregion  

        #region Email

        Task<CheckEmailDados> SelectCheckEMail(long aCodigoPaciente);
        Task InsertCheckEMail(long aCodigoConsulta);

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