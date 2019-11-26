using System;


namespace SensorGasAPI.Negocio
{
    public class AvaliacaoPacienteProjecao : ProjecaoBase
    {

        #region Construtores

        public AvaliacaoPacienteProjecao() { }

        #endregion

        #region Atributos

        private long _codigoConsulta;
        private string _dataRealizacaoConsulta;
        private string _nomeProfissional;
        private long _codigoAvaliacao;
        private short _situacaoAvaliacao;
        private short _notaAvaliacao;
        private string _descricaoAvaliacao;

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

        public long CodigoAvaliacao
        {
            get { return _codigoAvaliacao; }
            set { _codigoAvaliacao = value; OnPropertyChanged(); }
        }

        public short SituacaoAvaliacao
        {
            get { return _situacaoAvaliacao; }
            set { _situacaoAvaliacao = value; OnPropertyChanged(); }
        }

        public short NotaAvaliacao
        {
            get { return _notaAvaliacao; }
            set { _notaAvaliacao = value; OnPropertyChanged(); }
        }

        public string DescricaoAvaliacao
        {
            get { return _descricaoAvaliacao; }
            set { _descricaoAvaliacao = value; OnPropertyChanged(); }
        }


        #endregion

    }
}
