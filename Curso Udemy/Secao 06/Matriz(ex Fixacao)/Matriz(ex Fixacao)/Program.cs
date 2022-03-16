using System;

namespace Matriz_ex_Fixacao_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int m = int.Parse(line[0]); //linha
            int n = int.Parse(line[1]); //coluna

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == num)
                    {
                        Console.WriteLine("Posicao: " + i + ", " + j);
                        if (j > 0)
                        {
                            Console.WriteLine("Esquerda: " + mat[i, j - 1]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Direita: " + mat[i, j + 1]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Embaixo: " + mat[i + 1, j]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Cima: " + mat[i - 1, j]);
                        }
                    }
                }
            }
        }
    }
}
