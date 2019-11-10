using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace SensorGasAPI.Negocio
{
    [Table("CheckEmail")]
    public class CheckEmailDados
    {
        #region Construtores

        public CheckEmailDados() { }

        #endregion

        #region Propriedades

        [PrimaryKey, AutoIncrement]
        public long CodigoCheckEmail { get; set; }

        [ForeignKey(typeof(ConsultaDados))]
        public long CodigoConsulta { get; set; }


        #endregion
    }
}
