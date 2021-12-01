using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatsAssignment
{
    internal class Program
    {
        static int[] data = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };
        static int n = data.Length;
        static void Main(String[] args)
        {
            var m1 = new StatsProcessor();
            m1.Numbers = data;

            m1.sorting(data, n);
            
            var mn = m1.findmean(data, n);
            Console.WriteLine($"Mean: {mn}");

            var md = m1.findmedian(data, n);
            Console.WriteLine($"Median: {md}");

            var mo = m1.findmode(data, n);
            Console.WriteLine($"Mode: {mo}");


            Console.ReadLine();
        }
    }
}