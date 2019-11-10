

namespace SensorGasAPI.Negocio
{
    public class CheckLoginProjecao : BaseProjecao
    {
        #region Construtores

        public CheckLoginProjecao() { }

        #endregion

        #region Atributos

        private int _quantidadeLinhas;

        #endregion

        #region Propriedades

        public int QuantidadeLinhas
        {
            get { return _quantidadeLinhas; }
            set { _quantidadeLinhas = value; OnPropertyChanged(); }
        }

        #endregion

    }
}