using System;
using System.Collections.Generic;
using System.Linq;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace SensorGasAPI.Negocio
{
    [Table("RegistroEmissao")]
    public class RegistroEmissao
    {
        #region Construtores

        public RegistroEmissao() { }

        #endregion

        #region Propriedades

        [PrimaryKey, AutoIncrement]
        public int IdRegistroEmissao { get; set; }
        public DateTime DataRegistroEmissao { get; set; }
        public int IndicadorEmissao { get; set; } // 0: Indica Nível Normal de Gás | 1: Indica Nível de Vazamento de Gás

        #endregion
    }
}
