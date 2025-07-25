using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Activity_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string input;

            while (true)
            {
                Console.Write("Enter a number (or type 'stop' to finish): ");
                input = Console.ReadLine();

                if (input.Equals("stop", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                if (int.TryParse(input, out int number))
                {
                    sum += number; 
                }
                else
                {
                    Console.WriteLine("Invalid entry, please enter a valid number.");
                }
            }
            Console.WriteLine("Sum of all valid numbers: " + sum);
        }
    }
}
           
