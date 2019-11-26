

namespace SensorGasAPI.Negocio
{
    public class MinhasConsultasProjecao : ProjecaoBase
    {

        #region Construtores

        public MinhasConsultasProjecao() { }

        #endregion

        #region Atributos

        private long _codigoConsulta;
        private string _dataRealizacaoConsulta;
        private string _nomeProfissional;
        private string _horaInicio;
        private string _minutoInicio;
        private string _horaFim;
        private string _minutoFim;
        private string _telefoneProfissional;
        private string _enderecoProfissional;
        private long _situacaoConsulta;
        private string _descricaoSituacao;

        #endregion

        #region Propriedades

        public long CodigoConsulta
        {
            get { return _codigoConsulta; }
            set { _codigoConsulta = value; OnPropertyChanged(); }
        }

        public string DataRealizacaoConsulta
        {
            get { return _dataRealizacaoConsulta; }
            set { _dataRealizacaoConsulta = value; OnPropertyChanged(); }
        }

        public string NomeProfissional
        {
            get { return _nomeProfissional; }
            set { _nomeProfissional = value; OnPropertyChanged(); }
        }

        public string HoraInicio
        {
            get { return _horaInicio; }
            set { _horaInicio = value; OnPropertyChanged(); }
        }

        public string MinutoInicio
        {
            get { return _minutoInicio; }
            set { _minutoInicio = value; OnPropertyChanged(); }
        }

        public string HoraFim
        {
            get { return _horaFim; }
            set { _horaFim = value; OnPropertyChanged(); }
        }

        public string MinutoFim
        {
            get { return _minutoFim; }
            set { _minutoFim = value; OnPropertyChanged(); }
        }

        public string TelefoneProfissional
        {
            get { return _telefoneProfissional; }
            set { _telefoneProfissional = value; OnPropertyChanged(); }
        }

        public string EnderecoProfissional
        {
            get { return _enderecoProfissional; }
            set { _enderecoProfissional = value; OnPropertyChanged(); }
        }

        public long SituacaoConsulta
        {
            get { return _situacaoConsulta; }
            set { _situacaoConsulta = value; OnPropertyChanged(); }
        }

        public string DescricaoSituacao
        {
            get { return _descricaoSituacao; }
            set { _descricaoSituacao = value; OnPropertyChanged(); }
        }

        #endregion

    }
}
