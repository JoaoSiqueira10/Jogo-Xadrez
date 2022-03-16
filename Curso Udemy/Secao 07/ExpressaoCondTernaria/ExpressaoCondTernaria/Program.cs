using System;

namespace ExpressaoCondTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine());

            //                  (condicao) ? se for verdadeiro : se for falso;
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            //ou 
            /*
            if (preco < 20.0)
            {
                desconto = preco * 0.1;

            }
            else
            {
                desconto = preco * 0.05;
            }
            */
            Console.WriteLine(desconto);
        }

    }
}
