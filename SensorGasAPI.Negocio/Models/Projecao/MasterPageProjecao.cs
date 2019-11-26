

namespace SensorGasAPI.Negocio
{
    public class MasterPageProjecao : ProjecaoBase
    {
        #region Construtores

        public MasterPageProjecao() { }

        #endregion

        #region Atributos

        private string _icone;
        private string _descricaoMenu;

        #endregion

        #region Propriedades

        public string Icone
        {
            get { return _icone; }
            set { _icone = value; OnPropertyChanged(); }
        }

        public string DescricaoMenu
        {
            get { return _descricaoMenu; }
            set { _descricaoMenu = value; OnPropertyChanged(); }
        }

        #endregion

    }
}
