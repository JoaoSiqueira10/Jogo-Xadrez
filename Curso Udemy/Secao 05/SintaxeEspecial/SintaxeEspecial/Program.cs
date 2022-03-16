using System;
using System.Globalization;

namespace SintaxeEspecial
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //todos os argumentos foram colocados dentro do construtor
            Produto p = new Produto { 
                Nome = "TV", 
                Preco = 500.0, 
                Quantidade = 20
            };

            
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            
        }
    }
}
