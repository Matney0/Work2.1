using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //An example of the user entering a number to find the sum 
            int number = 456;
            int sum = 0;

            while (number > 0)
            {
                sum += (number % 10);
                number /= 10;
            }
            Console.WriteLine("The sum of digits is {0}", sum);

        }
    }
}
