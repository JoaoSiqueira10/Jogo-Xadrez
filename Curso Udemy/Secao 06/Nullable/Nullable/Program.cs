using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<double> x = null;
            //ou
            double? y = 10;
            //operador de coalescencia nula
            double? a = x ?? 5;
            double? b = y ?? 5;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());
            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            Console.WriteLine();

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }

            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
