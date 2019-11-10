

namespace SensorGasAPI.Negocio
{
    public class ListaProfissionaisProjecao : BaseProjecao
    {

        #region Construtores

        public ListaProfissionaisProjecao() { }

        #endregion

        #region Atributos

        private byte[] _imagem;
        private long _codigoProfissional;
        private string _nomeProfissional;
        private string _registroProfissional;
        private string _especialidadeProfissional;
        private string _localAbreviadoProfissional;        

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

        public string LocalAbreviadoProfissional
        {
            get { return _localAbreviadoProfissional; }
            set { _localAbreviadoProfissional = value; OnPropertyChanged(); }
        }

        #endregion

    }
}
