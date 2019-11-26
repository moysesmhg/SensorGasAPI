using System.Collections.Generic;
using SensorGasAPI.Negocio;
using System;
using SensorGasAPI.Repositorio.Resources.Scripts;

namespace SensorGasAPI.Repositorio
{
    public class AvaliacaoDAL : RepositorioAncestral
    {
        public AvaliacaoDAL()
        {
            
            //this.Conexao = this.Conexao = FabricaConexao.CriarFabricas.sqliteConexao().GetConnection();
            this.Conexao = FabricaConexao.CriarFabricas.sqliteConexao().GetConnection();
        }

        #region Carga

        public List<ListaAvaliacoesPacienteProjecao> ListaConsultasCargaAvaliacao(long aCodigoPaciente, long aCodigoProfissional)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da projeção "ListaAvaliacoesPacienteProjecao"
            listaParametros.Add("@CodigoPaciente", aCodigoPaciente);
            listaParametros.Add("@CodigoProfissional", aCodigoProfissional);

            // Recupera os dados da projeção "ListaAvaliacoesPacienteProjecao"
            sqlString = Scripts.ListaConsultasCargaAvaliacao.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retornoDadosConsulta = this.Conexao.Query<ListaAvaliacoesPacienteProjecao>(sqlQuery);            

            return retornoDadosConsulta;

        }

        public void SalvarAvaliacaoCarga(AvaliacaoDados aAvaliacaoPaciente)
        {
            long registro = 0;
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da projeção "AvaliacaoPacienteProjecao"
            listaParametros.Add("@CodigoConsulta", aAvaliacaoPaciente.CodigoConsulta);
            listaParametros.Add("@SituacaoAvaliacao", aAvaliacaoPaciente.SituacaoAvaliacao);
            listaParametros.Add("@NotaAvaliacao", aAvaliacaoPaciente.NotaAvaliacao);
            listaParametros.Add("@DescricaoAvaliacao", aAvaliacaoPaciente.DescricaoAvaliacao);

            // Recupera os dados da projeção "AvaliacaoPacienteProjecao"
            sqlString = Scripts.SalvarAvaliacao.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            registro = this.Conexao.Execute(sqlQuery);

        }

        #endregion

        #region Tela de Avaliação do Paciente

        public List<ListaAvaliacoesPacienteProjecao> ListaAvaliacoesPaciente(long aCodigoPaciente)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da projeção "ListaAvaliacoesPacienteProjecao"
            listaParametros.Add("@CodigoPaciente", aCodigoPaciente);
            listaParametros.Add("@HoraAtual", DateTime.Now.Hour.ToString().PadLeft(2, '0') + ":" + DateTime.Now.Minute.ToString().PadLeft(2, '0'));

            // Recupera os dados da projeção "ListaAvaliacoesPacienteProjecao"
            sqlString = Scripts.ListaAvaliacoesPaciente.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retornoDadosConsulta = this.Conexao.Query<ListaAvaliacoesPacienteProjecao>(sqlQuery);

            return retornoDadosConsulta;

        }

        public AvaliacaoPacienteProjecao RecuperarDetalheAvaliacao(long aCodigoConsulta)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da projeção "AvaliacaoPacienteProjecao"
            listaParametros.Add("@CodigoConsulta", aCodigoConsulta);

            // Recupera os dados da projeção "AvaliacaoPacienteProjecao"
            sqlString = Scripts.DetalheAvaliacaoPaciente.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retornoDadosConsulta = this.Conexao.FindWithQuery<AvaliacaoPacienteProjecao>(sqlQuery);

            return retornoDadosConsulta;

        }

        public void SalvarAvaliacao(AvaliacaoDados aAvaliacaoPaciente)
        {
            long registro = 0;
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da projeção "AvaliacaoPacienteProjecao"
            listaParametros.Add("@CodigoConsulta", aAvaliacaoPaciente.CodigoConsulta);
            listaParametros.Add("@SituacaoAvaliacao", aAvaliacaoPaciente.SituacaoAvaliacao);
            listaParametros.Add("@NotaAvaliacao", aAvaliacaoPaciente.NotaAvaliacao);
            listaParametros.Add("@DescricaoAvaliacao", aAvaliacaoPaciente.DescricaoAvaliacao);

            // Recupera os dados da projeção "AvaliacaoPacienteProjecao"
            sqlString = Scripts.SalvarAvaliacao.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            registro = this.Conexao.Execute(sqlQuery);

        }

        #endregion

        #region Tela de Reputação do Profissional

        public List<ListaReputacaoProjecao> ListaReputacao(long aCodigoProfissional)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da projeção "ListaReputacaoProjecao"
            listaParametros.Add("@CodigoProfissional", aCodigoProfissional);

            // Recupera os dados da projeção "ListaReputacaoProjecao"
            sqlString = Scripts.ListaReputacao.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retornoDadosConsulta = this.Conexao.Query<ListaReputacaoProjecao>(sqlQuery);

            return retornoDadosConsulta;

        }

        public ReputacaoProjecao RecuperarDetalheReputacao(long aCodigoConsulta)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da projeção "ReputacaoProjecao"
            listaParametros.Add("@CodigoConsulta", aCodigoConsulta);

            // Recupera os dados da projeção "ReputacaoProjecao"
            sqlString = Scripts.DetalheReputacao.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retornoDadosConsulta = this.Conexao.FindWithQuery<ReputacaoProjecao>(sqlQuery);

            return retornoDadosConsulta;

        }

        #endregion

        #region Tela de Detalhe do Profissional

        public NumerosProfissionalProjecao RecuperarNumerosProfissional(long aCodigoProfissional)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para a recuperação de dados da projeção "AvaliacaoPacienteProjecao"
            listaParametros.Add("@CodigoProfissional", aCodigoProfissional);

            // Recupera a classificação do Profissional
            sqlString = Scripts.ClassificacaoProfissional.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var classificacaoProfissional = this.Conexao.FindWithQuery<NumerosProfissionalProjecao>(sqlQuery);

            // Recupera a classificação do Profissional
            sqlString = Scripts.PacientesAtendidos.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var pacientesAtendidos = this.Conexao.FindWithQuery<NumerosProfissionalProjecao>(sqlQuery);


            var retornoDadosConsulta = new NumerosProfissionalProjecao()
            {
                ClassificacaoProfissional = classificacaoProfissional != null ? classificacaoProfissional.ClassificacaoProfissional : 0,
                PacientesAtendidos = pacientesAtendidos != null ? pacientesAtendidos.PacientesAtendidos : 0,
            };

            return retornoDadosConsulta;

        }

        #endregion


    }
}