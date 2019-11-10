using System;


namespace SensorGasAPI.Negocio
{
    public class ListaMinhasConsultasProjecao : BaseProjecao
    {

        #region Construtores

        public ListaMinhasConsultasProjecao() { }

        #endregion

        #region Atributos

        private byte[] _imagem;
        private string _nomeProfissional;
        private long _codigoConsulta;
        private string _dataRealizacaoConsulta;

        #endregion

        #region Propriedades

        public byte[] Imagem
        {
            get { return _imagem; }
            set { _imagem = value; OnPropertyChanged(); }
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
