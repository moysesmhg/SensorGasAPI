using SQLite;
using SQLiteNetExtensions.Attributes;
//using SQLiteNetExtensions.Attributes;

namespace SensorGasAPI.Negocio
{
    [Table("Usuario")]
    public class UsuarioDados
    {
        #region Construtores

        public UsuarioDados() { }

        #endregion

        #region Propriedades

        //TODO: Implementar uma page model de Usuários e retirar as propriedades das classes: PessoaDados, PacienteDados, ProfissionalDados e DadosAdicionaisDados
        [PrimaryKey, AutoIncrement]
        public long CodigoUsuario { get; set; }
        [ForeignKey(typeof(PessoaDados))]
        public long CodigoPessoa { get; set; }

        public string LoginUsuario { get; set; }

        public string SenhaUsuario { get; set; }

        public short TipoUsuario { get; set; }

        #endregion
    }
}
