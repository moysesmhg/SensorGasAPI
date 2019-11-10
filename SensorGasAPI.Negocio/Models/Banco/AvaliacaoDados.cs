using System;
using System.Collections.Generic;
using System.Linq;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace SensorGasAPI.Negocio
{
    [Table("Avaliacao")]
    public class AvaliacaoDados
    {
        #region Construtores

        public AvaliacaoDados() { }

        #endregion

        #region Propriedades

        [PrimaryKey, AutoIncrement]
        public long CodigoAvaliacao { get; set; }
        [ForeignKey(typeof(ConsultaDados))]
        public long CodigoConsulta { get; set; }
        public short SituacaoAvaliacao { get; set; } // TODO: tipo booleano: na list vai indicar com algum icone se a avaliacao foi feita ou não. No detalhe irá bloquear as avaliações já feitas
        public short NotaAvaliacao { get; set; }
        public string DescricaoAvaliacao { get; set; }

        #endregion
    }
}
