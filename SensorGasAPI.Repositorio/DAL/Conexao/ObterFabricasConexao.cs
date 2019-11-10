
namespace SensorGasAPI.Repositorio
{
    public class ObterFabricasConexao : FabricaConexao
    {     

        public override IDatabase sqliteConexao()
        {
            return new SQLiteAndroid();
        }
    }
}
