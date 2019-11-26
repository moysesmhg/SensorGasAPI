using SQLite;
using System.Collections.Generic;
using System.Text;
using SensorGasAPI.Negocio;
using SensorGasAPI.Repositorio.Resources.Scripts;
using System.Linq;

namespace SensorGasAPI.Repositorio
{
    public class CadastroProfissionalDAL : RepositorioAncestral
    {
        public CadastroProfissionalDAL()
        {
            this.Conexao = this.Conexao = FabricaConexao.CriarFabricas.sqliteConexao().GetConnection();
        }

        public long InsertCadastro(CadastroProfissionalProjecao aCadastroProfissional)
        {
            long registro = 0;
            string sqlQuery = null;
            string sqlString = null;
            Dictionary<string, object> listaParametros = new Dictionary<string, object>();

            // Parâmetros da tabela "Pessoa"
            listaParametros.Add("@PrimeiroNomePessoa", aCadastroProfissional.Pessoa.PrimeiroNomePessoa);
            listaParametros.Add("@SobreNomePessoa", aCadastroProfissional.Pessoa.SobreNomePessoa);
            listaParametros.Add("@CPFPessoa", aCadastroProfissional.Pessoa.CPFPessoa);
            listaParametros.Add("@DataNascimentoPessoa", aCadastroProfissional.Pessoa.DataNascimentoPessoa);

            // Recupera e executa o insert da tabela "Pessoa"            
            sqlString = Scripts.ProfissionalInsertPessoa.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            registro = this.Conexao.Execute(sqlQuery);

            // Parâmetros da tabela "Usuario"            
            listaParametros.Add("@LoginUsuario", aCadastroProfissional.Usuario.LoginUsuario);
            listaParametros.Add("@SenhaUsuario", aCadastroProfissional.Usuario.SenhaUsuario);
            listaParametros.Add("@TipoUsuario", aCadastroProfissional.Usuario.TipoUsuario);

            // Recupera e executa o insert da tabela "Usuario"
            sqlString = Scripts.ProfissionalInsertUsuario.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            registro = this.Conexao.Execute(sqlQuery);

            // Recupera e executa o insert da tabela "Profissional"
            sqlString = Scripts.ProfissionalInsertProfissional.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            registro = this.Conexao.Execute(sqlQuery);

            // Recupera e executa o insert da tabela "Paciente"
            sqlString = Scripts.ProfissionalInsertPaciente.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            registro = this.Conexao.Execute(sqlQuery);

            // Insert da tabela "EnderecoMobile"
            listaParametros.Add("@LogradouroEndereco", aCadastroProfissional.Endereco.LogradouroEndereco);
            listaParametros.Add("@NumeroEndereco", aCadastroProfissional.Endereco.NumeroEndereco);
            listaParametros.Add("@ComplementoEndereco", aCadastroProfissional.Endereco.ComplementoEndereco);
            listaParametros.Add("@BairroEndereco", aCadastroProfissional.Endereco.BairroEndereco);
            listaParametros.Add("@CodigoMunicipio", aCadastroProfissional.Endereco.CodigoMunicipio);
            listaParametros.Add("@CodigoEstado", aCadastroProfissional.Endereco.CodigoEstado);
            listaParametros.Add("@CepEndereco", aCadastroProfissional.Endereco.CepEndereco);
            listaParametros.Add("@TipoEndereco", aCadastroProfissional.Endereco.TipoEndereco);

            // Recupera e executa o insert da tabela "EnderecoMobile"
            sqlString = Scripts.ProfissionalInsertEndereco.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            registro = this.Conexao.Execute(sqlQuery);

            // Insert na tabela "DadosAdicionais"           
            listaParametros.Add("@DDDTelefoneDadosAdicionais", aCadastroProfissional.DadosAdicionais.DDDTelefoneDadosAdicionais);
            listaParametros.Add("@NumeroTelefoneDadosAdicionais", aCadastroProfissional.DadosAdicionais.NumeroTelefoneDadosAdicionais);
            listaParametros.Add("@DDDCelularDadosAdicionais", aCadastroProfissional.DadosAdicionais.DDDCelularDadosAdicionais);
            listaParametros.Add("@NumeroCelularDadosAdicionais", aCadastroProfissional.DadosAdicionais.NumeroCelularDadosAdicionais);
            listaParametros.Add("@EmailDadosAdicionais", aCadastroProfissional.DadosAdicionais.EmailDadosAdicionais);

            // Recupera e executa o insert da tabela "DadosAdicionais"
            sqlString = Scripts.ProfissionalInsertDados.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            registro = this.Conexao.Execute(sqlQuery);

            // Insert na tabela "RelacaoProfissionalClasse"            
            listaParametros.Add("@ConselhoProfissional", aCadastroProfissional.ClasseProfissional.ConselhoProfissional);
            listaParametros.Add("@NumeroRegistroProfissional", aCadastroProfissional.RelacaoProfissionalClasse.NumeroRegistroProfissional);

            // Recupera e executa o insert da tabela "RelacaoProfissionalClasse"
            sqlString = Scripts.ProfissionalInsertRelacao.ToString();
            sqlQuery = RecuperarSQL(sqlString.ToString(), listaParametros);
            registro = this.Conexao.Execute(sqlQuery);

            // Executa o insert da tabela "Imagens"
            if (aCadastroProfissional.Imagens != null && !new object[] { null, 0 }.Contains(aCadastroProfissional.Imagens.CodigoUsuario))
            {
                this.Conexao.Insert(aCadastroProfissional.Imagens);
            }

            //this.Conexao.Close();

            return registro;
        }

        public long UpdateCadastro(CadastroProfissionalProjecao aCadastroProfissional)
        {
            StringBuilder _sqlExec = new StringBuilder();
            long registro = 0;


            //using (SqlConnection _conexao = new SqlConnection(GetStringConexao()))
            //{
            //    // TODO: Implementar SQL do UPDATE do cadastro de Profissionais

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