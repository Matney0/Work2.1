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
            //What the sum needs to equal out to 
            int sum = 0;
            //While the number isnt equal to 0 it will continue calculations
            while (number > 0)
            {
                
                sum += (number % 10);
                //Loops calculations until needed value
                number /= 10;
            }
            //Printing message out to user
            Console.WriteLine("The sum of digits is {0}", sum);

        }
    }
}
