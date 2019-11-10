
namespace SensorGasAPI.Repositorio
{
    public abstract class FabricaConexao
    {

        #region Atributos

        private static FabricaConexao fabrica;

        #endregion

        #region Propriedades

        private static FabricaConexao Fabrica
        {
            get { return fabrica; }
            set { fabrica = value; }
        }

        #endregion

        #region Objetos das Interfaces para a Injeção de Dependância

        public abstract IDatabase sqliteConexao();
        

        #endregion

        #region Criação de Fábricas

        public static FabricaConexao CriarFabricas
        {
            get
            {
                if (Fabrica == null)
                    lock (typeof(FabricaConexao))
                        if (Fabrica == null)
                            ObterFabrica(new ObterFabricasConexao());
                return Fabrica;
            }
        }

        internal static void ObterFabrica(FabricaConexao aFabrica)
        {
            Fabrica = aFabrica;
        }

        #endregion

    }
}
