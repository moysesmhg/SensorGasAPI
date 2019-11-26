using System;
using System.Linq;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Repositorio
{
    public class ConfiguracaoCarga
    {

        public void InserirConfiguracaoHorarios()
        {

            for (int i = 1; i <= 10; i++)
            {

                for (int j = 1; j <= 7; j++)
                {
                    var configuracaoHorario = new ConfiguracaoHorarioDados()
                    {
                        CodigoProfissional = i,
                        CodigoDiaConsulta = j, //new int[] { 1, 2, 3, 4, 5, 6, 7 }.OrderBy(j => Guid.NewGuid()).FirstOrDefault(),
                        AtivacaoConfiguracaoHorario = j == 1 || j == 7 ? 0 : 1,
                        HoraInicialConfiguracaoHorario = new int[] { 7 }.OrderBy(a => Guid.NewGuid()).FirstOrDefault(),
                        MinutoInicialConfiguracaoHorario = new int[] { 0 }.OrderBy(a => Guid.NewGuid()).FirstOrDefault(),
                        HoraFinalConfiguracaoHorario = new int[] { 18 }.OrderBy(a => Guid.NewGuid()).FirstOrDefault(),
                        MinutoFinalConfiguracaoHorario = new int[] { 0, }.OrderBy(a => Guid.NewGuid()).FirstOrDefault(),
                    };

                    new ConfiguracaoDAL().InserirConfiguracaoHorarios(configuracaoHorario);
                }

            }

        }

        public void InserirConfiguracaoConsulta()
        {

            for (int i = 1; i < 10; i++)
            {
                var dadosConsulta = new ConfiguracaoConsultaDados()
                {
                    CodigoProfissional = i,
                    PrecoConsultaProfissional = new int[] { 200 }.OrderBy(j => Guid.NewGuid()).FirstOrDefault(),
                    IntervaloConsultaProfissional = (short)new int[] { 30 }.OrderBy(j => Guid.NewGuid()).FirstOrDefault(),
                };

                new ConfiguracaoDAL().InserirConfiguracaoConsulta(dadosConsulta);
            }

        }

    }

}