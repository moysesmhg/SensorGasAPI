using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SensorGasAPI.Negocio
{
    [Table("HorariosConsulta")]
    public class HorariosConsultaDados
    {
        #region Construtores

        public HorariosConsultaDados() { }

        #endregion

        #region Propriedades

        [PrimaryKey, AutoIncrement]
        public long Codigo { get; set; }

        #endregion
    }
}
