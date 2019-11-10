using SQLite;
using System.Collections.Generic;
using System.Text;
using SensorGasAPI.Negocio;
using SensorGasAPI.Repositorio.Resources.Scripts;

namespace SensorGasAPI.Repositorio
{
    public class EstadoDAL : RepositorioAncestral
    {
        public EstadoDAL()
        {
            this.Conexao = this.Conexao = FabricaConexao.CriarFabricas.sqliteConexao().GetConnection();
        }

        public long InsertEstado()
        {
            var query = Scripts.CargaEstado.ToString();

            var retorno = this.Conexao.Execute(query);
            //this.Conexao.Close();

            return retorno;

        }

    }

}