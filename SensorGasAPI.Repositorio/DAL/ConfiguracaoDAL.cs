using SQLite;
using System.Collections.Generic;
using System.Text;
using SensorGasAPI.Negocio;
using System;
using SensorGasAPI.Repositorio.Resources.Scripts;

namespace SensorGasAPI.Repositorio
{
    public class ConfiguracaoDAL : RepositorioAncestral
    {
        public ConfiguracaoDAL()
        {
            this.Conexao = this.Conexao = FabricaConexao.CriarFabricas.sqliteConexao().GetConnection();
        }

        #region Carga

        public int InserirConfiguracaoHorarios(ConfiguracaoHorarioDados aConfiguracaoHorario)
        {
            string queryString = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            listaParametros.Add("@CodigoProfissional", aConfiguracaoHorario.CodigoProfissional);
            listaParametros.Add("@CodigoDiaConsulta", aConfiguracaoHorario.CodigoDiaConsulta);
            listaParametros.Add("@AtivacaoConfiguracaoHorario", aConfiguracaoHorario.AtivacaoConfiguracaoHorario);
            listaParametros.Add("@HoraInicialConfiguracaoHorario", aConfiguracaoHorario.HoraInicialConfiguracaoHorario);
            listaParametros.Add("@MinutoInicialConfiguracaoHorario", aConfiguracaoHorario.MinutoInicialConfiguracaoHorario);
            listaParametros.Add("@HoraFinalConfiguracaoHorario", aConfiguracaoHorario.HoraFinalConfiguracaoHorario);
            listaParametros.Add("@MinutoFinalConfiguracaoHorario", aConfiguracaoHorario.MinutoFinalConfiguracaoHorario);

            queryString = Scripts.CargaConfiguracaoHorario.ToString();

            var sqlQuery = RecuperarSQL(queryString.ToString(), listaParametros);
            var retorno = this.Conexao.Execute(sqlQuery);

            return retorno;
        }
        

        public int InserirConfiguracaoConsulta(ConfiguracaoConsultaDados aDadosConsulta)
        {
            string queryString = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            listaParametros.Add("@CodigoProfissional", aDadosConsulta.CodigoProfissional);
            listaParametros.Add("@PrecoConsultaProfissional", aDadosConsulta.PrecoConsultaProfissional);
            listaParametros.Add("@IntervaloConsultaProfissional", aDadosConsulta.IntervaloConsultaProfissional);

            queryString = Scripts.CargaConfiguracaoConsulta.ToString();

            var sqlQuery = RecuperarSQL(queryString.ToString(), listaParametros);
            var retorno = this.Conexao.Execute(sqlQuery);

            return retorno;
        }

        public List<ConfiguracaoHorarioDados> SelecionarConfiguracaoHorario(long aCodigoProfissional)
        {
            string queryString = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            listaParametros.Add("@CodigoProfissional", aCodigoProfissional);

            queryString = Scripts.SelecionarConfiguracaoHorario.ToString();

            var sqlQuery = RecuperarSQL(queryString.ToString(), listaParametros);
            var retorno = this.Conexao.Query<ConfiguracaoHorarioDados>(sqlQuery);

            return retorno;
        }

        #endregion

        #region Tela de Detalhe do Profissional

        public ConfiguracaoConsultaDados RecuperarPrecoConsulta(long aCodigoProfissional)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da projeção "AvaliacaoPacienteProjecao"
            listaParametros.Add("@CodigoProfissional", aCodigoProfissional);

            // Recupera os dados da projeção "AvaliacaoPacienteProjecao"
            sqlString = Scripts.RecuperarPrecoConsulta.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retornoDadosConsulta = this.Conexao.FindWithQuery<ConfiguracaoConsultaDados>(sqlQuery);

            return retornoDadosConsulta;

        }

        #endregion

    }

}