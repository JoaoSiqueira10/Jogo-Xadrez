using System;

namespace Matriz_ExercicioResolvido_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cont = 0;
            int[,] mat = new int[n, n];

            for(int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                
                for(int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Diagonal Principal: ");
            for(int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i] + " ");

                for (int j = 0; j < n; j++){
                    if(mat[i,j] < 0)
                    {
                        cont++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Numeros Negativos: " + cont);




        }
    }
}
