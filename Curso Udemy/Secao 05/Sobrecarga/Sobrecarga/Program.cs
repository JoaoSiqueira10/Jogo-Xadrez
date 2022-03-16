using System;
using System.Globalization;

namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            //nao eh necessario quando usa o construtor de 2 argumentos 
            //Console.Write("Quantidade no estoque: ");
            //int quantidade = int.Parse(Console.ReadLine());

            //escolha qual construtor usar: com 2 ou 3 argumentos

            //Produto p = new Produto(nome, preco, quantidade); //com variavel 'quantidade' 
            //Produto p = new Produto(nome, preco, 20); //sem variavel 'quantidade' mas com um valor fixo
            Produto p = new Produto(nome, preco); // com 2 argumentos
            

            //Produto p2 = new Produto(); //fim didatico

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
