using System;


namespace SensorGasAPI.Negocio
{
    public class ListaReputacaoProjecao : ProjecaoBase
    {

        #region Construtores

        public ListaReputacaoProjecao() { }

        #endregion

        #region Atributos

        private byte[] _imagem;
        private string _nomePaciente;
        private long _codigoConsulta;
        private string _dataRealizacaoConsulta;
        private short _notaAvaliacao;

        #endregion

        #region Propriedades

        public byte[] Imagem
        {
            get { return _imagem; }
            set { _imagem = value; OnPropertyChanged(); }
        }

        public string NomePaciente
        {
            get { return _nomePaciente; }
            set { _nomePaciente = value; OnPropertyChanged(); }
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

        public short NotaAvaliacao
        {
            get { return _notaAvaliacao; }
            set { _notaAvaliacao = value; OnPropertyChanged(); }
        }


        #endregion

    }

}
