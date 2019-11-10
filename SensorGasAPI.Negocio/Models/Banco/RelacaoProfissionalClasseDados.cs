using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace SensorGasAPI.Negocio
{
    [Table("RelacaoProfissionalClasse")]
    public class RelacaoProfissionalClasseDados
    {

        #region Construtores

        public RelacaoProfissionalClasseDados() { }

        #endregion

        #region Propriedades

        [PrimaryKey, AutoIncrement]
        public long CodigoRelacaoProfissionalClasse { get; set; }
        [ForeignKey(typeof(ProfissionalDados))]
        public long CodigoProfissional { get; set; }
        [ForeignKey(typeof(ClasseProfissionalDados))]
        public long CodigoClasseProfissional { get; set; }
        public long NumeroRegistroProfissional { get; set; }

        #endregion

    }
}
