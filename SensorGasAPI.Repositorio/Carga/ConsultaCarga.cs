using System;
using System.Linq;
using System.Collections.Generic;
using SensorGasAPI.Negocio;

namespace SensorGasAPI.Repositorio
{
    public class ConsultaCarga
    {

        public void InserirConsultas(long aCodigoPaciente,
                             long aCodigoProfissional,
                             DateTime aDataConsulta,
                             int aHoraInicio,
                             int aMinutoInicio,
                             int aHoraFim,
                             int aMinutoFim,
                             SituacaoConsultaEnumerador aSituacao)
        {

            for (int i = 1; i < 2; i++)
            {
                //var codigoProfissional = new int[] { 1 }.OrderBy(a => Guid.NewGuid()).FirstOrDefault();

                //// fazer select da configuração de horário do profissional escolhido
                //var configuracao = new ConfiguracaoDAL().SelecionarConfiguracaoHorario(aCodigoProfissional).OrderBy(a => Guid.NewGuid()).FirstOrDefault();

                //// gerar data
                ////var dataRealizacao = GerarData(configuracao);

                //// gerar o horario da consulta
                //Random numeroAleatorio = new Random();
                //var listaHorariosGerados = new List<AgendaConsultaProfissionalProjecao>();
                //var minutosDataInicio = (configuracao.HoraInicialConfiguracaoHorario * 60) + configuracao.MinutoInicialConfiguracaoHorario;
                //var minutosDataFim = (configuracao.HoraFinalConfiguracaoHorario * 60) + configuracao.MinutoFinalConfiguracaoHorario;
                //minutosDataFim = minutosDataFim == 0 ? 1440 : minutosDataFim;

                //var dadosConsulta = new ConsultaDAL().RecuperarDadosConsulta(aCodigoProfissional);

                //while (minutosDataFim > minutosDataInicio)
                //{
                //    var horaInicioConsulta = minutosDataInicio / 60;
                //    var minutoInicioConsulta = minutosDataInicio % 60;

                //    minutosDataInicio = minutosDataInicio + dadosConsulta.IntervaloConsultaProfissional;

                //    if (minutosDataInicio > minutosDataFim)
                //    {
                //        minutosDataInicio = minutosDataFim;
                //    }

                //    var horaFimConsulta = minutosDataInicio / 60;
                //    var minutoFimConsulta = minutosDataInicio % 60;


                //    var recuperarConsulta = new ConsultaDAL().VerificarExistenciaConsulta(new ConsultaDados()
                //    {
                //        CodigoProfissional = aCodigoProfissional,
                //        DataRealizacaoConsulta = aDataConsulta,
                //        HoraInicialConsulta = aHoraInicio,
                //        MinutoInicialConsulta = aMinutoInicio,
                //        HoraFinalConsulta = aHoraFim,
                //        MinutoFinalConsulta = aMinutoFim
                //    });

                //    if (recuperarConsulta == null)
                //    {
                //        listaHorariosGerados.Add(new AgendaConsultaProfissionalProjecao()
                //        {
                //            CodigoProfissional = aCodigoProfissional,
                //            CodigoPaciente = aCodigoPaciente,
                //            SituacaoConsulta = (int)SituacaoConsultaEnumerador.Aberta,
                //            TipoPagamentoConsulta = 1,
                //            DataRealizacaoConsulta = aDataConsulta,
                //            HoraInicio = horaInicioConsulta.ToString(),
                //            MinutoInicio = minutoInicioConsulta.ToString(),
                //            HoraFim = horaFimConsulta.ToString(),
                //            MinutoFim = minutoFimConsulta.ToString(),
                //        });
                //    }
                //}

                //var horarioGerado = listaHorariosGerados[numeroAleatorio.Next(0, listaHorariosGerados.Count - 1)];

                var configuracaoHorario = new ConsultaDados()
                {
                    CodigoProfissional = aCodigoProfissional,
                    CodigoPaciente = aCodigoPaciente,
                    SituacaoConsulta = (int)aSituacao,
                    TipoPagamentoConsulta = 1,
                    DataRealizacaoConsulta = aDataConsulta,
                    HoraInicialConsulta = aHoraInicio,
                    MinutoInicialConsulta = aMinutoInicio,
                    HoraFinalConsulta = aHoraFim,
                    MinutoFinalConsulta = aMinutoFim,
                };

                new ConsultaDAL().InsertConsulta(configuracaoHorario);

            }

        }

        public DateTime GerarData(ConfiguracaoHorarioDados aConfiguracao)
        {
            var diaSemana = aConfiguracao.CodigoDiaConsulta - 1;

            Random numeroAleatorio = new Random();
            var ano = new int[] { 2018 }.OrderBy(a => Guid.NewGuid()).FirstOrDefault();
            var mes = new int[] { 6 }.OrderBy(a => Guid.NewGuid()).FirstOrDefault();
            var dia = numeroAleatorio.Next(18, new int[] { 1, 3, 5, 7, 8, 10, 12 }.Contains(mes) ? 18 : 18);

            //var data = DateTime.Now.AddDays(2);
            var data = new DateTime(ano, mes, dia);

            //while (data.DayOfWeek != (DayOfWeek)diaSemana)
            //{
            //    ano = new int[] { 2018 }.OrderBy(a => Guid.NewGuid()).FirstOrDefault();
            //    mes = new int[] { 6 }.OrderBy(a => Guid.NewGuid()).FirstOrDefault();
            //    dia = numeroAleatorio.Next(1, new int[] { 1, 3, 5, 7, 8, 10, 12 }.Contains(mes) ? 31 : 30);

            //    data = new DateTime(ano, mes, dia);
            //}

            return data;
        }

    }

}