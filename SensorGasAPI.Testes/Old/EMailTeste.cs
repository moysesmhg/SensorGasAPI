using System;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SensorGasAPI.Testes
{
    [TestClass]
    public class EMailTeste
    {

        [TestMethod]
        public async Task LoginAsync()
        {

            var parametrosEMail = new
            {
                eMailDestino = $"moysesmhg@gmail.com",
                nomeSolicitante = $"Moisés Domingos",
                codigoSituacao = $"2",
                descricaoSituacao = $"Confirmada",
                dataConsulta = $"01/01/2018",
                horarioConsulta = $"08:00",
                eMailAssunto = $"Resultado da Solicitação de Consulta",
                eMailPrioridade = true,
            };

            var value = JsonConvert.SerializeObject(parametrosEMail);
            var request = new HttpRequestMessage();
            request.Content = new StringContent(value, Encoding.UTF8, "application/json");

           await Teste.Run(request);
            

            //assert
            Assert.IsNotNull(1);

        }       

    }

    public class Teste
    {

        public static async Task<object> Run(HttpRequestMessage req)
        {
            /*  @@@ DESSERIALIZAÇÃO DOS PARÂMETROS RECEBIDOS @@@ ****/
            string parametrosJson = await req.Content.ReadAsStringAsync();
            dynamic parametros = JsonConvert.DeserializeObject(parametrosJson);

            /*  @@@ CONFIGURAÇÂO DE CONEXÃO DO HOST DE E-MAIL @@@ */
            // E-Mail de Origem
            string eMailOrigem = "mdj.domingos.junior@gmail.com";
            // E-Mail de Destino
            string eMailDestino = parametros.eMailDestino.ToString();
            // Host do Host de E-Mail
            string host = "smtp.sendgrid.net";
            // Usuário do Host de E-Mail
            string eMailUsuario = "azure_faa6256349a29e7e515fe887883f70ec@azure.com";
            // Senha do Host de E-Mail
            string eMailSenha = "tccMobileEmail09";

            MailMessage mail = new MailMessage(eMailOrigem, eMailDestino);
            SmtpClient clientEMail = new SmtpClient();
            clientEMail.Port = 587;
            clientEMail.EnableSsl = true;
            clientEMail.DeliveryMethod = SmtpDeliveryMethod.Network;
            clientEMail.UseDefaultCredentials = false;
            clientEMail.Host = host;
            clientEMail.Credentials = new System.Net.NetworkCredential(eMailUsuario, eMailSenha);

            // Assunto do E-Mail
            mail.Subject = parametros.eMailAssunto.ToString();

            // Corpo do Email
            StringBuilder dataHorario = new StringBuilder();

            if (parametros.codigoSituacao.ToString() == "2")
            {
                dataHorario.AppendFormat("Data da Consulta: {0}\r\n", parametros.dataConsulta.ToString());
                dataHorario.AppendFormat("Horário: {0}\r\n\n", parametros.horarioConsulta.ToString());
            }

            StringBuilder eMailMensagem = new StringBuilder();
            eMailMensagem.AppendFormat("Prezado(a) {0}, \r\n\n", parametros.nomeSolicitante.ToString());
            eMailMensagem.AppendFormat("A sua solicitação de consulta foi {0}. \r\n", parametros.descricaoSituacao.ToString());
            eMailMensagem.AppendFormat(dataHorario.ToString());
            eMailMensagem.AppendFormat("Atenciosamente, \r\nEquipe Doc2Mobile");

            mail.Body = eMailMensagem.ToString();

            // Define se o E-Mail será prioritário
            if (bool.Parse(parametros.eMailPrioridade.ToString()))
            {
                mail.Priority = MailPriority.High;
            }

            /*  @@@ ENVIO DO E-MAIL @@@ */
            try
            {
                clientEMail.Send(mail);
                //log.Verbose("O E-Mail foi enviado.");
                return req.CreateResponse(HttpStatusCode.OK, new
                {
                    status = true,
                    eMailMensagem = string.Empty
                });
            }
            /*  @@@ TRATAMENTO DE EXCECÃO@@@ */
            catch (Exception excecao)
            {
                throw excecao;
                ////log.Verbose(excecao.ToString());
                //return req.CreateResponse(HttpStatusCode.InternalServerError, new
                //{
                //    status = false,
                //    eMailMensagem = "O E-Mail não foi enviado."
                //});

            }
        }
    }
}

