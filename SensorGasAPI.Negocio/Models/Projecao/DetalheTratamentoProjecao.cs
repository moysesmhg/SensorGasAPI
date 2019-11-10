

namespace SensorGasAPI.Negocio
{

    public class DetalheTratamentoProjecao : BaseProjecao
    {

        #region Construtores

        public DetalheTratamentoProjecao() { }

        #endregion

        #region Atributos

        private string _nomeProfissional;
        private long _codigoConsulta;
        private long _codigoProfissional;
        private long _codigoPaciente;
        private string _dataRealizacaoConsulta;
        private long _situacaoConsulta;
        private long _aCodigoTratamento;
        private string _nomeTratamento;
        private string _descricaoTratamento;
        private string _inicioTratamento;
        private string _terminoTratamento;
        private string _horaInicio;
        private string _minutoInicio;
        private long _frequenciaDias;
        private long _frequenciaHoras;
        private long _tratamentoAtivado;
        private string _statusAtivado;

        #endregion

        #region Propriedades

        public string NomeProfissional
        {
            get { return _nomeProfissional; }
            set { _nomeProfissional = value; OnPropertyChanged(); }
        }

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

        public string DataRealizacaoConsulta
        {
            get { return _dataRealizacaoConsulta; }
            set { _dataRealizacaoConsulta = value; OnPropertyChanged(); }
        }

        public long SituacaoConsulta
        {
            get { return _situacaoConsulta; }
            set { _situacaoConsulta = value; OnPropertyChanged(); }
        }

        public long CodigoTratamento
        {
            get { return _aCodigoTratamento; }
            set { _aCodigoTratamento = value; OnPropertyChanged(); }
        }

        public string NomeTratamento
        {
            get { return _nomeTratamento; }
            set { _nomeTratamento = value; OnPropertyChanged(); }
        }

        public string DescricaoTratamento
        {
            get { return _descricaoTratamento; }
            set { _descricaoTratamento = value; OnPropertyChanged(); }
        }

        public string InicioTratamento
        {
            get { return _inicioTratamento; }
            set { _inicioTratamento = value; OnPropertyChanged(); }
        }

        public string TerminoTratamento
        {
            get { return _terminoTratamento; }
            set { _terminoTratamento = value; OnPropertyChanged(); }
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

        public long FrequenciaDias
        {
            get { return _frequenciaDias; }
            set { _frequenciaDias = value; OnPropertyChanged(); }
        }

        public long FrequenciaHoras
        {
            get { return _frequenciaHoras; }
            set { _frequenciaHoras = value; OnPropertyChanged(); }
        }

        public long TratamentoAtivado
        {
            get { return _tratamentoAtivado; }
            set { _tratamentoAtivado = value; OnPropertyChanged(); }
        }

        public string StatusAtivado
        {
            get { return _statusAtivado; }
            set { _statusAtivado = value; OnPropertyChanged(); }
        }

        #endregion

    }

}
