using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SensorGasAPI.Negocio
{
    [Table("Estado")]
    public class EstadoDados
    {

        #region Construtores

        public EstadoDados() { }

        #endregion

        #region Propriedades

        [PrimaryKey, AutoIncrement]
        public short CodigoEstado { get; set; }
        public string AbreviacaoEstado { get; set; }
        public string DescricaoEstado { get; set; }

        #endregion
    }
}
