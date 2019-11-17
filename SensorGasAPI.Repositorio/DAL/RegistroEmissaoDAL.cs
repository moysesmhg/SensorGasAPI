using System.Collections.Generic;
using SensorGasAPI.Negocio;
using System;
using SensorGasAPI.Repositorio.Resources.Scripts;

namespace SensorGasAPI.Repositorio
{
    public class RegistroEmissaoDAL : RepositorioAncestral
    {
        public RegistroEmissaoDAL()
        {

            //this.Conexao = this.Conexao = FabricaConexao.CriarFabricas.sqliteConexao().GetConnection();
            this.Conexao = FabricaConexao.CriarFabricas.sqliteConexao().GetConnection();
        }


        public List<RegistroEmissao> ListaRegistroEmissao(int aIdRegistroEmissao)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da entidade "RegistroEmissao"
            listaParametros.Add("@IdRegistroEmissao", aIdRegistroEmissao);
            listaParametros.Add("@DataInicio", null);
            listaParametros.Add("@DataFim", null);
            //listaParametros.Add("@HoraAtual", DateTime.Now.Hour.ToString().PadLeft(2, '0') + ":" + DateTime.Now.Minute.ToString().PadLeft(2, '0'));

            // Recupera lista da entidade "RegistroEmissao"
            sqlString = Scripts.ListaAvaliacoesPaciente.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retornoListaRegistroEmissao = this.Conexao.Query<RegistroEmissao>(sqlQuery);

            return retornoListaRegistroEmissao;

        }

        public List<RegistroEmissao> ListaRegistroEmissao(DateTime aDataInicio, DateTime aDataFim)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da entidade "RegistroEmissao"
            listaParametros.Add("@IdRegistroEmissao", null);
            listaParametros.Add("@DataInicio", aDataInicio);
            listaParametros.Add("@DataFim", aDataFim);
            //listaParametros.Add("@HoraAtual", DateTime.Now.Hour.ToString().PadLeft(2, '0') + ":" + DateTime.Now.Minute.ToString().PadLeft(2, '0'));

            // Recupera lista da entidade "RegistroEmissao"
            sqlString = Scripts.ListaAvaliacoesPaciente.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retornoListaAvaliacoesPaciente = this.Conexao.Query<RegistroEmissao>(sqlQuery);

            return retornoListaAvaliacoesPaciente;

        }

        public RegistroEmissao RecuperarRegistroEmissao(int aIdRegistroEmissao)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da projeção "RegistroEmissao"
            listaParametros.Add("@RegistroEmissao", aIdRegistroEmissao);

            // Recupera os dados da entidade "RegistroEmissao"
            sqlString = Scripts.DetalheAvaliacaoPaciente.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retornoRegistroEmissao = this.Conexao.FindWithQuery<RegistroEmissao>(sqlQuery);

            return retornoRegistroEmissao;

        }

        public void SalvarAvaliacao(RegistroEmissao aRegistroEmissao)
        {
            long registro = 0;
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros com os valores a serem inseridos na tabela "RegistroEmissao"           
            listaParametros.Add("@DataRegistroEmissao", aRegistroEmissao.DataRegistroEmissao);
            listaParametros.Add("@IndicadorEmissao", aRegistroEmissao.IndicadorEmissao);

            // Realiza insert na entidade "RegistroEmissao"
            sqlString = Scripts.SalvarAvaliacao.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            registro = this.Conexao.Execute(sqlQuery);

        }

        public void SalvarAvaliacao(int aIndicadorEmissao)
        {
            long registro = 0;
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros com os valores a serem inseridos na tabela "RegistroEmissao"           
            listaParametros.Add("@DataRegistroEmissao", DateTime.UtcNow);
            listaParametros.Add("@IndicadorEmissao", aIndicadorEmissao);

            // Realiza insert na entidade "RegistroEmissao"
            sqlString = Scripts.SalvarAvaliacao.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            registro = this.Conexao.Execute(sqlQuery);

        }
    }

}