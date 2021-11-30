using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class Challenge5
    {
        public static void ShowOutput()
        {
            Console.WriteLine();
            Console.WriteLine("Solution for Challenge-5");
            int firstValue = 500;
            int secondValue = 600;
            int largerValue;
            largerValue = Math.Max(firstValue, secondValue);
            Console.WriteLine(largerValue);
        }
    }
}