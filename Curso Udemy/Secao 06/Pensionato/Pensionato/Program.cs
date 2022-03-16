using System;

namespace Pensionato
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string email;
            int quarto;
            int n;

            Aluno[] vetor = new Aluno[10];

            Console.Write("Quantos quartos serao alugados? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Aluguel #{i+1}: ");
                Console.Write("Nome: ");
                nome = Console.ReadLine();
                Console.Write("E-mail: ");
                email = Console.ReadLine();
                Console.Write("Numero do Quarto: ");
                quarto = int.Parse(Console.ReadLine());
                vetor[quarto] = new Aluno(nome, email);
            }

            Console.WriteLine();
            Console.WriteLine("Quartos Ocupados:");
            for (int j = 0; j < 10; j++)
            {
                if(vetor[j] != null)
                {
                    Console.WriteLine(j + ": "+ vetor[j]);
                }
            }
            

        }
    }
}
