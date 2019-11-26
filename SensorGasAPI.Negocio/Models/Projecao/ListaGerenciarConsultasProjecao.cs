

namespace SensorGasAPI.Negocio
{
    public class ListaGerenciarConsultasProjecao : ProjecaoBase
    {

        #region Construtores

        public ListaGerenciarConsultasProjecao() { }

        #endregion

        #region Atributos

        private byte[] _imagem;
        private string _nomeSolicitante;
        private long _codigoConsulta;
        private string _dataRealizacaoConsulta;
        private int _situacaoConsulta;

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

        public int SituacaoConsulta
        {
            get { return _situacaoConsulta; }
            set { _situacaoConsulta = value; OnPropertyChanged(); }
        }

        #endregion

    }
}