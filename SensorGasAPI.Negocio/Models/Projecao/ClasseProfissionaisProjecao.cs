

namespace SensorGasAPI.Negocio
{
    public class ClasseProfissionaisProjecao : ProjecaoBase
    {

        #region Atributos

        private long _codigo;
        private string _descricao;

        #endregion

        #region Propriedades

        public long Codigo
        {
            get { return _codigo; }
            set { _codigo = value; OnPropertyChanged(); }
        }

        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; OnPropertyChanged(); }
        }

        #endregion

        #region Construtores

        public ClasseProfissionaisProjecao() { }

        #endregion

    }
}
