using System;


namespace SensorGasAPI.Negocio
{
    public class ListaAvaliacoesPacienteProjecao : BaseProjecao
    {

        #region Construtores

        public ListaAvaliacoesPacienteProjecao() { }

        #endregion

        #region Atributos

        private string _image;
        private string _nomeProfissional;
        private long _codigoConsulta;
        private string _dataRealizacaoConsulta;

        #endregion

        #region Propriedades

        public string Image
        {
            get { return _image; }
            set { _image = value; OnPropertyChanged(); }
        }

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

        public string DataRealizacaoConsulta
        {
            get { return _dataRealizacaoConsulta; }
            set { _dataRealizacaoConsulta = value; OnPropertyChanged(); }
        }

        #endregion

    }

}
