using SQLite;
using System.Collections.Generic;
using System.Text;
using SensorGasAPI.Negocio;
using SensorGasAPI.Repositorio.Resources.Scripts;

namespace SensorGasAPI.Repositorio
{
    public class CheckEMailDAL : RepositorioAncestral
    {

        public CheckEMailDAL()
        {
            this.Conexao = this.Conexao = FabricaConexao.CriarFabricas.sqliteConexao().GetConnection();
        }
        
        public CheckEmailDados SelectCheckEMail(long aCodigoPaciente)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para recuperação do nome do profissional                  
            listaParametros.Add("@CodigoPaciente", aCodigoPaciente);

            // Recupera no nome do profissional
            sqlString = Scripts.SelectCheckEmail.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retornoUsuario = this.Conexao.FindWithQuery<CheckEmailDados>(sqlQuery);

            return retornoUsuario;
        }

        public void InsertCheckEMail(long aCodigoConsulta)
        {

            long registro = 0;
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da projeção "AvaliacaoPacienteProjecao"
            listaParametros.Add("@CodigoConsulta", aCodigoConsulta);    

            // Recupera os dados da projeção "AvaliacaoPacienteProjecao"
            sqlString = Scripts.InserirCheckEmail.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            registro = this.Conexao.Execute(sqlQuery);

        }
        
    }

}