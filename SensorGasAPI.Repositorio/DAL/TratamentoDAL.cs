using SQLite;
using System.Collections.Generic;
using System.Text;
using SensorGasAPI.Negocio;
using SensorGasAPI.Repositorio.Resources.Scripts;
using System.Linq;

namespace SensorGasAPI.Repositorio
{
    public class TratamentoDAL : RepositorioAncestral
    {
        public TratamentoDAL()
        {
            this.Conexao = this.Conexao = FabricaConexao.CriarFabricas.sqliteConexao().GetConnection();
        }

        #region Tela Definir Tratamento

        public List<ListaTratamentoProjecao> ListaDefinirTratamento(long aCodigoPaciente)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da projeção "ListaTratamentoProjecao"
            listaParametros.Add("@CodigoPaciente", aCodigoPaciente);

            // Recupera os dados da projeção "ListaTratamentoProjecao"
            sqlString = Scripts.ListaDefinirTratamento.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retornoDadosConsulta = this.Conexao.Query<ListaTratamentoProjecao>(sqlQuery);

            return retornoDadosConsulta;

        }

        public DetalheTratamentoProjecao DetalheTratamento(long aCodigoConsulta)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da projeção "DetalheTratamentoProjecao"
            listaParametros.Add("@CodigoConsulta", aCodigoConsulta);

            // Recupera os dados da projeção "DetalheTratamentoProjecao"
            sqlString = Scripts.DetalheTratamento.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retornoDadosConsulta = this.Conexao.FindWithQuery<DetalheTratamentoProjecao>(sqlQuery);

            return retornoDadosConsulta;

        }

        public void SalvarTratamento(TratamentoDados aTratamento)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da projeção "DetalheTratamentoProjecao"
            listaParametros.Add("@CodigoTratamento", aTratamento.CodigoTratamento);
            listaParametros.Add("@CodigoConsulta", aTratamento.CodigoConsulta);
            listaParametros.Add("@NomeTratamento", aTratamento.NomeTratamento);
            listaParametros.Add("@DescricaoTratamento", aTratamento.DescricaoTratamento);
            listaParametros.Add("@InicioTratamento", aTratamento.InicioTratamento);
            listaParametros.Add("@TerminoTratamento", aTratamento.TerminoTratamento);
            listaParametros.Add("@HoraInicio", aTratamento.HoraInicio);
            listaParametros.Add("@MinutoInicio", aTratamento.MinutoInicio);
            listaParametros.Add("@FrequenciaDias", aTratamento.FrequenciaDias);
            listaParametros.Add("@FrequenciaHoras", aTratamento.FrequenciaHoras);
            listaParametros.Add("@TratamentoAtivado", aTratamento.TratamentoAtivado);


            if (new long?[] { null, 0 }.Contains(aTratamento.CodigoTratamento))
            {
                // Recupera e executa o insert da tabela "Tratamento"            
                sqlString = Scripts.InsertTratamento.ToString();
            }
            else
            {
                // Recupera e executa o update da tabela "Tratamento"            
                sqlString = Scripts.UpdateTratamento.ToString();
            }

            // Recupera os dados da projeção "DetalheTratamentoProjecao"            
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retornoDadosConsulta = this.Conexao.FindWithQuery<DetalheTratamentoProjecao>(sqlQuery);

        }

        #endregion

        #region Aviso Tratamento

        public List<TratamentoDados> ListaTratamentosAviso(long aCodigoPaciente)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da projeção "ListaTratamentoProjecao"
            listaParametros.Add("@CodigoPaciente", aCodigoPaciente);

            // Recupera os dados da projeção "ListaTratamentoProjecao"
            sqlString = Scripts.ListaTratamentosAviso.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retornoDadosConsulta = this.Conexao.Query<TratamentoDados>(sqlQuery);

            return retornoDadosConsulta;

        }

        #endregion

    }
}