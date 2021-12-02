﻿// See https://aka.ms/new-console-template for more information

using System;

namespace ConsoleApp2
{
    internal class Program
    {
        // some test data
        static int[] data = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19, 42 };

        static void Main(string[] args)
        {
            // create an object of the StatsProcessor class
            var spObject = new StatsProcessor();

            // feed it the test data as input
            // (this maybe eventually coming from somewhere else...)
            spObject.Numbers = data;

            /*
             * invoke the method to do the processing 
             * and capture the output
             */
            var result = spObject.GetStatsProcessorResult();

            /// console i/o is not the responsibility of the StatsProcessor class!
            Console.WriteLine($"Average: {result.Mean}");
            Console.WriteLine($"Median: {result.Median}");
            Console.WriteLine($"Mode: {result.Mode}");

        }
    }
}

