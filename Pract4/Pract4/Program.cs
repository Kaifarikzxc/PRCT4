using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TravelAgency> travels = new List<TravelAgency>
            {
                new TravelAgency("Agenstvo1", 2000, "1", 1200000),
                new TravelAgency("Agenstvo2", 1985, "2", 2000000),
                new TravelAgency("Agenstvo3", 2014, "3", 32600000),
                new TravelAgency("Agenstvo4", 2010, "4", 1900000)
            };

            Console.WriteLine("Введите название фирмы:");
            string name = Console.ReadLine();
            bool Find = false;

            foreach (var travel in travels)
            {
                if (travel.Name == name)
                {
                    travel.Info();
                    Find = true;
                }
            }

            if (!Find)
            {
                Console.WriteLine("Фирма не найдена.");
            }

            decimal totalProfit = travels.Sum(x => x.Profit);
            Console.WriteLine($"Суммарная прибыль всех фирм: {totalProfit}");
        }
    }
}
