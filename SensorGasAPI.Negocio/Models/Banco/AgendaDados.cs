using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace SensorGasAPI.Negocio
{
    [Table("Agenda")]
    public class AgendaDados
    {
        #region Construtores

        public AgendaDados() { }

        #endregion

        #region Propriedades

        [PrimaryKey, AutoIncrement]
        public long CodigoAgenda { get; set; }
        [ForeignKey(typeof(ProfissionalDados))]
        public long CodigoProfissional { get; set; }
        [ForeignKey(typeof(ConfiguracaoConsultaDados))]
        public long CodigoConfiguracaoConsulta { get; set; }
        [ForeignKey(typeof(ConfiguracaoHorarioDados))]
        public long CodigoConfiguracaoHorario { get; set; }
        public DateTime DataAgenda { get; set; }

        #endregion
    }
}
