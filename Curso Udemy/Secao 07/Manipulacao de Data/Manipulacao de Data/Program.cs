using System;
using System.Globalization;

namespace Manipulacao_de_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            DateTime d1 = DateTime.Now; //horario atual
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks); //O número de "ticks" (100 nanosegundos) desde a meia noite do dia 1 de janeiro do ano 1 da era comum
            */

            /*
            DateTime d1 = new DateTime(2022,03,08);
            DateTime d2 = new DateTime(2022, 03, 08,10,27,09); // (aaaa,mm,dd,hh,min,ss)
            DateTime d3 = new DateTime(2022, 03, 08, 10, 27, 09, 500); //ignora os milisegundos
            DateTime d4 = DateTime.Now; //agora
            DateTime d5 = DateTime.Today;//data de hoje com o horario zerado
            DateTime d6 = DateTime.UtcNow;//horario de GNT

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            */

            /*
            //converte string para datetime
            DateTime d1 = DateTime.Parse("2000-08-15");
            DateTime d2 = DateTime.Parse("2000-08-15 13:05:58");

            DateTime d3 = DateTime.Parse("15/08/2000");
            DateTime d4 = DateTime.Parse("15/08/2000 13:05:58");


            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            */

            //o programador escolhe o formato da data
            DateTime d1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd",CultureInfo.InvariantCulture);
            DateTime d2 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss",CultureInfo.InvariantCulture);
           
            Console.WriteLine(d1);
            Console.WriteLine(d2);





        }
    }
}
