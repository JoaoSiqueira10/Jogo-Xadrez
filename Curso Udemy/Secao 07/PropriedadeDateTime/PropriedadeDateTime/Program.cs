using System;

namespace PropriedadeDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);

            /*
            //propriedades
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date); //date time
            Console.WriteLine("2) Day: " + d.Day); //int
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek); //dayofweek
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear); //int
            Console.WriteLine("5) Hour: " + d.Hour); //int
            Console.WriteLine("6) Kind: " + d.Kind); //dateTimeKind
            Console.WriteLine("7) Millisecond: " + d.Millisecond); //int
            Console.WriteLine("8) Minute: " + d.Minute); //int
            Console.WriteLine("9) Month: " + d.Month); //int
            Console.WriteLine("10) Second: " + d.Second); //int
            Console.WriteLine("11) Ticks: " + d.Ticks); //long
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay); //timespan
            Console.WriteLine("13) Year: " + d.Year); //int
            */

            /*
            //formatacao (dateTime -> String)
            string s1 = d.ToLongDateString();
            string s2 = d.ToLongTimeString();
            string s3 = d.ToShortDateString();
            string s4 = d.ToShortTimeString();

            string s5 = d.ToString();
            
            string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);
            */


            //operacoes com dateTime
            /*
            DateTime x = new DateTime(2001, 8, 15, 13, 45, 58);
            DateTime y = x.Add(timeSpan);
            DateTime y = x.AddDays(double);
            DateTime y = x.AddHours(double);
            DateTime y = x.AddMilliseconds(double);
            DateTime y = x.AddMinutes(double);
            DateTime y = x.AddMonths(int);
            DateTime y = x.AddSeconds(double);
            DateTime y = x.AddTicks(long);
            DateTime y = x.AddYears(int);
            DateTime y = x.Subtract(timeSpan);
            TimeSpan t = x.Subtract(dateTime);
            */
        }
    }
}
