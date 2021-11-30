// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] data = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };
            int n = data.Length;


            Stats.sorting(data, n);
            Console.WriteLine("Mean : "+ Stats.findmean(data, n));
            Console.WriteLine("Median : " + Stats.findmedian(data, n));
            Console.WriteLine("Mode : " + Stats.findmode(data, n));

            
        }
    }
}
