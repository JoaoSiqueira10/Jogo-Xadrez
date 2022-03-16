using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto p;
            //Console.WriteLine(p); // erro: variável não atribuída
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);
            //ou
            
            p = new Ponto();
            Console.WriteLine(p);
            
        }
    }
}
