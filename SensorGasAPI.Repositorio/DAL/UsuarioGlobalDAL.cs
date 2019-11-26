using SQLite;
using System.Collections.Generic;
using System.Text;
using SensorGasAPI.Negocio;
using SensorGasAPI.Repositorio.Resources.Scripts;

namespace SensorGasAPI.Repositorio
{
    public class UsuarioGlobalDAL : RepositorioAncestral
    {
        public UsuarioGlobalDAL()
        {
            this.Conexao = this.Conexao = FabricaConexao.CriarFabricas.sqliteConexao().GetConnection();
        }

        public UsuarioGlobalDados CheckUsuarioGlobal()
        {
            string query = Scripts.VerificarUsuario.ToString();  
            var contador = this.Conexao.FindWithQuery<UsuarioGlobalDados>(query);

            return contador;
        }

        public void InserirUsuarioGlobal(UsuarioGlobalDados aUsuarioGlobal)
        {

            long registro = 0;
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da projeção "AvaliacaoPacienteProjecao"
            listaParametros.Add("@CodigoUsuario", aUsuarioGlobal.CodigoUsuario);
            listaParametros.Add("@CodigoPaciente", aUsuarioGlobal.CodigoPaciente);
            listaParametros.Add("@TipoUsuario", aUsuarioGlobal.TipoUsuario);
            listaParametros.Add("@LoginUsuario", aUsuarioGlobal.LoginUsuario);
            listaParametros.Add("@SenhaUsuario", aUsuarioGlobal.SenhaUsuario);
            listaParametros.Add("@NomeUsuario", aUsuarioGlobal.NomeUsuario);
            listaParametros.Add("@EmailUsuario", aUsuarioGlobal.EmailUsuario);

            // Recupera os dados da projeção "AvaliacaoPacienteProjecao"
            sqlString = Scripts.InserirUsuarioGlobal.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            registro = this.Conexao.Execute(sqlQuery);

        }

    }
}