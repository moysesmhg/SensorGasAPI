

namespace SensorGasAPI.Negocio
{
    public class ListaGerenciarConsultasProjecao : BaseProjecao
    {

        #region Construtores

        public ListaGerenciarConsultasProjecao() { }

        #endregion

        #region Atributos

        private byte[] _imagem;
        private string _nomeSolicitante;
        private long _codigoConsulta;
        private string _dataRealizacaoConsulta;

        #endregion

        #region Propriedades

        public byte[] Imagem
        {
            get { return _imagem; }
            set { _imagem = value; OnPropertyChanged(); }
        }

        public string NomeSolicitante
        {
            get { return _nomeSolicitante; }
            set { _nomeSolicitante = value; OnPropertyChanged(); }
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