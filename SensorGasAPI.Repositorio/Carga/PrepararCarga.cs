
using SensorGasAPI.Negocio;
using SQLite;
using System;
using System.Data;

namespace SensorGasAPI.Repositorio
{
    public class PrepararCarga
    {
        private SQLiteConnection Conexao { get; set; }

        public PrepararCarga() { }

        public void CriarTabelas()
        {
            try
            {
                FabricaConexao.CriarFabricas.sqliteConexao().ExcluirBase();
                this.Conexao = FabricaConexao.CriarFabricas.sqliteConexao().GetConnection();
                this.Conexao.CreateTable<PessoaDados>();
                this.Conexao.CreateTable<UsuarioDados>();
                this.Conexao.CreateTable<ProfissionalDados>();
                this.Conexao.CreateTable<PacienteDados>();
                this.Conexao.CreateTable<DadosAdicionaisDados>();
                this.Conexao.CreateTable<EnderecoDados>();
                this.Conexao.CreateTable<ClasseProfissionalDados>();
                this.Conexao.CreateTable<EspecialidadeDados>();
                this.Conexao.CreateTable<EstadoDados>();
                this.Conexao.CreateTable<MunicipioDados>();
                this.Conexao.CreateTable<RelacaoClasseEspecialidadeDados>();
                this.Conexao.CreateTable<RelacaoProfissionalClasseDados>();
                this.Conexao.CreateTable<ConfiguracaoHorarioDados>();
                this.Conexao.CreateTable<ConfiguracaoConsultaDados>();
                this.Conexao.CreateTable<DiaConsultaDados>();
                this.Conexao.CreateTable<ConsultaDados>();
                this.Conexao.CreateTable<AvaliacaoDados>();
                this.Conexao.CreateTable<TratamentoDados>();
                this.Conexao.CreateTable<ImagensDados>();
                // As tabelas a seguir são locais
                this.Conexao.CreateTable<CheckEmailDados>();
                this.Conexao.CreateTable<UsuarioGlobalDados>();

            }
            catch (System.Exception excecao)
            {
                throw excecao;
            }

        }


        public void RealizarCargas()
        {
            //this.Conexao = FabricaConexao.CriarFabricas.sqliteConexao().GetConnection();            
            this.Conexao.BeginTransaction();

            new ClasseProfissionalCarga().CargaClasses();
            new EspecialidadeProfissionalCarga().CargaEspecialidades();
            new EstadoDAL().InsertEstado();
            new MunicipioDAL().InsertMunicipio();
            new UsuarioCarga().InserirUsuarios();
            new ProfissionalCarga().InserirProfissionais();
            new EspecialidadeProfissionalCarga().InserirEspecialidadeDoProfissional();
            new ConsultaDAL().InsertDiaConsulta();
            new ConfiguracaoCarga().InserirConfiguracaoHorarios();
            new ConfiguracaoCarga().InserirConfiguracaoConsulta();
            new ConsultaCarga().InserirConsultas(1, 3, Convert.ToDateTime("2018-06-10"), 9, 0, 9, 30, SituacaoConsultaEnumerador.Realizada);
            new ConsultaCarga().InserirConsultas(1, 2, Convert.ToDateTime("2018-05-18"), 9, 0, 9, 30, SituacaoConsultaEnumerador.Realizada);
            new ConsultaCarga().InserirConsultas(2, 1, Convert.ToDateTime("2018-06-04"), 9, 0, 9, 30, SituacaoConsultaEnumerador.Realizada);
            new ConsultaCarga().InserirConsultas(3, 1, Convert.ToDateTime("2018-05-07"), 8, 0, 8, 30, SituacaoConsultaEnumerador.Realizada);
            new ConsultaCarga().InserirConsultas(4, 1, Convert.ToDateTime("2018-05-15"), 16, 0, 16, 30, SituacaoConsultaEnumerador.Realizada);
            new ConsultaCarga().InserirConsultas(5, 1, Convert.ToDateTime("2018-05-23"), 7, 0, 7, 30, SituacaoConsultaEnumerador.Realizada);
            new ConsultaCarga().InserirConsultas(6, 1, Convert.ToDateTime("2018-05-28"), 10, 0, 10, 30, SituacaoConsultaEnumerador.Realizada);
            new ConsultaCarga().InserirConsultas(7, 1, Convert.ToDateTime("2018-05-31"), 11, 0, 11, 30, SituacaoConsultaEnumerador.Realizada);
            new ConsultaCarga().InserirConsultas(8, 1, Convert.ToDateTime("2018-05-25"), 9, 30, 10, 0, SituacaoConsultaEnumerador.Realizada);
            new ConsultaCarga().InserirConsultas(9, 1, Convert.ToDateTime("2018-06-05"), 14, 30, 15, 0, SituacaoConsultaEnumerador.Realizada);
            new ConsultaCarga().InserirConsultas(10, 1, Convert.ToDateTime("2018-06-21"), 15, 30, 16, 0, SituacaoConsultaEnumerador.Realizada);
            new ConsultaCarga().InserirConsultas(13, 1, Convert.ToDateTime("2018-05-14"), 7, 30, 8, 0, SituacaoConsultaEnumerador.Realizada);

            new AvaliacaoCarga().CargaAvaliacao(1, 3, 1, 5, "Demonstra ter um grande domínio em sua área");
            new AvaliacaoCarga().CargaAvaliacao(1, 2, 1, 5, "Profissional muito competente.");
            new AvaliacaoCarga().CargaAvaliacao(2, 1, 1, 4, "Muito bom!");
            new AvaliacaoCarga().CargaAvaliacao(3, 1, 1, 5, "Ótimo");
            new AvaliacaoCarga().CargaAvaliacao(4, 1, 1, 4, "Muito bom!");
            new AvaliacaoCarga().CargaAvaliacao(5, 1, 1, 5, "Ótimo, recomendo!");
            new AvaliacaoCarga().CargaAvaliacao(6, 1, 1, 5, "Excelente!");
            new AvaliacaoCarga().CargaAvaliacao(7, 1, 1, 3, "Achei bom, mas acho que podia ser mais atencioso");
            new AvaliacaoCarga().CargaAvaliacao(8, 1, 1, 5, "Muito atencioso, demonstra ter bom domínio e competência");
            new AvaliacaoCarga().CargaAvaliacao(9, 1, 1, 4, "Excelente!");
            new AvaliacaoCarga().CargaAvaliacao(10, 1, 1, 5, "Recomendo!");
            new AvaliacaoCarga().CargaAvaliacao(13, 1, 1, 4, "Muito bom");

            this.Conexao.Commit();
            //this.Conexao.Close();
        }

    }

}