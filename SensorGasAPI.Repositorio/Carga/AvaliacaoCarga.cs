using System;
using System.Linq;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Repositorio
{
    public class AvaliacaoCarga
    {

        public void CargaAvaliacao(long aCodigoPaciente, long aCodigoProfissional, short aSituacao, short aNota, string aDescricao)
        {

            var listaConsultas = new AvaliacaoDAL().ListaConsultasCargaAvaliacao(aCodigoPaciente, aCodigoProfissional);


            if (listaConsultas != null)
            {
                foreach (var consulta in listaConsultas)
                {
                    var avaliacao = new AvaliacaoDados()
                    {
                        CodigoConsulta = consulta.CodigoConsulta,
                        SituacaoAvaliacao = aSituacao,
                        NotaAvaliacao = aNota,
                        DescricaoAvaliacao = aDescricao,

                    };


                    new AvaliacaoDAL().SalvarAvaliacaoCarga(avaliacao);
                }
            }

        }

    }

}