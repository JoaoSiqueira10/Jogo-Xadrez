using System;

namespace Time_Span
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //(hora,min,seg)
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);
            */

            /*
            //construtores do timespan
            TimeSpan t1 = new TimeSpan();//padrão, duração 0
            TimeSpan t2 = new TimeSpan(900000000L);// 1:30 min
            TimeSpan t3 = new TimeSpan(2, 11, 21);//hora, minuto, segundo
            TimeSpan t4 = new TimeSpan(1, 2, 11, 21);//dia, hora, minuto, segundo
            TimeSpan t5 = new TimeSpan(1, 2, 11, 21, 321);//dia, hora, minuto, segundo, milisegundo

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            */

            //utilizando os metodos from
            //permite conversar na unidade que quer, podendo usar unidades quebradas
            TimeSpan t1 = TimeSpan.FromDays(1.5);
            TimeSpan t2 = TimeSpan.FromHours(1.5);
            TimeSpan t3 = TimeSpan.FromMinutes(1.5);
            TimeSpan t4 = TimeSpan.FromSeconds(1.5);
            TimeSpan t5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t6 = TimeSpan.FromTicks(900000000L);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);

        }
    }
}
