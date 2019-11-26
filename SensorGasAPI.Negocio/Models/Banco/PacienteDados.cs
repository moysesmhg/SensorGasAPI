using SQLite;
using SQLiteNetExtensions.Attributes;

namespace SensorGasAPI.Negocio
{
    [Table("Paciente")]
    public class PacienteDados
    {
        #region Construtores

        public PacienteDados() { }

        #endregion

        #region Propriedades

        [PrimaryKey, AutoIncrement]
        public long CodigoPaciente { get; set; }
        [ForeignKey(typeof(PessoaDados))]
        public long CodigoUsuario { get; set; }

        #endregion
    }
}
