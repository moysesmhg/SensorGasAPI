using System;
using System.Diagnostics;
using System.Threading;

namespace Utilitarios
{
    public class Eventos
    {
        public static void GravarEventos(string aMensagemEvento)
        {
            string sSource;
            string sLog;

            sSource = "MOBILE.WEB.API";
            sLog = "MOBILE.WEB.API";

            if (!EventLog.SourceExists(sSource))
                EventLog.CreateEventSource(sSource, sLog);

            EventLog.WriteEntry(sSource, aMensagemEvento);
            //EventLog.WriteEntry(sSource, aMensagemEvento,
            //EventLogEntryType.Warning, 234);
        }
    }
}