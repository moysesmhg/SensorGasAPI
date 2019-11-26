

namespace SensorGasAPI.Negocio
{
    public class NumerosProfissionalProjecao : ProjecaoBase
    {
        #region Construtores

        public NumerosProfissionalProjecao() { }

        #endregion

        #region Atributos

        private int _pacientesAtendidos;
        private double _classificacaoProfissional;

        #endregion

        #region Propriedades

        public int PacientesAtendidos
        {
            get { return _pacientesAtendidos; }
            set { _pacientesAtendidos = value; OnPropertyChanged(); }
        }

        public double ClassificacaoProfissional
        {
            get { return _classificacaoProfissional; }
            set { _classificacaoProfissional = value; OnPropertyChanged(); }
        }

        #endregion

    }
}
