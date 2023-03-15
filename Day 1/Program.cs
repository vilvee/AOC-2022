using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.IO;
using System;

namespace AOC2022_1
{
    internal class Program
    {
        static void Main()
        {
            string[] text = File.ReadAllLines("Day1.txt");
            int sum = 0;
            List<int> totals = new List<int>();

            foreach (string line in text)
            {
                if(string.IsNullOrEmpty(line))
                {
                    totals.Add(sum);
                    sum = 0;
                }
     
                int.TryParse(line, out int value);             
                sum += value;
            }
            
            totals = totals.OrderByDescending(s => s).ToList();
            Console.WriteLine(totals.First());

            IEnumerable<int> topThree = totals.Take(3);

            

            Console.WriteLine(topThree.Sum());
            
            Console.ReadKey();
        }
    }
}