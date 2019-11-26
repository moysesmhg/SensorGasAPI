using System;

using SensorGasAPI.Negocio;

namespace SensorGasAPI.Negocio
{
    public class DetalheConsultaProfissionalProjecao : ProjecaoBase
    {
        #region Construtores

        public DetalheConsultaProfissionalProjecao() { }

        #endregion

        #region Atributos

        private string _image;
        private long _codigoConsulta;
        private long _codigoProfissional;
        private string _nomeProfissional;
        private long _codigoPaciente;
        private string _nomeSolicitante;
        private long _situacaoConsulta;
        private string _descricaoSituacao;
        private string _tipoPagamentoConsulta;
        private string _dataConsulta;
        private string _horaInicio;
        private string _minutoInicio;
        private string _horaFim;
        private string _minutoFim;
        private string _telefone;
        private SituacaoConsultaEnumerador _acaoSituacaoConsulta;

        #endregion

        #region Propriedades
        public string Image
        {
            get { return _image; }
            set { _image = value; OnPropertyChanged(); }
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

        public string NomeProfissional
        {
            get { return _nomeProfissional; }
            set { _nomeProfissional = value; OnPropertyChanged(); }
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

        public string TipoPagamentoConsulta
        {
            get { return _tipoPagamentoConsulta; }
            set { _tipoPagamentoConsulta = value; OnPropertyChanged(); }
        }

        public string DataConsulta
        {
            get { return _dataConsulta; }
            set { _dataConsulta = value; OnPropertyChanged(); }
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

        public string Telefone
        {
            get { return _telefone; }
            set { _telefone = value; OnPropertyChanged(); }
        }

        public SituacaoConsultaEnumerador AcaoSituacaoConsulta
        {
            get { return _acaoSituacaoConsulta; }
            set { _acaoSituacaoConsulta = value; OnPropertyChanged(); }
        }

        #endregion

    }
}
