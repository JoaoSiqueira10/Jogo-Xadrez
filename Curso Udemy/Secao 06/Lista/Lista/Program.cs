using System;
using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Add("Joao");
            list.Add("Pedro");
            list.Add("Carlos");
            list.Add("Jose");
            list.Add("Carla");

            //list.Insert(posicao,elemento);    
            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count" + list.Count);

            //predicato é uma funcao que pega o valor e retorna verdeiro ou falso conforme a logica q tiver implementada 
            
            //encontra o primeiro que comeca com a letra A
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("Primeiro 'A': " + s1);

            //encontra o ultimo que comeca com a letra A
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A: " + s2);

            //encontra a posicao do primeiro elemento que comeca com a letra A
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            //encontra a posicao do ultimo elemento que comeca com a letra A
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            //filtra a lista 'list'
            //encontra todos com tamanho de 5 caracteres
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            //remove apenas o que foi informado
            list.Remove("Alex");
            Console.WriteLine("---------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //remove todos que começam com a letra M foram removidos
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("---------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //remove a posicao
            list.RemoveAt(3);
            Console.WriteLine("---------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            //remove uma faixa
            list.RemoveRange(2, 2);
            Console.WriteLine("---------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    
    }
}
