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

        public List<MunicipioDados> ListaMunicipios(long aCodigoEstado)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da tabela "Municipio"
            listaParametros.Add("@CodigoEstado", aCodigoEstado);

            // Recupera os dados da tabela "Municipio"
            sqlString = Scripts.ListaMunicipios.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retorno = this.Conexao.Query<MunicipioDados>(sqlQuery);

            return retorno;

        }

    }

}