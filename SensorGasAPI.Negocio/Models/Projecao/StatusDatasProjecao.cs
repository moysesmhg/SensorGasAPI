using System;


namespace SensorGasAPI.Negocio
{
    public class StatusDatasProjecao : ProjecaoBase
    {
        #region Construtores

        public StatusDatasProjecao() { }

        #endregion

        #region Atributos

        private DateTime _dataRealizacaoConsulta;
        private int _quantidadeConsultasAbertas;
        private int _quantidadeConsultasSolicitadas;
        private int _quantidadeConsultasConfirmadas;
        private int _quantidadeConsultasRealizadas;

        #endregion

        #region Propriedades

        public DateTime DataRealizacaoConsulta
        {
            get { return _dataRealizacaoConsulta; }
            set { _dataRealizacaoConsulta = value; OnPropertyChanged(); }
        }

        public int QuantidadeConsultasAbertas
        {
            get { return _quantidadeConsultasAbertas; }
            set { _quantidadeConsultasAbertas = value; OnPropertyChanged(); }
        }

        public int QuantidadeConsultasSolicitadas
        {
            get { return _quantidadeConsultasSolicitadas; }
            set { _quantidadeConsultasSolicitadas = value; OnPropertyChanged(); }
        }

        public int QuantidadeConsultasConfirmadas
        {
            get { return _quantidadeConsultasConfirmadas; }
            set { _quantidadeConsultasConfirmadas = value; OnPropertyChanged(); }
        }

        public int QuantidadeConsultasRealizadas
        {
            get { return _quantidadeConsultasRealizadas; }
            set { _quantidadeConsultasRealizadas = value; OnPropertyChanged(); }
        }

        #endregion

    }
}
