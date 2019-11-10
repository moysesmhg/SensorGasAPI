using SQLite;
using System.Collections.Generic;
using System.Text;
using SensorGasAPI.Negocio;
using SensorGasAPI.Repositorio.Resources.Scripts;
using System.Linq;

namespace SensorGasAPI.Repositorio
{
    public class CadastroUsuarioDAL : RepositorioAncestral
    {

        public CadastroUsuarioDAL()
        {
            this.Conexao = this.Conexao = FabricaConexao.CriarFabricas.sqliteConexao().GetConnection();
        }

        public long InsertCadastro(CadastroUsuarioProjecao aCadastroUsuario)
        {
            long registro = 0;
            string sqlQuery = null;
            string sqlString = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros da tabela "Pessoa"
            listaParametros.Add("@PrimeiroNomePessoa", aCadastroUsuario.Pessoa.PrimeiroNomePessoa);
            listaParametros.Add("@SobreNomePessoa", aCadastroUsuario.Pessoa.SobreNomePessoa);
            listaParametros.Add("@CPFPessoa", aCadastroUsuario.Pessoa.CPFPessoa);
            listaParametros.Add("@DataNascimentoPessoa", aCadastroUsuario.Pessoa.DataNascimentoPessoa);

            // Recupera e executa o insert da tabela "Pessoa"
            sqlString = Scripts.UsuarioInsertPessoa.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            registro = this.Conexao.Execute(sqlQuery);

            // Parâmetros da tabela "Usuario"            
            listaParametros.Add("@LoginUsuario", aCadastroUsuario.Usuario.LoginUsuario);
            listaParametros.Add("@SenhaUsuario", aCadastroUsuario.Usuario.SenhaUsuario);

            // Recupera e executa o insert da tabela "Usuario"
            sqlString = Scripts.UsuarioInsertUsuario.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            registro = this.Conexao.Execute(sqlQuery);

            // Recupera e executa o insert da tabela "Paciente"
            sqlString = Scripts.UsuarioInsertPaciente.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            registro = this.Conexao.Execute(sqlQuery);

            // Parâmetros da tabela "DadosAdicionais"
            listaParametros.Add("@DDDTelefoneDadosAdicionais", aCadastroUsuario.DadosAdicionais.DDDTelefoneDadosAdicionais);
            listaParametros.Add("@NumeroTelefoneDadosAdicionais", aCadastroUsuario.DadosAdicionais.NumeroTelefoneDadosAdicionais);
            listaParametros.Add("@DDDCelularDadosAdicionais", aCadastroUsuario.DadosAdicionais.DDDCelularDadosAdicionais);
            listaParametros.Add("@NumeroCelularDadosAdicionais", aCadastroUsuario.DadosAdicionais.NumeroCelularDadosAdicionais);
            listaParametros.Add("@EmailDadosAdicionais", aCadastroUsuario.DadosAdicionais.EmailDadosAdicionais);

            // Recupera e executa o insert da tabela "DadosAdicionais"
            sqlString = Scripts.UsuarioInsertDados.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            registro = this.Conexao.Execute(sqlQuery);

            // Executa o insert da tabela "Imagens"
            if (aCadastroUsuario.Imagens != null && !new object[] { null, 0 }.Contains(aCadastroUsuario.Imagens.CodigoUsuario))
            {
                this.Conexao.Insert(aCadastroUsuario.Imagens);
            }

            //this.Conexao.Close();

            return registro;
        }

        public long UpdateCadastro(CadastroUsuarioProjecao aCadastroProfissional)
        {
            StringBuilder _sqlExec = new StringBuilder();
            long registro = 0;

            //using (SqlConnection _conexao = new SqlConnection(GetStringConexao()))
            //{
            //    // TODO: Implementar SQL do UPDATE do cadastro de Usuários

            //    using (SqlCommand _comando = new SqlCommand(_sqlExec.ToString(), _conexao))
            //    {
            //        _comando.CommandType = CommandType.Text;
            //        //_comando.Parameters.AddWithValue("@codigo", aCadastroProfissional.CodigoClasseProfissional);
            //        //s_comando.Parameters.AddWithValue("@descricao", aCadastroProfissional.DescricaoClasseProfissional);

            //        // Abre a conexão
            //        _conexao.Open();
            //        registro = _comando.ExecuteNonQuery();
            //        _conexao.Close();

            //    }

            return registro;

            //}

        }


    }
}