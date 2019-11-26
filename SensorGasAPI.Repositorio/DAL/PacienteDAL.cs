using SQLite;
using System.Collections.Generic;
using System.Text;
using SensorGasAPI.Negocio;
using SensorGasAPI.Repositorio.Resources.Scripts;

namespace SensorGasAPI.Repositorio
{
    public class PacienteDAL : RepositorioAncestral
    {
        public PacienteDAL()
        {
            this.Conexao = this.Conexao = FabricaConexao.CriarFabricas.sqliteConexao().GetConnection();
        }
        
        public string RecuperarNomePaciente(long aCodigoPaciente)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para recuperação do nome do paciente                  
            listaParametros.Add("@CodigoPaciente", aCodigoPaciente);

            // Recupera no nome do paciente
            sqlString = Scripts.RecuperarNomePaciente.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            var retornoUsuario = this.Conexao.FindWithQuery<PacienteProjecao>(sqlQuery).NomePaciente;

            return retornoUsuario;
        }

        // TODO: Mudar o nome da tabela "DadosAdicionais" para "Contato"
        public PacienteProjecao RecuperarContatoPaciente(long aCodigoPaciente)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros para recuperação do contato do paciente                  
            listaParametros.Add("@CodigoPaciente", aCodigoPaciente);

            // Recupera no contato do paciente
            sqlString = Scripts.RecuperarContatoPaciente.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);


            var retornoPaciente = this.Conexao.FindWithQuery<DadosAdicionaisDados>(sqlQuery);

            return new PacienteProjecao()
            {
                TelefonePaciente = "(" + retornoPaciente.DDDTelefoneDadosAdicionais + ") " + retornoPaciente.NumeroTelefoneDadosAdicionais,
                CelularPaciente = "(" + retornoPaciente.DDDCelularDadosAdicionais + ") " + retornoPaciente.NumeroCelularDadosAdicionais,
                EMailPaciente = retornoPaciente.EmailDadosAdicionais,

            };

        }

    }
}