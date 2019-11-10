using System;
using System.Linq;

namespace SensorGasAPI.Repositorio
{
    public class GeradorUtilitario
    {

        public static string GerarCPF()
        {
            int soma = 0, resto = 0;
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            Random numeroAleatorio = new Random();
            string semente = numeroAleatorio.Next(100000000, 999999999).ToString();

            for (int i = 0; i < 9; i++)
                soma += int.Parse(semente[i].ToString()) * multiplicador1[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            semente = semente + resto;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(semente[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            semente = semente + resto;
            return semente;
        }

        public static DateTime GerarDataNascimento()
        {
            Random numeroAleatorio = new Random();
            var anoData = numeroAleatorio.Next(1947, 1999);
            var mesData = numeroAleatorio.Next(1, 12);
            var diaData = numeroAleatorio.Next(1, new int[] { 1, 3, 5, 7, 8, 10, 12 }.Contains(mesData) ? 31 : mesData != 2 ? 30 : 28);

            return new DateTime(anoData, mesData, diaData);
        }

        public static int GerarNumeroTelefoneCelular()
        {
            Random numeroAleatorio = new Random();
            int primeiroDigito = 9;
            int segundoDigito = numeroAleatorio.Next(7, 9);
            string restanteNumero = string.Empty;

            for (int i = 1; i < 8; i++)
            {
                restanteNumero += numeroAleatorio.Next(0, 9).ToString();
            }

            return Convert.ToInt32(string.Format("{0}{1}{2}", primeiroDigito, segundoDigito, restanteNumero));
        }

        public static int GerarNumeroTelefoneFixo()
        {
            Random numeroAleatorio = new Random();
            int primeiroDigito = 3;
            int segundoDigito = numeroAleatorio.Next(2, 6);
            string restanteNumero = string.Empty;

            for (int i = 1; i < 7; i++)
            {
                restanteNumero += numeroAleatorio.Next(0, 9).ToString();
            }

            return Convert.ToInt32(string.Format("{0}{1}{2}", primeiroDigito, segundoDigito, restanteNumero));
        }

        public static int GerarNumeroAleatorio(int quantidadeDigitos)
        {
            Random numeroAleatorio = new Random();
            string restanteNumero = string.Empty;

            for (int i = 1; i < quantidadeDigitos; i++)
            {
                restanteNumero += numeroAleatorio.Next(0, 9).ToString();
            }

            return Convert.ToInt32(restanteNumero);
        }

    }
}
