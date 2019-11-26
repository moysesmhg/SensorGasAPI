using SQLite;
using SQLiteNetExtensions.Attributes;

namespace SensorGasAPI.Negocio
{
    [Table("Imagens")]
    public class ImagensDados
    {

        #region Construtores

        public ImagensDados() { }

        #endregion

        #region Propriedades

        [PrimaryKey, AutoIncrement]
        public long CodigoImagem { get; set; }
        [ForeignKey(typeof(UsuarioDados))]
        public long CodigoUsuario { get; set; }
        //[Column("BLOB")]
        public byte[] Imagem { get; set; }

        #endregion
    }
}
