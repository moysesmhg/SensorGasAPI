

namespace SensorGasAPI.Negocio
{
    public class ConfiguracaoConsultaProjecao : ProjecaoBase
    {
        #region Construtores

        public ConfiguracaoConsultaProjecao() { }

        #endregion

        #region Atributos

        private long _codigoConfiguracaoConsulta;
        private long _codigoProfissional;
        private string _precoConsultaProfissional;
        private string _intervaloConsultaProfissional;

        #endregion

        #region Propriedades

        public long CodigoConfiguracaoConsulta
        {
            get { return _codigoConfiguracaoConsulta; }
            set { _codigoConfiguracaoConsulta = value; OnPropertyChanged(); }
        }

        public long CodigoProfissional
        {
            get { return _codigoProfissional; }
            set { _codigoProfissional = value; OnPropertyChanged(); }
        }
        public string PrecoConsultaProfissional
        {
            get { return _precoConsultaProfissional; }
            set { _precoConsultaProfissional = value; OnPropertyChanged(); }
        }
        public string IntervaloConsultaProfissional
        {
            get { return _intervaloConsultaProfissional; }
            set { _intervaloConsultaProfissional = value; OnPropertyChanged(); }
        }

        #endregion

    }
}
