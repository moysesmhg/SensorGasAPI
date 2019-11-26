using System;
using System.Web;
using System.Configuration;
using System.IO;
using SQLite;


namespace SensorGasAPI.Repositorio
{
    public class SQLiteAndroid : IDatabase
    {
        public static string MontarBanco()
        {
            // var caminhoBancoDados = ConfigurationManager.ConnectionStrings["conexaoSqlite"].ConnectionString;

            // Para debugar, descomentar abaixo
            //var caminhoBancoDados = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DBWebApi.db3");
            // Para publicar o site, descomentar abaixo
            var caminhoBancoDados = HttpContext.Current.Server.MapPath(@"~\DBWebApi.db3");

            return caminhoBancoDados;
        }

        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(MontarBanco(), false);
        }

        public void ExcluirBase()
        {
            if (File.Exists(MontarBanco()))
            {
                File.Delete(MontarBanco());
            }
        }
    }
}