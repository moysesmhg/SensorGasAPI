using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace SensorGasAPI.Negocio
{
    [Table("RelacaoClasseEspecialidade")]
    public class RelacaoClasseEspecialidadeDados
    {

        #region Construtores

        public RelacaoClasseEspecialidadeDados() { }

        #endregion

        #region Propriedades

        [PrimaryKey, AutoIncrement]
        public long CodigoRelacaoClasseEspecialidade { get; set; }
        [ForeignKey(typeof(RelacaoProfissionalClasseDados))]
        public long CodigoRelacaoProfissionalClasse { get; set; }
        [ForeignKey(typeof(EspecialidadeDados))]
        public long CodigoEspecialidadeProfissional { get; set; }
        public long NumeroRegistroProfissional { get; set; }

        #endregion

    }
}
