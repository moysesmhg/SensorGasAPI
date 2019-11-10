using SQLite;
using SQLiteNetExtensions.Attributes;

namespace SensorGasAPI.Negocio
{
    [Table("ConfiguracaoConsulta")]
    public class ConfiguracaoConsultaDados
    {
        #region Construtores

        public ConfiguracaoConsultaDados() { }

        #endregion

        #region Propriedades

        [PrimaryKey, AutoIncrement]
        public long CodigoConfiguracaoConsulta { get; set; }
        [ForeignKey(typeof(ProfissionalDados))]
        public long CodigoProfissional { get; set; }
        public decimal PrecoConsultaProfissional { get; set; }
        public short IntervaloConsultaProfissional { get; set; }

        #endregion
    }
}
