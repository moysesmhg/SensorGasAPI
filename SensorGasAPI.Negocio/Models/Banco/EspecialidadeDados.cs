using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace SensorGasAPI.Negocio
{
    [Table("EspecialidadeProfissional")]
    public class EspecialidadeDados
    {
        #region Construtores

        public EspecialidadeDados() { }

        #endregion

        #region Propriedades

        [PrimaryKey, AutoIncrement]
        public long CodigoEspecialidadeProfissional { get; set; }
        // TODO: Verificar a necessiadade de existir esta propriedade
        [ForeignKey(typeof(ClasseProfissionalDados))]
        public long CodigoClasseProfissional { get; set; }
        public string DescricaoEspecialidadeProfissional { get; set; }

        #endregion
    }
}
