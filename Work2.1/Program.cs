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

            //Prompt user to enter a number
            Console.WriteLine("Enter number to find the sum of digits");
            //Changes users variable into an integer 
            var userInput = int.Parse(Console.ReadLine());
            //Sum of the digits, starts with one before user prompt
            var sum = 0;
            //Does prompt until condition  met
            do
            {
                //Getting final digit
                int finalDigit = (userInput % 10);
                
                //Adding the digits together 
                sum = sum + (userInput % 10);


                //Remove final digit 
                userInput = (userInput / 10);

            }
            while (userInput > 0);
               
                //Printing message out to user
                Console.WriteLine("The sum of digits is", sum);
        }
    }
}
