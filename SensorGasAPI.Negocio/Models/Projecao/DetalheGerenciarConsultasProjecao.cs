

namespace SensorGasAPI.Negocio
{
    public class DetalheGerenciarConsultasProjecao : ProjecaoBase
    {

        #region Construtores

        public DetalheGerenciarConsultasProjecao() { }

        #endregion

        #region Atributos

        private long _codigoConsulta;
        private long _codigoProfissional;
        private long _codigoPaciente;
        private string _nomeSolicitante;
        private string _eMailSolicitante;
        private long _situacaoConsulta;
        private string _descricaoSituacao;
        private string _tipoPagamentoConsulta;
        private string _dataRealizacaoConsulta;
        private string _horaInicio;
        private string _minutoInicio;
        private string _horaFim;
        private string _minutoFim;
        private string _telefoneSolicitante;
        private SituacaoConsultaEnumerador _acaoSituacaoConsulta;

        #endregion

        #region Propriedades

        public long CodigoConsulta
        {
            get { return _codigoConsulta; }
            set { _codigoConsulta = value; OnPropertyChanged(); }
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

        public string NomeSolicitante
        {
            get { return _nomeSolicitante; }
            set { _nomeSolicitante = value; OnPropertyChanged(); }
        }

        public string EMailSolicitante
        {
            get { return _eMailSolicitante; }
            set { _eMailSolicitante = value; OnPropertyChanged(); }
        }

        public string DataRealizacaoConsulta
        {
            get { return _dataRealizacaoConsulta; }
            set { _dataRealizacaoConsulta = value; OnPropertyChanged(); }
        }

        public string TipoPagamentoConsulta
        {
            get { return _tipoPagamentoConsulta; }
            set { _tipoPagamentoConsulta = value; OnPropertyChanged(); }
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

        public string TelefoneSolicitante
        {
            get { return _telefoneSolicitante; }
            set { _telefoneSolicitante = value; OnPropertyChanged(); }
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

        public SituacaoConsultaEnumerador AcaoSituacaoConsulta
        {
            get { return _acaoSituacaoConsulta; }
            set { _acaoSituacaoConsulta = value; OnPropertyChanged(); }
        }

        #endregion

    }
}