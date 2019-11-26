using System.Collections.Generic;
using System.Threading.Tasks;

namespace SensorGasAPI.Negocio
{
    public class AppService : IAppService
    {
        private readonly IAppRepositorio _repository;
        public AppService(IAppRepositorio repository)
        {
            _repository = repository;
        }

        #region Avaliação

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

        #endregion

        #region Cadastro Profissional

        public async Task Insert(CadastroProfissionalProjecao aCadastroProfissional)
        {
            await _repository.Insert(aCadastroProfissional);
        }

        public async Task Update(CadastroProfissionalProjecao aCadastroProfissional)
        {
            await _repository.Update(aCadastroProfissional);
        }

        #endregion

        #region Cadastro Usuário

        public async Task Insert(CadastroUsuarioProjecao aCadastroUsuario)
        {
            await _repository.Insert(aCadastroUsuario);
        }

        public async Task Update(CadastroUsuarioProjecao aCadastroUsuario)
        {
            await _repository.Update(aCadastroUsuario);
        }

        #endregion

        #region Classe Profissional

        public async Task<IEnumerable<ClasseProfissionalDados>> TodasClasses()
        {
            return await _repository.TodasClasses();
        }

        public async Task<ClasseProfissionalDados> Select(long aCodigo)
        {
            return await _repository.Select(aCodigo);
        }

        public async Task<ClasseProfissionalDados> Select(string aConselho)
        {
            return await _repository.Select(aConselho);
        }

        public async Task Insert(ClasseProfissionalDados aClasseProfissional)
        {
            await _repository.Insert(aClasseProfissional);
        }

        public async Task Update(ClasseProfissionalDados aClasseProfissional)
        {
            await _repository.Update(aClasseProfissional);
        }

        public async Task Delete(long aCodigo)
        {
            await _repository.Delete(aCodigo);
        }

        #endregion

        #region Configuração

        public async Task<ConfiguracaoConsultaDados> RecuperarPrecoConsulta(long aCodigoProfissional)
        {
            return await _repository.RecuperarPrecoConsulta(aCodigoProfissional);
        }

        #endregion

        #region Consulta        

        public async Task<ConfiguracaoConsultaDados> RecuperarDadosConsulta(long aCodigoProfissional)
        {
            return await _repository.RecuperarDadosConsulta(aCodigoProfissional);
        }

        public async Task SalvarDadosConsulta(ConfiguracaoConsultaDados aDadosConsulta)
        {
            await _repository.SalvarDadosConsulta(aDadosConsulta);

        }

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

        public async Task<List<ListaMinhasConsultasProjecao>> ListaMinhasConsultas(long aCodigoPaciente)
        {
            return await _repository.ListaMinhasConsultas(aCodigoPaciente);
        }

        public async Task<MinhasConsultasProjecao> DetalheMinhasConsultas(long aCodigoConsulta)
        {
            return await _repository.DetalheMinhasConsultas(aCodigoConsulta);
        }

        public async Task<List<ListaGerenciarConsultasProjecao>> ListaGerenciarConsultas(long aCodigoProfissional)
        {
            return await _repository.ListaGerenciarConsultas(aCodigoProfissional);
        }

        public async Task<DetalheGerenciarConsultasProjecao> DetalheGerenciarConsultas(long aCodigoConsulta)
        {
            return await _repository.DetalheGerenciarConsultas(aCodigoConsulta);
        }

        public async Task<List<ConsultaServicoEmailProjecao>> RecuperarConsultaServicoEmail(long aCodigoPaciente)
        {
            return await _repository.RecuperarConsultaServicoEmail(aCodigoPaciente);
        }

        #endregion

        #region EMail

        public async Task<CheckEmailDados> SelectCheckEMail(long aCodigoPaciente)
        {
            return await _repository.SelectCheckEMail(aCodigoPaciente);
        }

        public async Task InsertCheckEMail(long aCodigoConsulta)
        {
            await _repository.InsertCheckEMail(aCodigoConsulta);
        }

        #endregion

        #region Endereco

        public async Task<IEnumerable<EstadoDados>> ListaEstados()
        {
            return await _repository.ListaEstados();
        }

        public async Task<IEnumerable<MunicipioDados>> ListaMunicipios(long aCodigoEstado)
        {
            return await _repository.ListaMunicipios(aCodigoEstado);
        }

        #endregion

        #region Especialidade Profissional

        public async Task<IEnumerable<EspecialidadeDados>> TodasEspecialidades()
        {
            return await _repository.TodasEspecialidades();
        }

        public async Task<IEnumerable<EspecialidadeDados>> ListarEspecialidades(long? aCodigoClasseProfissional)
        {
            return await _repository.ListarEspecialidades(aCodigoClasseProfissional);
        }

        #endregion

        #region Imagem

        public async Task<ImagensDados> RecuperarImagem(long aCodigoProfissional)
        {
            return await _repository.RecuperarImagem(aCodigoProfissional);
        }

        public async Task AtualizarImagem(ImagensDados aAvaliacaoPaciente)
        {
            await _repository.AtualizarImagem(aAvaliacaoPaciente);
        }

        #endregion

        #region Paciente

        public async Task<string> RecuperarNomePaciente(long aCodigoPaciente)
        {
            return await _repository.RecuperarNomePaciente(aCodigoPaciente);
        }

        public async Task<PacienteProjecao> RecuperarContatoPaciente(long aCodigoPaciente)
        {
            return await _repository.RecuperarContatoPaciente(aCodigoPaciente);
        }

        #endregion

        #region Profissionais

        public async Task<IEnumerable<ListaProfissionaisProjecao>> TodosProfissionais()
        {
            return await _repository.TodosProfissionais();
        }

        public async Task<IEnumerable<ListaProfissionaisProjecao>> ListarProfissionais(string aNomeProfissional,
                                                                                       long? aCodigoClasseProfissional,
                                                                                       long? aCodigoEspecialidadeProfissional)
        {
            return await _repository.ListarProfissionais(aNomeProfissional,
                                                         aCodigoClasseProfissional,
                                                         aCodigoEspecialidadeProfissional);
        }

        public async Task<DetalheProfissionalProjecao> DetalheProfissional(long aCodigoProfissional)
        {
            return await _repository.DetalheProfissional(aCodigoProfissional);
        }

        public async Task<string> RecuperarNomeProfissional(long aCodigoProfissional)
        {
            return await _repository.RecuperarNomeProfissional(aCodigoProfissional);
        }

        #endregion

        #region Tratamento

        public async Task<IEnumerable<ListaTratamentoProjecao>> ListaDefinirTratamento(long aCodigoPaciente)
        {
            return await _repository.ListaDefinirTratamento(aCodigoPaciente);
        }

        public async Task<DetalheTratamentoProjecao> DetalheTratamento(long aCodigoConsulta)
        {
            return await _repository.DetalheTratamento(aCodigoConsulta);
        }

        public async Task SalvarTratamento(TratamentoDados aAvaliacaoPaciente)
        {
            await _repository.SalvarTratamento(aAvaliacaoPaciente);
        }

        public async Task<IEnumerable<TratamentoDados>> ListaTratamentosAviso(long aCodigoPaciente)
        {
            return await _repository.ListaTratamentosAviso(aCodigoPaciente);
        }

        #endregion

        #region Usuário Global

        public async Task<UsuarioGlobalDados> CheckUsuarioGlobal()
        {
            return await _repository.CheckUsuarioGlobal();
        }

        public async Task InserirUsuarioGlobal(UsuarioGlobalDados aUsuarioGlobal)
        {
            await _repository.InserirUsuarioGlobal(aUsuarioGlobal);
        }

        #endregion

        #region Usuário

        public async Task<LoginProjecao> ValidarLogin(UsuarioDados aUsuario)
        {
            return await _repository.ValidarLogin(aUsuario);
        }

        #endregion

    }
}