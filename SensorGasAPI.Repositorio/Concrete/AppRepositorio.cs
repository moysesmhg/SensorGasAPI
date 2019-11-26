using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Repositorio
{
    public class AppRepositorio : IAppRepositorio
    {

        #region Avaliação        

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

        public async Task<NumerosProfissionalProjecao> RecuperarNumerosProfissional(long aCodigoProfissional)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new AvaliacaoDAL().RecuperarNumerosProfissional(aCodigoProfissional);
        }

        #endregion

        #region Cadastro Profissional

        public async Task Insert(CadastroProfissionalProjecao aCadastroProfissional)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            if (aCadastroProfissional != null)
                new CadastroProfissionalDAL().InsertCadastro(aCadastroProfissional);
            else { /* TODO: Tratamento de exceção */ }
        }

        public async Task Update(CadastroProfissionalProjecao aCadastroProfissional)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            if (aCadastroProfissional != null)
                new CadastroProfissionalDAL().UpdateCadastro(aCadastroProfissional);
            else { /* TODO: Tratamento de exceção */ }
        }

        #endregion

        #region Cadastro Usuário

        public async Task Insert(CadastroUsuarioProjecao aCadastroUsuario)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            if (aCadastroUsuario != null)
                new CadastroUsuarioDAL().InsertCadastro(aCadastroUsuario);
            else { /* TODO: Tratamento de exceção */ }
        }

        public async Task Update(CadastroUsuarioProjecao aCadastroUsuario)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            if (aCadastroUsuario != null)
                new CadastroUsuarioDAL().UpdateCadastro(aCadastroUsuario);
            else { /* TODO: Tratamento de exceção */ }
        }

        #endregion

        #region Classe Profissional

        public async Task<IEnumerable<ClasseProfissionalDados>> TodasClasses()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ClasseProfissionalDAL().GetClasses();
        }

        public async Task<ClasseProfissionalDados> Select(long aCodigo)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ClasseProfissionalDAL().GetClasse(aCodigo);
        }

        public async Task<ClasseProfissionalDados> Select(string aConselho)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ClasseProfissionalDAL().GetClasse(aConselho);
        }

        public async Task Insert(ClasseProfissionalDados aClasseProfissional)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            if (aClasseProfissional != null)
                new ClasseProfissionalDAL().InsertClasse(aClasseProfissional);
            else { /* TODO: Tratamento de exceção */ }
        }

        public async Task Update(ClasseProfissionalDados aClasseProfissional)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            if (aClasseProfissional != null)
                new ClasseProfissionalDAL().UpdateClasse(aClasseProfissional);
            else { /* TODO: Tratamento de exceção */ }
        }

        public async Task Delete(long aCodigo)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            new ClasseProfissionalDAL().DeleteClasse(aCodigo);
        }

        #endregion

        #region Configuração

        public async Task<ConfiguracaoConsultaDados> RecuperarPrecoConsulta(long aCodigoProfissional)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ConfiguracaoDAL().RecuperarPrecoConsulta(aCodigoProfissional);
        }

        #endregion

        #region Consulta       

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

        public async Task<List<ConsultaServicoEmailProjecao>> RecuperarConsultaServicoEmail(long aCodigoPaciente)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ConsultaDAL().RecuperarConsultaServicoEmail(aCodigoPaciente);
        }

        #endregion

        #region EMail

        public async Task<CheckEmailDados> SelectCheckEMail(long aCodigoPaciente)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new CheckEMailDAL().SelectCheckEMail(aCodigoPaciente);
        }

        public async Task InsertCheckEMail(long aCodigoConsulta)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            new CheckEMailDAL().InsertCheckEMail(aCodigoConsulta);
        }

        #endregion

        #region Endereço

        public async Task<IEnumerable<EstadoDados>> ListaEstados()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new EstadoDAL().ListaEstados();
        }
        public async Task<IEnumerable<MunicipioDados>> ListaMunicipios(long aCodigoEstado)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new MunicipioDAL().ListaMunicipios(aCodigoEstado);
        }

        #endregion

        #region Especialidade Profissional

        public async Task<IEnumerable<EspecialidadeDados>> TodasEspecialidades()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new EspecialidadeProfissionalDAL().ListarTodasEspecialidades();
        }

        public async Task<IEnumerable<EspecialidadeDados>> ListarEspecialidades(long? aCodigoClasseProfissional)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new EspecialidadeProfissionalDAL().ListarEspecialidades(aCodigoClasseProfissional);
        }

        #endregion

        #region Imagem

        public async Task<ImagensDados> RecuperarImagem(long aCodigoUsuario)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ImagensDAL().RecuperarImagem(aCodigoUsuario);
        }

        public async Task AtualizarImagem(ImagensDados aImagem)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            new ImagensDAL().AtualizarImagem(aImagem);
        }

        #endregion

        #region Paciente

        public async Task<string> RecuperarNomePaciente(long aCodigoPaciente)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new PacienteDAL().RecuperarNomePaciente(aCodigoPaciente);
        }

        public async Task<PacienteProjecao> RecuperarContatoPaciente(long aCodigoPaciente)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new PacienteDAL().RecuperarContatoPaciente(aCodigoPaciente);
        }

        #endregion

        #region Profissional

        public async Task<IEnumerable<ListaProfissionaisProjecao>> TodosProfissionais()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ProfissionaisDAL().ListarTodosProfissionais();
        }

        public async Task<IEnumerable<ListaProfissionaisProjecao>> ListarProfissionais(string aNomeProfissional,
                                                                                       long? aCodigoClasseProfissional,
                                                                                       long? aCodigoEspecialidadeProfissional)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ProfissionaisDAL().ListarProfissionais(aNomeProfissional,
                                                              aCodigoClasseProfissional,
                                                              aCodigoEspecialidadeProfissional);
        }

        public async Task<DetalheProfissionalProjecao> DetalheProfissional(long aCodigoProfissional)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ProfissionaisDAL().DetalheProfissional(aCodigoProfissional);
        }

        public async Task<string> RecuperarNomeProfissional(long aCodigoProfissional)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new ProfissionaisDAL().RecuperarNomeProfissional(aCodigoProfissional);
        }

        #endregion

        #region Tratamento

        public async Task<IEnumerable<ListaTratamentoProjecao>> ListaDefinirTratamento(long aCodigoPaciente)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new TratamentoDAL().ListaDefinirTratamento(aCodigoPaciente);
        }

        public async Task<DetalheTratamentoProjecao> DetalheTratamento(long aCodigoConsulta)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new TratamentoDAL().DetalheTratamento(aCodigoConsulta);
        }

        public async Task SalvarTratamento(TratamentoDados aAvaliacaoPaciente)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            new TratamentoDAL().SalvarTratamento(aAvaliacaoPaciente);
        }

        public async Task<IEnumerable<TratamentoDados>> ListaTratamentosAviso(long aCodigoPaciente)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new TratamentoDAL().ListaTratamentosAviso(aCodigoPaciente);
        }

        #endregion

        #region Usuário Global

        public async Task<UsuarioGlobalDados> CheckUsuarioGlobal()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new UsuarioGlobalDAL().CheckUsuarioGlobal();
        }

        public async Task InserirUsuarioGlobal(UsuarioGlobalDados aUsuarioGlobal)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            new UsuarioGlobalDAL().InserirUsuarioGlobal(aUsuarioGlobal);
        }

        #endregion

        #region Usuário

        public async Task<LoginProjecao> ValidarLogin(UsuarioDados aUsuario)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(0));
            return new UsuarioDAL().RecuperarLogin(aUsuario);
        }

        #endregion

    }
}