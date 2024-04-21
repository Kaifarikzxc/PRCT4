using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract4
{
    class TravelAgency
    {
        private string name;
        private int year;
        private string inn;
        private decimal profit;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public string Inn
        {
            get { return inn; }
            set { inn = value; }
        }

        public decimal Profit
        {
            get { return profit; }
            set { profit = value; }
        }

        public TravelAgency() { }

        public TravelAgency(string name, int year, string inn, decimal profit)
        {
            Name = name;
            Year = year;
            Inn = inn;
            Profit = profit;
        }

        public void Info()
        {
            Console.WriteLine($"Name: {Name}, Year: {Year}, Inn: {Inn}, Profit: {Profit}");
        }
    }
}
