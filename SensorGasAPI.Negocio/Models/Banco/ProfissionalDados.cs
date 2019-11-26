using SQLite;
using SQLiteNetExtensions.Attributes;

namespace SensorGasAPI.Negocio
{
    [Table("Profissional")]
    public class ProfissionalDados
    {

        #region Construtores

        public ProfissionalDados()
        {
        }

        #endregion

        #region Propriedades

        [PrimaryKey, AutoIncrement]
        public long CodigoProfissional { get; set; }
        [ForeignKey(typeof(UsuarioDados))]
        public long CodigoUsuario { get; set; }

        #endregion

    }
}
