

namespace SensorGasAPI.Negocio
{
    public class DetalheProfissionalProjecao : ProjecaoBase
    {

        #region Construtores

        public DetalheProfissionalProjecao() { }

        #endregion

        #region Atributos

        private byte[] _imagem;
        private long _codigoProfissional;
        private string _nomeProfissional;
        private string _registroProfissional;
        private string _especialidadeProfissional;
        private string _pacientesAtendidos;
        private int _classificacaoProfissional;
        private string _precoConsulta;
        //private string _localAbreviadoProfissional;
        private string _logradouroBairroProfissional;
        private string _cidadeEstadoProfissional;
        private string _cepTelefoneProfissional;

        #endregion

        #region Propriedades

        public byte[] Imagem
        {
            get { return _imagem; }
            set { _imagem = value; OnPropertyChanged(); }
        }

        public long CodigoProfissional
        {
            get { return _codigoProfissional; }
            set { _codigoProfissional = value; OnPropertyChanged(); }
        }

        public string NomeProfissional
        {
            get { return _nomeProfissional; }
            set { _nomeProfissional = value; OnPropertyChanged(); }
        }

        public string RegistroProfissional
        {
            get { return _registroProfissional; }
            set { _registroProfissional = value; OnPropertyChanged(); }
        }

        public string EspecialidadeProfissional
        {
            get { return _especialidadeProfissional; }
            set { _especialidadeProfissional = value; OnPropertyChanged(); }
        }

        public string PacientesAtendidos
        {
            get { return _pacientesAtendidos; }
            set { _pacientesAtendidos = value; OnPropertyChanged(); }
        }

        public int ClassificacaoProfissional
        {
            get { return _classificacaoProfissional; }
            set { _classificacaoProfissional = value; OnPropertyChanged(); }
        }

        public string PrecoConsulta
        {
            get { return _precoConsulta; }
            set { _precoConsulta = value; OnPropertyChanged(); }
        }

        //public string LocalAbreviadoProfissional
        //{
        //    get { return _localAbreviadoProfissional; }
        //    set { _localAbreviadoProfissional = value; OnPropertyChanged(); }
        //}

        public string LogradouroBairroProfissional
        {
            get { return _logradouroBairroProfissional; }
            set { _logradouroBairroProfissional = value; OnPropertyChanged(); }
        }


        public string CidadeEstadoProfissional
        {
            get { return _cidadeEstadoProfissional; }
            set { _cidadeEstadoProfissional = value; OnPropertyChanged(); }
        }


        public string CepTelefoneProfissional
        {
            get { return _cepTelefoneProfissional; }
            set { _cepTelefoneProfissional = value; OnPropertyChanged(); }
        }

        #endregion

    }

}
