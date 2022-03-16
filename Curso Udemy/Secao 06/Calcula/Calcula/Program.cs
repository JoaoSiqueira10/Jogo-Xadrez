using System;

namespace Calcula
{
    class Program
    {
        static void Main(string[] args)
        {
            //solucao usando sobrecarga
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 4, 3);

            Console.WriteLine("Solucao com sobrecarga:");
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            //solucao com vetor
            //instanciacao de vetor um pouco feia
            int s3 = Calculator.Som(new int[] { 10, 20, 30, 40 });
            int s4 = Calculator.Som(new int[] { 10, 20, 30});

            Console.WriteLine();
            Console.WriteLine("Solucao com Vetor:");
            Console.WriteLine(s3);
            Console.WriteLine(s4);

            //solucao com modificador params
            int s5 = Calculator.Soma(10, 20, 30, 40);
            int s6 = Calculator.Soma(10, 25, 40);

            Console.WriteLine();
            Console.WriteLine("Solucao com modificador 'params': ");
            Console.WriteLine(s5);
            Console.WriteLine(s6);

            //solucao sem modificador
            //multiplicacao
            int a = 10;
            Calculator.Triple(a);
           
            Console.WriteLine();
            Console.WriteLine("Solucao sem modificador:");
            Console.WriteLine(a);


            //solucao com modificador ref
            //multiplicacao
            //a varaivel passada como parametro 'ref' DEVE ter sido iniciada
            int b = 10;
            Calculator.Triplo(ref b);
            
            Console.WriteLine();
            Console.WriteLine("Solucao com modificador 'ref': ");
            Console.WriteLine(b);

            //solucao com modificador out
            //multiplicacao
            //a variavel passada como parametro 'out' nao precisa ter sido iniciada
            int c = 10;
            int triple;
            Calculator.Tri(c, out triple);

            Console.WriteLine();
            Console.WriteLine("Solucao com modificador 'out': ");
            Console.WriteLine(triple);

            //conclusao sobre 'ref' e 'out', ambos sao muito similares, mas o ref é uma forma de fazer o complilador obrigar o usuarioa iniciar a variavel
            //Nota: ambos sao considerados "code smells"(desing ruim) e devem ser evitados
        }
    }
}
