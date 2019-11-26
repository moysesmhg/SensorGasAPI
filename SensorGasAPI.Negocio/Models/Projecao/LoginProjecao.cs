

namespace SensorGasAPI.Negocio
{
    public class LoginProjecao : ProjecaoBase
    {
        #region Construtores

        public LoginProjecao() { }

        #endregion

        #region Atributos

        private ImagensDados _imagens;
        private UsuarioDados _usuario;
        private PessoaDados _pessoa;
        private PacienteDados _paciente;
        private ProfissionalDados _profissional;
        private DadosAdicionaisDados _dados;

        #endregion

        #region Propriedades

        public ImagensDados Imagens
        {
            get { return _imagens; }
            set { _imagens = value; OnPropertyChanged(); }
        }

        public UsuarioDados Usuario
        {
            get { return _usuario; }
            set { _usuario = value; OnPropertyChanged(); }
        }

        public PessoaDados Pessoa
        {
            get { return _pessoa; }
            set { _pessoa = value; OnPropertyChanged(); }
        }

        public PacienteDados Paciente
        {
            get { return _paciente; }
            set { _paciente = value; OnPropertyChanged(); }
        }

        public ProfissionalDados Profissional
        {
            get { return _profissional; }
            set { _profissional = value; OnPropertyChanged(); }
        }

        public DadosAdicionaisDados DadosAdicionais
        {
            get { return _dados; }
            set { _dados = value; OnPropertyChanged(); }
        }

        #endregion

    }
}
