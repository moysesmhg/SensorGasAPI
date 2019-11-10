using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace SensorGasAPI.Negocio
{
    [Table("DadosAdicionais")]
    public class DadosAdicionaisDados
    {
        #region Construtores

        public DadosAdicionaisDados() { }

        #endregion

        #region Propriedades

        [PrimaryKey, AutoIncrement]
        public long CodigoDadosAdicionais { get; set; }
        [ForeignKey(typeof(PessoaDados))]
        public long CodigoPessoa { get; set; }
        public short DDDTelefoneDadosAdicionais { get; set; }
        public int NumeroTelefoneDadosAdicionais { get; set; }
        public short DDDCelularDadosAdicionais { get; set; }
        public int NumeroCelularDadosAdicionais { get; set; }
        public string EmailDadosAdicionais { get; set; }

        #endregion
    }
}
