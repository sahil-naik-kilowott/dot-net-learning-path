using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class Challenge8
    {
        public static void ShowOutput()
        {
            Console.WriteLine();
            Console.WriteLine("Solution for Challenge-8");
            /*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

            string originalMessage = "The quick brown fox jumps over the lazy dog.";

            char[] message = originalMessage.ToCharArray();
            Array.Reverse(message);

            int letterCount = 0;

            foreach (char letter in message)
            {
                if (letter == 'o')
                {
                    letterCount++;
                }
            }

            string newMessage = new String(message);

            Console.WriteLine(newMessage);
            Console.WriteLine($"'o' appears {letterCount} times.");

        }
    }
}