using System;


namespace SensorGasAPI.Negocio
{
    public class AgendaConsultaProjecao : ProjecaoBase
    {
        #region Construtores

        public AgendaConsultaProjecao() { }

        #endregion

        #region Atributos

        private string _corTextoSituacao;
        private long _codigoConsuta;
        private long _codigoProfissional;
        private long _codigoPaciente;
        private string _solicitante;
        private long _situacaoConsulta;
        private string _descricaoSituacao;
        private short _tipoPagamentoConsulta;
        private DateTime _dataRealizacaoConsulta;
        private string _horaInicio;
        private string _minutoInicio;
        private string _horaFim;
        private string _minutoFim;

        #endregion

        #region Propriedades

        public string CorTextoSituacao
        {
            get { return _corTextoSituacao; }
            set { _corTextoSituacao = value; OnPropertyChanged(); }
        }

        public long CodigoConsulta
        {
            get { return _codigoConsuta; }
            set { _codigoConsuta = value; OnPropertyChanged(); }
        }

        public long CodigoProfissional
        {
            get { return _codigoProfissional; }
            set { _codigoProfissional = value; OnPropertyChanged(); }
        }

        public long CodigoPaciente
        {
            get { return _codigoPaciente; }
            set { _codigoPaciente = value; OnPropertyChanged(); }
        }

        public string Solicitante
        {
            get { return _solicitante; }
            set { _solicitante = value; OnPropertyChanged(); }
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

        public short TipoPagamentoConsulta
        {
            get { return _tipoPagamentoConsulta; }
            set { _tipoPagamentoConsulta = value; OnPropertyChanged(); }
        }

        public DateTime DataRealizacaoConsulta
        {
            get { return _dataRealizacaoConsulta; }
            set { _dataRealizacaoConsulta = value; OnPropertyChanged(); }
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

        #endregion

    }
}
