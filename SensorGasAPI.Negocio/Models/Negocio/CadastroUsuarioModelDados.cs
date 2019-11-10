namespace SensorGasAPI.Negocio
{
    public class CadastroUsuarioModelDados
    {
        #region __Construtores__

        public CadastroUsuarioModelDados() { }

        #endregion

        #region __Atributos__

        private UsuarioDados _usuario;
        private PessoaDados _pessoa;
        private PacienteDados _paciente;
        private ProfissionalDados _profissional;
        private DadosAdicionaisDados _dadosAdicionais;

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

        public DadosAdicionaisDados DadosAdicionais
        {
            get { return _dadosAdicionais; }
            set { _dadosAdicionais = value; }
        }

        #endregion

    }
}
