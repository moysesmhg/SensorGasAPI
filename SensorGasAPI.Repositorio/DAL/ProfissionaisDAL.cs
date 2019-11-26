using SQLite;
using System.Collections.Generic;
using System.Text;
using SensorGasAPI.Negocio;
using System;
using System.Linq;
using SensorGasAPI.Repositorio.Resources.Scripts;

namespace SensorGasAPI.Repositorio
{
    public class ProfissionaisDAL : RepositorioAncestral
    {
        public ProfissionaisDAL()
        {
            this.Conexao = this.Conexao = FabricaConexao.CriarFabricas.sqliteConexao().GetConnection();
        }

        public List<ListaProfissionaisProjecao> ListarTodosProfissionais()
        {
            string query = Scripts.ListarTodosProfissionais.ToString();

            var retorno = Conexao.Query<ListaProfissionaisProjecao>(query);

            return retorno;

        }

        public List<ListaProfissionaisProjecao> ListarProfissionais(string aNomeProfissional,
                                                                    long? aCodigoClasseProfissional,
                                                                    long? aCodigoEspecialidadeProfissional)
        {

            string query = Scripts.ListarProfissionais.ToString();
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            try
            {
                listaParametros.Add("@NomeProfissional", aNomeProfissional == null ? "" : aNomeProfissional);
                listaParametros.Add("@CodigoClasseProfissional", new object[] { null, 0 }.Contains(aCodigoClasseProfissional) ? null : aCodigoClasseProfissional);
                listaParametros.Add("@CodigoEspecialidadeProfissional", new object[] { null, 0 }.Contains(aCodigoEspecialidadeProfissional) ? null : aCodigoEspecialidadeProfissional);

                //listaParametros.Add("@CodigoClasseProfissional", ((object)aCodigoClasseProfissional ?? null));
                //listaParametros.Add("@CodigoEspecialidadeProfissional", ((object)aCodigoEspecialidadeProfissional ?? null));

                var sqlQuery = RecuperarSQL(query.ToString(), listaParametros);

                var retorno = this.Conexao.Query<ListaProfissionaisProjecao>(sqlQuery);
                //this.Conexao.Close();

                return retorno;
            }
            catch (Exception excecao)
            {
                throw excecao;
            }

        }

        public DetalheProfissionalProjecao DetalheProfissional(long? aCodigoProfissional)
        {

            string query = Scripts.DetalheProfissional.ToString();
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            listaParametros.Add("@CodigoProfissional", ((object)aCodigoProfissional ?? null));

            var sqlQuery = RecuperarSQL(query.ToString(), listaParametros);

            var retorno = this.Conexao.FindWithQuery<DetalheProfissionalProjecao>(sqlQuery);

            return retorno;

        }

        public string RecuperarNomeProfissional(long aCodigoProfissional)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para recuperação do nome do profissional                  
            listaParametros.Add("@CodigoProfissional", aCodigoProfissional);

            // Recupera no nome do profissional
            sqlString = Scripts.RecuperarNomeProfissional.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retornoUsuario = this.Conexao.FindWithQuery<ProfissionalProjecao>(sqlQuery).NomeProfissional;

            return retornoUsuario;
        }

    }
}