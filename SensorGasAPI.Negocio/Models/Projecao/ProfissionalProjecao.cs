

namespace SensorGasAPI.Negocio
{
    public class ProfissionalProjecao : ProjecaoBase
    {
        #region Construtores

        public ProfissionalProjecao() { }

        #endregion

        #region Atributos

        private long _codigoProfissional;
        private string _nomeProfissional;
        private string _telefoneProfissional;
        private string _celularProfissional;

        #endregion

        #region Propriedades

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

        public string TelefoneProfissional
        {
            get { return _telefoneProfissional; }
            set { _telefoneProfissional = value; OnPropertyChanged(); }
        }

        public string CelularProfissional
        {
            get { return _celularProfissional; }
            set { _celularProfissional = value; OnPropertyChanged(); }
        }

        #endregion        

    }
}