using SQLite;
using System.Collections.Generic;
using System.Text;
using SensorGasAPI.Negocio;
using SensorGasAPI.Repositorio.Resources.Scripts;

namespace SensorGasAPI.Repositorio
{
    public class MunicipioDAL : RepositorioAncestral
    {
        public MunicipioDAL()
        {
            this.Conexao = this.Conexao = FabricaConexao.CriarFabricas.sqliteConexao().GetConnection();
        }

        public long InsertMunicipio()
        {
            var query = Scripts.CargaMunicipio.ToString();

            var retorno = this.Conexao.Execute(query);
            //this.Conexao.Close();

            return retorno;

        }

    }

}