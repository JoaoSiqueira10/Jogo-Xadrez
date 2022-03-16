using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9_1.Entities
{
    class HourContrat
    {
        public DateTime Date { get; set; }
        public double ValuePerHouer { get; set; }
        public int Hours { get; set; }

        public HourContrat()
        {
        }

        public HourContrat(DateTime date, double valuePerHouer, int hours)
        {
            Date = date;
            ValuePerHouer = valuePerHouer;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHouer;
        }
    }
}
