

namespace SensorGasAPI.Negocio
{
    public class CadastroProfissionalProjecao : BaseProjecao
    {
        #region Construtores

        public CadastroProfissionalProjecao() { }

        #endregion

        #region Atributos

        private ImagensDados _imagens;
        private UsuarioDados _usuario;
        private PessoaDados _pessoa;
        private PacienteDados _paciente;
        private ProfissionalDados _profissional;
        private EnderecoDados _endereco;
        private DadosAdicionaisDados _dadosAdicionais;
        private ClasseProfissionalDados _classeProfissional;
        private RelacaoProfissionalClasseDados _relacaoProfissionalClasse;
        private RelacaoClasseEspecialidadeDados _relacaoClasseEspecialidade;

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

        public EnderecoDados Endereco
        {
            get { return _endereco; }
            set { _endereco = value; OnPropertyChanged(); }
        }

        public DadosAdicionaisDados DadosAdicionais
        {
            get { return _dadosAdicionais; }
            set { _dadosAdicionais = value; OnPropertyChanged(); }
        }

        public ClasseProfissionalDados ClasseProfissional
        {
            get { return _classeProfissional; }
            set { _classeProfissional = value; OnPropertyChanged(); }
        }

        public RelacaoProfissionalClasseDados RelacaoProfissionalClasse
        {
            get { return _relacaoProfissionalClasse; }
            set { _relacaoProfissionalClasse = value; OnPropertyChanged(); }
        }

        public RelacaoClasseEspecialidadeDados RelacaoClasseEspecialidade
        {
            get { return _relacaoClasseEspecialidade; }
            set { _relacaoClasseEspecialidade = value; OnPropertyChanged(); }
        }

        #endregion

    }
}
