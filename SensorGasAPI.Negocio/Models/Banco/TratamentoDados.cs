using System;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace SensorGasAPI.Negocio
{
    [Table("Tratamento")]
    public class TratamentoDados
    {

        #region Construtores

        public TratamentoDados() { }

        #endregion

        #region Propriedades
        
        [PrimaryKey, AutoIncrement]
        public long CodigoTratamento { get; set; }
        [ForeignKey(typeof(ConsultaDados))]
        public long CodigoConsulta { get; set; }
        public string NomeTratamento { get; set; }
        public string DescricaoTratamento { get; set; }
        public DateTime InicioTratamento { get; set; }
        public DateTime TerminoTratamento { get; set; }
        public short HoraInicio { get; set; }
        public short MinutoInicio { get; set; }
        public short FrequenciaDias { get; set; }
        public short FrequenciaHoras { get; set; }
        public int TratamentoAtivado { get; set; }

        #endregion

    }
}
