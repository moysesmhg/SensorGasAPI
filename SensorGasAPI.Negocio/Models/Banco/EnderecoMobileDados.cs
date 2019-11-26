using SQLite;
using SQLiteNetExtensions.Attributes;

namespace SensorGasAPI.Negocio
{
    [Table("EnderecoMobile")]
    public class EnderecoMobileDados
    {

        #region Construtores

        public EnderecoMobileDados() { }

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
        public string MunicipioEndereco { get; set; }
        public string AbreviacaoEstadoEndereco { get; set; }
        public string DescricaoEstadoEndereco { get; set; }
        public short TipoEndereco { get; set; }

        #endregion
    }
}
