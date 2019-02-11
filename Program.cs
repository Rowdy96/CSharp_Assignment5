using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Primeministers = new Dictionary<string, string>();
            Primeministers.Add("1998", "Atal Bihari Vajpayee");
            Primeministers.Add("2014", "Narendra Modi");
            Primeministers.Add("2004", "Manmohan Singh");
           
            var find = from minister in Primeministers where minister.Key.Contains("2004") select minister.Value;
            Console.Write("the Prime minister of 2004: ");
            foreach (var o in find)
            {
                Console.WriteLine(o);
            }
            Primeministers.Add("2019", "Narendra Modi");
            Console.WriteLine();
            Console.WriteLine("After adding current Prime minister:");
            foreach (var ministers in Primeministers)
            {
                Console.WriteLine(ministers);
            }
            Console.WriteLine();
            var SortList = from minister in Primeministers orderby minister.Key select minister;
            Console.WriteLine("Sorted dictionary by year:");
            foreach(var SortValue in SortList)
            {
                Console.WriteLine(SortValue);
            }
            Console.ReadKey();
        }
    }
}
