using SQLite;
using System.Collections.Generic;
using System.Text;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Repositorio
{
    public class ClasseProfissionalDAL : RepositorioAncestral
    {

        public ClasseProfissionalDAL()
        {
            this.Conexao = this.Conexao = FabricaConexao.CriarFabricas.sqliteConexao().GetConnection();
        }

        public List<ClasseProfissionalDados> GetClasses()
        {

            var retorno = Conexao.Query<ClasseProfissionalDados>("SELECT * FROM ClasseProfissional");

            return retorno;

        }

        public ClasseProfissionalDados GetClasse(long aCodigoClasse)
        {
            StringBuilder query = new StringBuilder();

            query.AppendLine(" SELECT * ");
            query.AppendLine("   FROM ClasseProfissional ");
            query.AppendFormat("  WHERE CodigoClasseProfissional = {0} ", aCodigoClasse);

            var retorno = this.Conexao.FindWithQuery<ClasseProfissionalDados>(query.ToString());

            return retorno;
        }

        public ClasseProfissionalDados GetClasse(string aConselhoClasse)
        {
            StringBuilder query = new StringBuilder();

            query.AppendLine(" SELECT * ");
            query.AppendLine("   FROM ClasseProfissional ");
            query.AppendFormat("  WHERE ConselhoProfissional = '{0}' ", aConselhoClasse).AppendLine();

            var retorno = this.Conexao.FindWithQuery<ClasseProfissionalDados>(query.ToString());

            return retorno;

        }

        public long InsertClasse(ClasseProfissionalDados aClasseProfissional)
        {
            long registro = 0;
            StringBuilder query = new StringBuilder();
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            query.AppendLine(" INSERT INTO ClasseProfissional ");
            query.AppendLine("      ( DescricaoClasseProfissional ");
            query.AppendLine("      , ConselhoProfissional ) ");
            query.AppendLine(" VALUES ");
            query.AppendLine("      ( @descricao ");
            query.AppendLine("      , @conselho ) ");

            listaParametros.Add("@descricao", aClasseProfissional.DescricaoClasseProfissional);
            listaParametros.Add("@conselho", aClasseProfissional.ConselhoProfissional);

            var sqlQuery = RecuperarSQL(query.ToString(), listaParametros);

            registro = this.Conexao.Execute(sqlQuery);
            //this.Conexao.Close();

            return registro;

        }

        public long UpdateClasse(ClasseProfissionalDados aClasseProfissional)
        {
            long registro = 0;
            StringBuilder query = new StringBuilder();
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            query.AppendLine(" UPDATE ClasseProfissional ");
            query.AppendLine("    SET DescricaoClasseProfissional = @descricao ");
            query.AppendLine("  WHERE CodigoClasseProfissional = @codigo ");

            listaParametros.Add("@codigo", aClasseProfissional.CodigoClasseProfissional);
            listaParametros.Add("@descricao", aClasseProfissional.DescricaoClasseProfissional);

            var sqlQuery = RecuperarSQL(query.ToString(), listaParametros);

            registro = this.Conexao.Execute(sqlQuery);

            //this.Conexao.Close();

            return registro;

        }

        public long DeleteClasse(long aCodigo)
        {
            StringBuilder query = new StringBuilder();
            long registro = 0;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();


            query.AppendLine(" DELETE FROM ClasseProfissional ").AppendLine();
            query.AppendFormat("  WHERE CodigoClasseProfissional = {0} ").AppendLine();

            registro = this.Conexao.Execute(query.ToString());

            //this.Conexao.Close();

            return registro;

        }

    }
}