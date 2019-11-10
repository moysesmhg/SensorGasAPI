using SQLite;
using System.Collections.Generic;
using System.Text;
using SensorGasAPI.Negocio;
using System;
using System.Linq;
using SensorGasAPI.Repositorio.Resources.Scripts;

namespace SensorGasAPI.Repositorio
{
    public class ConsultaDAL : RepositorioAncestral
    {
        public ConsultaDAL()
        {
            this.Conexao = this.Conexao = FabricaConexao.CriarFabricas.sqliteConexao().GetConnection();
        }

        #region Tela de Configuração de Consulta

        public ConfiguracaoConsultaDados RecuperarDadosConsulta(long aCodigoProfissional)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da tabela "ConfiguracaoConsulta"
            listaParametros.Add("@CodigoProfissional", aCodigoProfissional);

            // Recupera os dados da tabela "Profissional"
            sqlString = Scripts.RecuperarDadosConsulta.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retornoDadosConsulta = this.Conexao.FindWithQuery<ConfiguracaoConsultaDados>(sqlQuery);

            return retornoDadosConsulta;

        }

        public int SalvarDadosConsulta(ConfiguracaoConsultaDados aDadosConsulta)
        {
            string queryString = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a atualização da tabela "ConfiguracaoConsulta"                    
            listaParametros.Add("@CodigoProfissional", aDadosConsulta.CodigoProfissional);
            listaParametros.Add("@PrecoConsultaProfissional", aDadosConsulta.PrecoConsultaProfissional);
            listaParametros.Add("@IntervaloConsultaProfissional", aDadosConsulta.IntervaloConsultaProfissional);

            // Verifica se o registro de dados de consulta já existe
            if (RecuperarDadosConsulta(aDadosConsulta.CodigoProfissional) != null)
            {
                queryString = Scripts.DadosConsultaUpdate.ToString();
            }
            else
            {
                queryString = Scripts.DadosConsultaInsert.ToString();
            }

            var sqlQuery = RecuperarSQL(queryString.ToString(), listaParametros);
            var contador = this.Conexao.Execute(sqlQuery);

            //ConfiguracaoConsulta teste = RecuperarDadosConsulta(aDadosConsulta.CodigoProfissional);

            return contador;
        }

        #endregion

        #region Tela de Configuração de Horários

        public List<ConfiguracaoHorarioDados> ListaDadosConfiguracaoHorario(long aCodigoProfissional)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da tabela "ConfiguracaoConsulta"
            listaParametros.Add("@CodigoProfissional", aCodigoProfissional);

            // Recupera os dados da tabela "Profissional"
            sqlString = Scripts.ListaDadosConfiguracaoHorario.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retornoDadosConsulta = this.Conexao.Query<ConfiguracaoHorarioDados>(sqlQuery);

            if (retornoDadosConsulta.Count == 0)
            {
                sqlString = Scripts.ConfiguracaoHorarioInsert.ToString();
                sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
                var contador = this.Conexao.Execute(sqlQuery);

                // Recupera os dados da tabela "Profissional"
                sqlString = Scripts.ListaDadosConfiguracaoHorario.ToString();
                sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
                retornoDadosConsulta = this.Conexao.Query<ConfiguracaoHorarioDados>(sqlQuery);
            }

            return retornoDadosConsulta;

        }

        public ConfiguracaoHorarioDados RecuperarDadosConfiguracaoHorario(long aCodigoProfissional, long aCodigoDiaConsulta)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da tabela "ConfiguracaoConsulta"
            listaParametros.Add("@CodigoProfissional", aCodigoProfissional);
            listaParametros.Add("@CodigoDiaConsulta", aCodigoDiaConsulta);

            // Recupera os dados da tabela "Profissional"
            sqlString = Scripts.RecuperarDadosConfiguracaoHorario.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retornoDadosConsulta = this.Conexao.FindWithQuery<ConfiguracaoHorarioDados>(sqlQuery);

            return retornoDadosConsulta;

        }

        public int SalvarDadosConfiguracaoHorario(ConfiguracaoHorarioDados aConfiguracaoHorarioDados)
        {
            string queryString = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            try
            {
                // Parâmetros para a atualização da tabela "ConfiguracaoConsulta"                    
                listaParametros.Add("@CodigoProfissional", aConfiguracaoHorarioDados.CodigoProfissional);
                listaParametros.Add("@CodigoDiaConsulta", aConfiguracaoHorarioDados.CodigoDiaConsulta);
                listaParametros.Add("@AtivacaoConfiguracaoHorario", aConfiguracaoHorarioDados.AtivacaoConfiguracaoHorario);
                listaParametros.Add("@HoraInicialConfiguracaoHorario", aConfiguracaoHorarioDados.HoraInicialConfiguracaoHorario);
                listaParametros.Add("@MinutoInicialConfiguracaoHorario", aConfiguracaoHorarioDados.MinutoInicialConfiguracaoHorario);
                listaParametros.Add("@HoraFinalConfiguracaoHorario", aConfiguracaoHorarioDados.HoraFinalConfiguracaoHorario);
                listaParametros.Add("@MinutoFinalConfiguracaoHorario", aConfiguracaoHorarioDados.MinutoFinalConfiguracaoHorario);

                //// Verifica se o registro de dados de consulta já existe
                //if (RecuperarDadosConfiguracaoHorario(aConfiguracaoHorarioDados.CodigoProfissional
                //                                    , aConfiguracaoHorarioDados.CodigoDiaConsulta) != null)
                //{
                //    queryString = Scripts.ConfiguracaoHorarioUpdate.ToString();
                //}
                //else
                //{
                //    queryString = Scripts.ConfiguracaoHorarioInsert.ToString();
                //}

                queryString = Scripts.ConfiguracaoHorarioUpdate.ToString();

                var sqlQuery = RecuperarSQL(queryString.ToString(), listaParametros);
                var contador = this.Conexao.Execute(sqlQuery);

                return contador;
            }
            catch (System.Exception excecao)
            {

                throw excecao;
            }
        }

        #endregion

        #region Cargas

        public int InsertDiaConsulta()
        {
            string queryString = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            queryString = Scripts.InsertDiaConsulta.ToString();

            var sqlQuery = RecuperarSQL(queryString.ToString(), listaParametros);
            var retorno = this.Conexao.Execute(sqlQuery);

            return retorno;
        }

        public void InsertConsulta(ConsultaDados aConfiguracaoHorario)
        {
            long registro = 0;
            string queryString = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a carga da tabela "Consulta"
            listaParametros.Add("@CodigoProfissional", aConfiguracaoHorario.CodigoProfissional);
            listaParametros.Add("@CodigoPaciente", aConfiguracaoHorario.CodigoPaciente);
            listaParametros.Add("@SituacaoConsulta", aConfiguracaoHorario.SituacaoConsulta);
            listaParametros.Add("@TipoPagamentoConsulta", aConfiguracaoHorario.TipoPagamentoConsulta);
            listaParametros.Add("@DataRealizacaoConsulta", aConfiguracaoHorario.DataRealizacaoConsulta.ToString("yyyy-MM-dd"));
            listaParametros.Add("@HoraInicialConsulta", aConfiguracaoHorario.HoraInicialConsulta);
            listaParametros.Add("@MinutoInicialConsulta", aConfiguracaoHorario.MinutoInicialConsulta);
            listaParametros.Add("@HoraFinalConsulta", aConfiguracaoHorario.HoraFinalConsulta);
            listaParametros.Add("@MinutoFinalConsulta", aConfiguracaoHorario.MinutoFinalConsulta);

            queryString = Scripts.CargaConsulta.ToString();

            var sqlQuery = RecuperarSQL(queryString.ToString(), listaParametros);
            registro = this.Conexao.Execute(sqlQuery);

        }

        #endregion

        #region Telas de Agenda

        public ConsultaDados VerificarExistenciaConsulta(ConsultaDados aConsultaDados)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da tabela "Consulta"
            listaParametros.Add("@CodigoProfissional", aConsultaDados.CodigoProfissional);
            listaParametros.Add("@DataRealizacaoConsulta", aConsultaDados.DataRealizacaoConsulta.ToString("yyyy-MM-dd"));
            listaParametros.Add("@HoraInicialConsulta", aConsultaDados.HoraInicialConsulta);
            listaParametros.Add("@MinutoInicialConsulta", aConsultaDados.MinutoInicialConsulta);
            listaParametros.Add("@HoraFinalConsulta", aConsultaDados.HoraFinalConsulta);
            listaParametros.Add("@MinutoFinalConsulta", aConsultaDados.MinutoFinalConsulta);

            // Recupera os dados da tabela "Consulta"
            sqlString = Scripts.VerificarExistenciaConsulta.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retornoDadosConsulta = this.Conexao.FindWithQuery<ConsultaDados>(sqlQuery);

            return retornoDadosConsulta;

        }

        public List<ConsultaDados> SelecionarConsultas(long aCodigoProfissional, string aDataSelecionadaCalendario)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da tabela "Consulta"
            listaParametros.Add("@CodigoProfissional", aCodigoProfissional);
            listaParametros.Add("@DataRealizacaoConsulta", aDataSelecionadaCalendario);

            // Recupera os dados da tabela "Consulta"
            sqlString = Scripts.SelecionarConsultas.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retornoDadosConsulta = this.Conexao.Query<ConsultaDados>(sqlQuery);

            return retornoDadosConsulta;

        }

        public List<ConsultaDados> SelecionarConsultasPaciente(long aCodigoProfissional, long aCodigoPaciente, string aDataSelecionadaCalendario)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da tabela "Consulta"
            listaParametros.Add("@CodigoProfissional", aCodigoProfissional);
            listaParametros.Add("@CodigoPaciente", aCodigoPaciente);
            listaParametros.Add("@DataRealizacaoConsulta", aDataSelecionadaCalendario);

            // Recupera os dados da tabela "Consulta"
            sqlString = Scripts.SelecionarConsultasPaciente.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retornoDadosConsulta = this.Conexao.Query<ConsultaDados>(sqlQuery);

            return retornoDadosConsulta;

        }

        public List<StatusDatasProjecao> BuscarSituacaoDatasConsulta(long aCodigoProfissional, string aDataInicio, string aDataFim)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da tabela "Consulta"
            listaParametros.Add("@CodigoProfissional", aCodigoProfissional);
            listaParametros.Add("@DataInicio", aDataInicio);
            listaParametros.Add("@DataFim", aDataFim);

            // Recupera os dados da tabela "Consulta"
            sqlString = Scripts.BuscarSituacaoDatasDoMes.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retornoDadosConsulta = this.Conexao.Query<StatusDatasProjecao>(sqlQuery);

            return retornoDadosConsulta;

        }

        public void AtualizarConsulta(ref ConsultaDados aConsulta)
        {
            long registro = 0;
            string sqlQuery = null;
            string sqlString = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros da tabela "Consulta"
            listaParametros.Add("@CodigoConsulta", aConsulta.CodigoConsulta);
            listaParametros.Add("@CodigoProfissional", aConsulta.CodigoProfissional);
            listaParametros.Add("@CodigoPaciente", aConsulta.CodigoPaciente);
            listaParametros.Add("@SituacaoConsulta", aConsulta.SituacaoConsulta);
            listaParametros.Add("@TipoPagamentoConsulta", aConsulta.TipoPagamentoConsulta);
            listaParametros.Add("@DataRealizacaoConsulta", aConsulta.DataRealizacaoConsulta.ToString("yyyy-MM-dd"));
            listaParametros.Add("@HoraInicialConsulta", aConsulta.HoraInicialConsulta);
            listaParametros.Add("@MinutoInicialConsulta", aConsulta.MinutoInicialConsulta);
            listaParametros.Add("@HoraFinalConsulta", aConsulta.HoraFinalConsulta);
            listaParametros.Add("@MinutoFinalConsulta", aConsulta.MinutoFinalConsulta);

            if (new long?[] { null, 0 }.Contains(aConsulta.CodigoConsulta))
            {
                // Recupera e executa o insert da tabela "Consultas"            
                sqlString = Scripts.ConsultaInsert.ToString();
            }
            else
            {
                // Recupera e executa o update da tabela "Consultas"            
                sqlString = Scripts.ConsultaUpdate.ToString();
            }


            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            registro = this.Conexao.Execute(sqlQuery);


            // TODO: Verificar em qual parte do fluxo é melhor para a recuperação do código de consulta
            sqlString = string.Empty;
            sqlString = Scripts.RecuperarCodigoConsulta.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            aConsulta.CodigoConsulta = this.Conexao.FindWithQuery<ConsultaDados>(sqlQuery).CodigoConsulta;

        }

        #endregion

        #region Tela Minhas Consultas

        public List<ListaMinhasConsultasProjecao> ListaMinhasConsultas(long aCodigoPaciente)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da projeção "ListaAvaliacoesPacienteProjecao"
            listaParametros.Add("@CodigoPaciente", aCodigoPaciente);

            // Recupera os dados da projeção "ListaMinhasConsultasProjecao"
            sqlString = Scripts.ListaMinhasConsultas.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retornoDadosConsulta = this.Conexao.Query<ListaMinhasConsultasProjecao>(sqlQuery);

            return retornoDadosConsulta;

        }

        public MinhasConsultasProjecao DetalheMinhasConsultas(long aCodigoConsulta)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da projeção "MinhasConsultasProjecao"
            listaParametros.Add("@CodigoConsulta", aCodigoConsulta);

            // Recupera os dados da projeção "MinhasConsultasProjecao"
            sqlString = Scripts.DetalheMinhaConsulta.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retornoDadosConsulta = this.Conexao.FindWithQuery<MinhasConsultasProjecao>(sqlQuery);

            return retornoDadosConsulta;

        }

        #endregion

        #region Tela Minhas Consultas

        public List<ListaGerenciarConsultasProjecao> ListaGerenciarConsultas(long aCodigoProfissional)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da projeção "ListaGerenciarConsultasProjecao"
            listaParametros.Add("@CodigoProfissional", aCodigoProfissional);

            // Recupera os dados da projeção "ListaGerenciarConsultasProjecao"
            sqlString = Scripts.ListaGerenciarConsultas.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retornoDadosConsulta = this.Conexao.Query<ListaGerenciarConsultasProjecao>(sqlQuery);

            return retornoDadosConsulta;

        }

        public DetalheGerenciarConsultasProjecao DetalheGerenciarConsultas(long aCodigoConsulta)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da projeção "DetalheGerenciarConsultasProjecao"
            listaParametros.Add("@CodigoConsulta", aCodigoConsulta);

            // Recupera os dados da projeção "DetalheGerenciarConsultasProjecao"
            sqlString = Scripts.DetalheGerenciarConsultas.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retornoDadosConsulta = this.Conexao.FindWithQuery<DetalheGerenciarConsultasProjecao>(sqlQuery);

            return retornoDadosConsulta;

        }

        #endregion

        #region Serviço de E-Mail

        public List<ConsultaServicoEmailProjecao> RecuperarConsultaServicoEmail(long aCodigoPaciente)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da projeção "ListaAvaliacoesPacienteProjecao"
            listaParametros.Add("@CodigoPaciente", aCodigoPaciente);

            // Recupera os dados da projeção "ListaAvaliacoesPacienteProjecao"
            sqlString = Scripts.RecuperarConsultaServicoEmail.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retornoDadosConsulta = this.Conexao.Query<ConsultaServicoEmailProjecao>(sqlQuery);

            return retornoDadosConsulta;

        }

        #endregion

    }
}