using System;


namespace SensorGasAPI.Negocio
{
    public class ConsultaServicoEmailProjecao : BaseProjecao
    {

        #region Construtores

        public ConsultaServicoEmailProjecao() { }

        #endregion

        #region Atributos
                
        private string _nomeProfissional;
        private long _codigoConsulta;
        private DateTime _dataConsulta;
        private short _horaInicio;
        private short _minutoInicio;

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


        public DateTime DataConsulta
        {
            get { return _dataConsulta; }
            set { _dataConsulta = value; OnPropertyChanged(); }
        }

        public short HoraInicio
        {
            get { return _horaInicio; }
            set { _horaInicio = value; OnPropertyChanged(); }
        }

        public short MinutoInicio
        {
            get { return _minutoInicio; }
            set { _minutoInicio = value; OnPropertyChanged(); }
        }

        #endregion

    }

}
