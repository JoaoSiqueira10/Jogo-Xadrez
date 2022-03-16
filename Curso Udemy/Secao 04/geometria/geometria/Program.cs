using System;

namespace geometria
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2"));
            Console.WriteLine("Volume: " + volume.ToString("F2"));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2"));
        }

       
    }
}
