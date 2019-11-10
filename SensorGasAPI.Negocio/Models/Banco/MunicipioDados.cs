using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace SensorGasAPI.Negocio
{
    [Table("Municipio")]
    public class MunicipioDados
    {
        #region Construtores

        public MunicipioDados() { }

        #endregion

        #region Propriedades

        [PrimaryKey, AutoIncrement]
        public int CodigoMunicipio { get; set; }
        [ForeignKey(typeof(EstadoDados))]
        public long CodigoEstado { get; set; }
        public string DescricaoMunicipio { get; set; }

        #endregion
    }

}
