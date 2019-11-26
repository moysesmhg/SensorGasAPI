using SQLite;

namespace SensorGasAPI.Negocio
{
    [Table("ClasseProfissional")]
    public class ClasseProfissionalDados
    {
        #region Construtores

        public ClasseProfissionalDados() { }

        #endregion

        #region Propriedades
        [PrimaryKey, AutoIncrement]
        public long CodigoClasseProfissional { get; set; }
        public string DescricaoClasseProfissional { get; set; }
        public string ConselhoProfissional { get; set; }

        #endregion
    }
}
