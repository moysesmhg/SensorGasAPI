using System;


namespace SensorGasAPI.Negocio
{
    public class ListaTratamentoProjecao : ProjecaoBase
    {

        #region Construtores

        public ListaTratamentoProjecao() { }

        #endregion

        #region Atributos

        private string _nomeProfissional;
        private string _dataRealizacaoConsulta;
        private long _codigoConsulta;

        #endregion

        #region Propriedades

        public string NomeProfissional
        {
            get { return _nomeProfissional; }
            set { _nomeProfissional = value; OnPropertyChanged(); }
        }

        public string DataRealizacaoConsulta
        {
            get { return _dataRealizacaoConsulta; }
            set { _dataRealizacaoConsulta = value; OnPropertyChanged(); }
        }

        public long CodigoConsulta
        {
            get { return _codigoConsulta; }
            set { _codigoConsulta = value; OnPropertyChanged(); }
        }

        #endregion

    }
}
