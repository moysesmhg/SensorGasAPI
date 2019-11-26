using System;
using System.Linq;
using System.Collections.Generic;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Repositorio
{

    public class TratamentoCarga
    {


        public void CargaTratamento(long aCodigoPaciente, long aCodigoProfissional, string aNome, string aObservacao,
                                   DateTime aDataInicio, short aHoraInicio, short aMinutoInicio, short aFrequencia,
                                   short aIntervalo, short aTratamentoAtivado)
        {

            var listaConsultas = new AvaliacaoDAL().ListaConsultasCargaAvaliacao(aCodigoPaciente, aCodigoProfissional);


            if (listaConsultas != null)
            {
                foreach (var consulta in listaConsultas)
                {
                    var avaliacao = new TratamentoDados()
                    {
                        CodigoConsulta = consulta.CodigoConsulta,
                        NomeTratamento = aNome,
                        DescricaoTratamento = aObservacao,
                        InicioTratamento = aDataInicio,
                        TerminoTratamento = aDataInicio.AddDays(aFrequencia),
                        HoraInicio = aHoraInicio,
                        MinutoInicio = aMinutoInicio,
                        FrequenciaDias = aFrequencia,
                        FrequenciaHoras = aIntervalo,
                        TratamentoAtivado = aTratamentoAtivado,
                    };


                    new TratamentoDAL().SalvarTratamento(avaliacao);
                }
            }

        }

    }

}