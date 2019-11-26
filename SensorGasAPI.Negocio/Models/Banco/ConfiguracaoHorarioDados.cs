using SQLite;
using SQLiteNetExtensions.Attributes;

namespace SensorGasAPI.Negocio
{
    [Table("ConfiguracaoHorario")]
    public class ConfiguracaoHorarioDados
    {
        #region Construtores

        public ConfiguracaoHorarioDados() { }

        #endregion

        #region Propriedades
        [PrimaryKey, AutoIncrement]
        public long CodigoConfiguracaoHorario { get; set; }
        [ForeignKey(typeof(ProfissionalDados))]
        public long CodigoProfissional { get; set; }
        [ForeignKey(typeof(DiaConsultaDados))]
        public long CodigoDiaConsulta { get; set; }
        public int AtivacaoConfiguracaoHorario { get; set; }
        public int HoraInicialConfiguracaoHorario { get; set; }
        public int MinutoInicialConfiguracaoHorario { get; set; }
        public int HoraFinalConfiguracaoHorario { get; set; }
        public int MinutoFinalConfiguracaoHorario { get; set; }

        #endregion
    }
}
