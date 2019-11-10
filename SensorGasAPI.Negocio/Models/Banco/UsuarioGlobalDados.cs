using SQLite;
using SQLiteNetExtensions.Attributes;
//using SQLiteNetExtensions.Attributes;

namespace SensorGasAPI.Negocio
{
    [Table("UsuarioGlobal")]
    public class UsuarioGlobalDados
    {
        #region Construtores

        public UsuarioGlobalDados() { }

        #endregion

        #region Propriedades

        //TODO: Implementar uma page model de Usuários e retirar as propriedades das classes: PessoaDados, PacienteDados, ProfissionalDados e DadosAdicionaisDados
        [PrimaryKey, AutoIncrement]
        public long CodigoUsuarioGlobal { get; set; }       
        public long CodigoUsuario { get; set; }
        [ForeignKey(typeof(PessoaDados))]
        public long CodigoPaciente { get; set; }
        public string NomeUsuario { get; set; }
        public string LoginUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public short TipoUsuario { get; set; }
        public string EmailUsuario { get; set; }

        #endregion
    }
}
