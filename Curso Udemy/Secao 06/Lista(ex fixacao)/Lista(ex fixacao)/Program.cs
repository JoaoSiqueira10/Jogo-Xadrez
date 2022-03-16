using System;
using System.Collections.Generic;
using System.Globalization;

namespace Lista_ex_fixacao_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qunatos funcionarios sera registrado? ");
            int num = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("Funcionario #" + (i+1) + ":");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario: ");
                float salario = float.Parse(Console.ReadLine());
                list.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Digite o ID do funcionario que tera um aumento no salario: ");
            int procuraID = int.Parse(Console.ReadLine());

            Funcionario f = list.Find(x => x.Id == procuraID);
            if (f != null)
            {
                Console.Write("Digite a porcentagem do aumento: ");
                double percentage = double.Parse(Console.ReadLine());
                f.AumentaSalario(percentage);
            }
            else
            {
                Console.WriteLine("Este ID nao existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
