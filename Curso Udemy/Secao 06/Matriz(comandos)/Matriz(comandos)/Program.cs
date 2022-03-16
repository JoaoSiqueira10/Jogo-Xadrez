using System;

namespace Matriz_comandos_
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];//declaracao da matriz

            Console.WriteLine(mat.Length); // quantos elementos totais tem na matriz
            
            Console.WriteLine(mat.Rank); // quantidade de linhas
            
            Console.WriteLine(mat.GetLength(0)); // tamanho da primeira dimensao 
            
            Console.WriteLine(mat.GetLength(1)); // tamanho da segunda dimensao
        }
    }
}
