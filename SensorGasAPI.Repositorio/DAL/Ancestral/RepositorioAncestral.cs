using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;


namespace SensorGasAPI.Repositorio
{
    public class RepositorioAncestral
    {

        protected SQLiteConnection Conexao { get; set; }
        private bool disposed = false;


        public RepositorioAncestral()
        {
        }

        protected virtual void Dispose(bool disposing)
        {
            try
            {
            }
            finally
            {
                if (disposed)
                {
                    Conexao.Close();
                    Conexao.Dispose();
                    Conexao = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected static string RecuperarSQL(string aQuery, Dictionary<string, object> aParametros, bool aContainsList = false)
        {
            string query = aQuery;

            foreach (var p in aParametros)
            {
                if (new object[] { null }.Contains(p.Value))
                    query = query.Replace(p.Key, "NULL");
                else if (p.Value.GetType() == typeof(string) && p.Value.ToString() != "NULL")
                    query = query.Replace(p.Key, "'" + p.Value.ToString() + "'");
                else if (p.Value.GetType() == typeof(DateTime) && !aContainsList)
                    query = query.Replace(p.Key, "'" + p.Value.ToString() + "'");
                else
                    query = query.Replace(p.Key, p.Value.ToString());
            }

            //query = query.Replace("\r", "").Replace("\n", "");

            return query;
        }

    }

}