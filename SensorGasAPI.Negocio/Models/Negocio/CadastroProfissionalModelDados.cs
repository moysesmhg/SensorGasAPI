namespace SensorGasAPI.Negocio
{
    public class CadastroProfissionalModelDados
    {
        #region __Construtores__

        public CadastroProfissionalModelDados() { }

        #endregion

        #region __Atributos__

        private UsuarioDados _usuario;
        private PessoaDados _pessoa;
        private PacienteDados _paciente;
        private ProfissionalDados _profissional;
        private EnderecoMobileDados _endereco;
        private DadosAdicionaisDados _dadosAdicionais;
        private ClasseProfissionalDados _classeProfissional;
        private RelacaoProfissionalClasseDados _relacaoProfissionalClasse;
        private RelacaoClasseEspecialidadeDados _relacaoClasseEspecialidade;

        #endregion

        #region __Propriedades__

        public UsuarioDados Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        public PessoaDados Pessoa
        {
            get { return _pessoa; }
            set { _pessoa = value; }
        }

        public PacienteDados Paciente
        {
            get { return _paciente; }
            set { _paciente = value; }
        }

        public ProfissionalDados Profissional
        {
            get { return _profissional; }
            set { _profissional = value; }
        }

        public EnderecoMobileDados Endereco
        {
            get { return _endereco; }
            set { _endereco = value; }
        }

        public DadosAdicionaisDados DadosAdicionais
        {
            get { return _dadosAdicionais; }
            set { _dadosAdicionais = value; }
        }

        public ClasseProfissionalDados ClasseProfissional
        {
            get { return _classeProfissional; }
            set { _classeProfissional = value; }
        }

        public RelacaoProfissionalClasseDados RelacaoProfissionalClasse
        {
            get { return _relacaoProfissionalClasse; }
            set { _relacaoProfissionalClasse = value; }
        }

        public RelacaoClasseEspecialidadeDados RelacaoClasseEspecialidade
        {
            get { return _relacaoClasseEspecialidade; }
            set { _relacaoClasseEspecialidade = value; }
        }

        #endregion

    }
}
