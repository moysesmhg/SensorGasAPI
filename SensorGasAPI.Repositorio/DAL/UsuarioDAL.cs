using SQLite;
using System.Collections.Generic;
using System.Text;
using SensorGasAPI.Negocio;
using SensorGasAPI.Repositorio.Resources.Scripts;

namespace SensorGasAPI.Repositorio
{
    public class UsuarioDAL : RepositorioAncestral
    {
        public UsuarioDAL()
        {
            this.Conexao = this.Conexao = FabricaConexao.CriarFabricas.sqliteConexao().GetConnection();
        }

        public LoginProjecao RecuperarLogin(UsuarioDados aUsuario)
        {
            string sqlString = null;
            string sqlQuery = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            try
            {

                if (CheckUsuario(aUsuario.LoginUsuario.Trim(), aUsuario.SenhaUsuario.Trim()) == 1)
                {

                    // Parâmetros para recuperação da tabela "Usuario"                    
                    listaParametros.Add("@LoginUsuario", aUsuario.LoginUsuario.Trim());
                    listaParametros.Add("@SenhaUsuario", aUsuario.SenhaUsuario.Trim());

                    // Recupera os dados da tabela "Usuario"
                    sqlString = Scripts.RecuperarUsuarioLogin.ToString();
                    sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
                    UsuarioDados retornoUsuario = this.Conexao.FindWithQuery<UsuarioDados>(sqlQuery);

                    // Parâmetros para recuperação da tabela "Pessoa"                    
                    listaParametros.Add("@CodigoPessoa", retornoUsuario.CodigoPessoa);

                    // Recupera os dados da tabela "Pessoa"
                    sqlString = Scripts.RecuperarPessoaLogin.ToString();
                    sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
                    PessoaDados retornoPessoa = this.Conexao.FindWithQuery<PessoaDados>(sqlQuery);

                    // Parâmetros para recuperação da tabela "Paciente"
                    listaParametros.Add("@CodigoUsuario", retornoUsuario.CodigoUsuario);                    

                    // Recupera os dados da tabela "Paciente"
                    sqlString = "SELECT * FROM Paciente WHERE CodigoUsuario = @CodigoUsuario ";
                    sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
                    PacienteDados retornoPaciente = this.Conexao.FindWithQuery<PacienteDados>(sqlQuery);

                    // Recupera os dados da tabela "Profissional"
                    sqlString = "SELECT * FROM Profissional WHERE CodigoUsuario = @CodigoUsuario ";
                    sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
                    ProfissionalDados retornoProfissional = this.Conexao.FindWithQuery<ProfissionalDados>(sqlQuery);

                    // Recupera os dados da tabela "DadosAdicionais"
                    sqlString = "SELECT * FROM DadosAdicionais WHERE CodigoPessoa = @CodigoPessoa ";
                    sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
                    DadosAdicionaisDados retornoDados = this.Conexao.FindWithQuery<DadosAdicionaisDados>(sqlQuery);
                    
                    // Recupera os dados da tabela "Imagens"
                    sqlString = "SELECT * FROM Imagens WHERE CodigoUsuario = @CodigoUsuario ";
                    sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
                    ImagensDados retornoImagens = this.Conexao.FindWithQuery<ImagensDados>(sqlQuery);

                    //this.Conexao.Close();

                    var retornoLogin = new LoginProjecao()
                    {
                        Imagens = retornoImagens,
                        Usuario = retornoUsuario,
                        Pessoa = retornoPessoa,
                        Paciente = retornoPaciente,
                        Profissional = retornoProfissional,
                        DadosAdicionais = retornoDados,
                    };

                    return retornoLogin;

                }

                return null;
            }
            catch (System.Exception excecao)
            {
                throw excecao;
            }
        }

        /// <summary>
        /// Realiza a validação de Usuário
        /// </summary>
        /// <param name="aLoginUsuario"></param>
        /// <param name="aSenhaUsuario"></param>
        /// <returns></returns>
        public int CheckUsuario(string aLoginUsuario, string aSenhaUsuario)
        {

            string query = Scripts.VerificarUsuario.ToString();
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros da validação de usuário                    
            listaParametros.Add("@LoginUsuario", aLoginUsuario.Trim());
            listaParametros.Add("@SenhaUsuario", aSenhaUsuario.Trim());

            var sqlQuery = RecuperarSQL(query.ToString(), listaParametros);

            var contador = this.Conexao.FindWithQuery<CheckLoginProjecao>(sqlQuery).QuantidadeLinhas;

            return contador;
        }

    }
}