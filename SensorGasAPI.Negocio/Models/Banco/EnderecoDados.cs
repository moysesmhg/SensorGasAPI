using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorGasAPI.Negocio;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace SensorGasAPI.Negocio
{
    [Table("Endereco")]
    public class EnderecoDados
    {

        #region Construtores

        public EnderecoDados() { }

        #endregion

        #region Propriedades

        [PrimaryKey, AutoIncrement]
        public long CodigoEndereco { get; set; }
        [ForeignKey(typeof(PessoaDados))]
        public long CodigoPessoa { get; set; }
        public string LogradouroEndereco { get; set; }
        public int NumeroEndereco { get; set; }
        public string ComplementoEndereco { get; set; }
        public string BairroEndereco { get; set; }
        public string CepEndereco { get; set; }
        [ForeignKey(typeof(MunicipioDados))]
        public long CodigoMunicipio { get; set; }
        [ForeignKey(typeof(EstadoDados))]
        public long CodigoEstado { get; set; }
        public short TipoEndereco { get; set; }

        #endregion
    }
}
