using Exercicio9_1.Entities.Enums;
using System;
using System.Collections.Generic;

namespace Exercicio9_1.Entities
{
    class Worker
    {
        public String Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; } //assossiacao com Department
        public List<HourContrat> Contracts { get; set; } = new List<HourContrat>(); //assossiacao com HourContract, lista instaciada para nao ser nula

        public Worker()
        {
        }
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContrat(HourContrat contrat)
        {
            Contracts.Add(contrat);
        }

        public void RemoveContract(HourContrat contrat)
        {
            Contracts.Remove(contrat);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContrat contrat in Contracts){
                if(contrat.Date.Year == year && contrat.Date.Month == month)
                {
                    sum += contrat.TotalValue();
                }
            }
            return sum;
        }
    }
}
