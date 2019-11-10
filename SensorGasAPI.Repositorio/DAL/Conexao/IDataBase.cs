using SQLite;

namespace SensorGasAPI.Repositorio
{
    public interface IDatabase
    {
        SQLiteConnection GetConnection();
        void ExcluirBase();
    }
}
