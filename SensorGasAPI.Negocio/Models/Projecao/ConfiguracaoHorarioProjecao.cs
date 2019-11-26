

namespace SensorGasAPI.Negocio
{
    public class ConfiguracaoHorarioProjecao : ProjecaoBase
    {
        #region Construtores

        public ConfiguracaoHorarioProjecao() { }

        #endregion

        #region Atributos

        private string _imagem;
        private long _codigoProfissional;
        private long _codigoDiaConsulta;
        private string _statusDia;
        private string _descricaoDiaConsulta;

        #endregion

        #region Propriedades

        public long CodigoProfissional
        {
            get { return _codigoProfissional; }
            set { _codigoProfissional = value; OnPropertyChanged(); }
        }

        public long CodigoDiaConsulta
        {
            get { return _codigoDiaConsulta; }
            set { _codigoDiaConsulta = value; OnPropertyChanged(); }
        }

        public string DescricaoDiaConsulta
        {
            get { return _descricaoDiaConsulta; }
            set { _descricaoDiaConsulta = value; OnPropertyChanged(); }
        }

        public string StatusDia
        {
            get { return _statusDia; }
            set { _statusDia = value; OnPropertyChanged(); }
        }

        public string Image
        {
            get { return _imagem; }
            set { _imagem = value; OnPropertyChanged(); }
        }

        #endregion

    }
}
