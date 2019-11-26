using System;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace SensorGasAPI.Negocio
{
    [Table("Consulta")]
    public class ConsultaDados
    {
        #region Construtores

        public ConsultaDados() { }

        #endregion

        #region Propriedades

        [PrimaryKey, AutoIncrement]
        public long CodigoConsulta { get; set; }
        [ForeignKey(typeof(ProfissionalDados))]
        public long CodigoProfissional { get; set; }
        [ForeignKey(typeof(PacienteDados))]
        public long CodigoPaciente { get; set; }
        public int SituacaoConsulta { get; set; }
        public int TipoPagamentoConsulta { get; set; }
        public DateTime DataRealizacaoConsulta { get; set; }
        public int HoraInicialConsulta { get; set; }
        public int MinutoInicialConsulta { get; set; }
        public int HoraFinalConsulta { get; set; }
        public int MinutoFinalConsulta { get; set; }

        #endregion
    }
}
