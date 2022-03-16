using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        //exercicio de fixxacao
        static void Main(string[] args)
        {
            ContaBancaria conta;

            //p.Nome = "TV 4K";
            //Console.WriteLine(p.Nome);
            //Console.WriteLine(p.Preco);


            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Havera deposito inicial (s/n): ");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {

                Console.Write("Entre com o valor do deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, titular, depositoInicial);

            }
            else
            {
                conta = new ContaBancaria(numero, titular); 
            }
            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com o valor do deposito: ");
            double valor = double.Parse(Console.ReadLine());
            conta.Deposito(valor);
            Console.WriteLine("Dados da Conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com o valor do saque: ");
            valor = double.Parse(Console.ReadLine());
            conta.Saque(valor);
            Console.WriteLine("Dados da Conta atualizados:");
            Console.WriteLine(conta);

        }
    }
}