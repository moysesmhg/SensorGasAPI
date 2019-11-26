using SimpleInjector;
using SensorGasAPI.Negocio;
using SensorGasAPI.Repositorio;

namespace SensorGasAPI.IOC
{
    public static class SimpleInjectorContainer
    {
        public static void RegisterServices(Container container)
        {

            container.Register<IAppService, AppService>(Lifestyle.Scoped);
            container.Register<IAppRepositorio, AppRepositorio>(Lifestyle.Scoped);

            //// Avaliação
            //container.Register<IAvaliacaoService, AvaliacaoService>(Lifestyle.Scoped);
            //container.Register<IAvaliacaoRepositorio, AvaliacaoRepositorio>(Lifestyle.Scoped);

            //// Cadastro de profissionais
            //container.Register<ICadastroProfissionalService, CadastroProfissionalService>(Lifestyle.Scoped);
            //container.Register<ICadastroProfissionalRepositorio, CadastroProfissionalRepositorio>(Lifestyle.Scoped);

            //// Cadastro de pacientes (usuários)
            //container.Register<ICadastroUsuarioService, CadastroUsuarioService>(Lifestyle.Scoped);
            //container.Register<ICadastroUsuarioRepositorio, CadastroUsuarioRepositorio>(Lifestyle.Scoped);

            //// Classe de profissionais
            //container.Register<IClasseProfissionalService, ClasseProfissionalService>(Lifestyle.Scoped);
            //container.Register<IClasseProfissionalRepositorio, ClasseProfissionalRepositorio>(Lifestyle.Scoped);

            //// Configuração
            //container.Register<IConfiguracaoService, ConfiguracaoService>(Lifestyle.Scoped);
            //container.Register<IConfiguracaoRepositorio, ConfiguracaoRepositorio>(Lifestyle.Scoped);

            //// Consulta
            //container.Register<IConsultaService, ConsultaService>(Lifestyle.Scoped);
            //container.Register<IConsultaRepositorio, ConsultaRepositorio>(Lifestyle.Scoped);

            //// E-Mail
            //container.Register<IEmailService, EmailService>(Lifestyle.Scoped);
            //container.Register<IEmailRepositorio, EmailRepositorio>(Lifestyle.Scoped);

            //// Especialidade de profissionais
            //container.Register<IEspecialidadeProfissionalService, EspecialidadeProfissionalService>(Lifestyle.Scoped);
            //container.Register<IEspecialidadeProfissionalRepositorio, EspecialidadeProfissionalRepositorio>(Lifestyle.Scoped);

            //// Paciente
            //container.Register<IPacienteService, PacienteService>(Lifestyle.Scoped);
            //container.Register<IPacienteRepositorio, PacienteRepositorio>(Lifestyle.Scoped);

            //// Profissionais
            //container.Register<IProfissionaisService, ProfissionaisService>(Lifestyle.Scoped);
            //container.Register<IProfissionaisRepositorio, ProfissionaisRepositorio>(Lifestyle.Scoped);

            //// Usuário Global
            //container.Register<IUsuarioGlobalService, UsuarioGlobalService>(Lifestyle.Scoped);
            //container.Register<IUsuarioGlobalRepositorio, UsuarioGlobalRepositorio>(Lifestyle.Scoped);

            //// Usuários - Validação de Login
            //container.Register<IUsuarioService, UsuarioService>(Lifestyle.Scoped);
            //container.Register<IUsuarioRepositorio, UsuarioRepositorio>(Lifestyle.Scoped);

            //// Imagem
            //container.Register<IImagemService, ImagemService>(Lifestyle.Scoped);
            //container.Register<IImagemRepositorio, ImagemRepositorio>(Lifestyle.Scoped);

            //// Tratamento
            //container.Register<ITratamentoService, TratamentoService>(Lifestyle.Scoped);
            //container.Register<ITratamentoRepositorio, TratamentoRepositorio>(Lifestyle.Scoped);

            //// Endereço
            //container.Register<IEnderecoService, EnderecoService>(Lifestyle.Scoped);
            //container.Register<IEnderecoRepositorio, EnderecoRepositorio>(Lifestyle.Scoped);

            //container.Verify();
        }

    }

}
