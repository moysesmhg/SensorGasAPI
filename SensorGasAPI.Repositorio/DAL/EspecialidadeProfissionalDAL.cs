using SQLite;
using System.Collections.Generic;
using System.Text;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Repositorio
{
    public class EspecialidadeProfissionalDAL : RepositorioAncestral
    {
        public EspecialidadeProfissionalDAL()
        {
            this.Conexao = this.Conexao = FabricaConexao.CriarFabricas.sqliteConexao().GetConnection();
        }

        // TODO: Verificar a necessidade de dispose do objeto de conexão (BLOCO FINALLY?)
        public List<EspecialidadeDados> ListarTodasEspecialidades()
        {
            var retorno = Conexao.Query<EspecialidadeDados>("SELECT * FROM EspecialidadeProfissional");

            return retorno;

        }

        public List<EspecialidadeDados> ListarEspecialidades(long? aCodigoClasseProfissional)
        {
            StringBuilder query = new StringBuilder();

            query.AppendLine(" SELECT * ");
            query.AppendLine("   FROM EspecialidadeProfissional ");
            query.AppendFormat("  WHERE CodigoClasseProfissional = {0} ", aCodigoClasseProfissional.Value);

            var retorno = this.Conexao.Query<EspecialidadeDados>(query.ToString());

            return retorno;

        }

        public long InsertEspecialidade(long aCodigoClasseProfissional, string aDescricaoEspecialidade)
        {
            long registro = 0;
            StringBuilder query = new StringBuilder();
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            query.AppendLine(" INSERT INTO EspecialidadeProfissional ");
            query.AppendLine("           ( CodigoClasseProfissional ");
            query.AppendLine("           , DescricaoEspecialidadeProfissional )");
            query.AppendLine("      VALUES ");
            query.AppendLine("           ( @CodigoClasseProfissional ");
            query.AppendLine("           , @DescricaoEspecialidade )");

            listaParametros.Add("@CodigoClasseProfissional", aCodigoClasseProfissional);
            listaParametros.Add("@DescricaoEspecialidade", aDescricaoEspecialidade);

            var sqlQuery = RecuperarSQL(query.ToString(), listaParametros);

            registro = this.Conexao.Execute(sqlQuery);
            //this.Conexao.Close();

            return registro;

        }

        public long InsertEspecialidadeDoProfissional(int aCodigoProfissional, int aCodigoEspecialidadeProfissional)
        {
            long registro = 0;
            StringBuilder query = new StringBuilder();
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            query.AppendLine(" INSERT INTO RelacaoClasseEspecialidade ");
            query.AppendLine("           ( CodigoRelacaoProfissionalClasse ");
            query.AppendLine("           , CodigoEspecialidadeProfissional )");
            query.AppendLine("      VALUES ");
            query.AppendLine("           ( (SELECT CodigoRelacaoProfissionalClasse ");
            query.AppendLine("                FROM RelacaoProfissionalClasse ");
            query.AppendLine("               WHERE CodigoProfissional = @CodigoProfissional) ");
            query.AppendLine("           , @CodigoEspecialidadeProfissional )");

            listaParametros.Add("@CodigoProfissional", aCodigoProfissional);
            listaParametros.Add("@CodigoEspecialidadeProfissional", aCodigoEspecialidadeProfissional);

            var sqlQuery = RecuperarSQL(query.ToString(), listaParametros);

            registro = this.Conexao.Execute(sqlQuery);
            //this.Conexao.Close();

            return registro;

        }
    }
}