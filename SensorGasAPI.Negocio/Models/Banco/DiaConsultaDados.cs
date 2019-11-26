using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SensorGasAPI.Negocio
{
    [Table("DiaConsulta")]
    public class DiaConsultaDados
    {
        #region Construtores

        public DiaConsultaDados() { }

        #endregion

        #region Propriedades        
        public long CodigoDiaConsulta { get; set; }
        public string DescricaoDiaConsulta { get; set; }
        #endregion
    }
}
