using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace SensorGasAPI.Negocio
{
    [Table("Pessoa")]
    public class PessoaDados
    {
        #region Construtores

        public PessoaDados() { }

        #endregion

        #region Propriedades

        [PrimaryKey, AutoIncrement]
        public long CodigoPessoa { get; set; }
        public string PrimeiroNomePessoa { get; set; }
        public string SobreNomePessoa { get; set; }
        public string SexoPessoa { get; set; }
        public string CPFPessoa { get; set; }
        public string DataNascimentoPessoa { get; set; }

        #endregion
    }
}
