using System;
using Exercicio9_1.Entities;
using Exercicio9_1.Entities.Enums;


namespace Exercicio9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string depName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Department dept = new Department(depName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContrat contract = new HourContrat(date, valuePerHour, hours);
                worker.AddContrat(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY):");
            string montAndYear = Console.ReadLine();
            int month = int.Parse(montAndYear.Substring(0, 2)); //corta a string apartir da posicao 0 ate a 2
            int year = int.Parse(montAndYear.Substring(3)); //corta a string apartir da posicao 3
            Console.WriteLine("Name: "+worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for "+ montAndYear + ": " + worker.Income(year,month).ToString("F2"));
            

        }
    }
}
