using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int result;
            string operation;

            Console.WriteLine("Welcome to the Gurman's calculator!");
            Console.ReadLine();

            Console.WriteLine("Please enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please select the operator (/, *, +, -)");
            operation = Console.ReadLine();



            if (operation == "+")
            {
                result = num1 + num2;
                Console.WriteLine("Answer = " + result);
            }
            else if (operation == "-")
            {
                result = num1 - num2;
                Console.WriteLine("Answer = " + result);
            }
            else if (operation == "*")
            {
                result = num1 * num2;
                Console.WriteLine("Answer = " + result);
            }
            else if (operation == "/")
            {
                result = num1 / num2;
                Console.WriteLine("Answer = " + result);
            }
        }
    }
}
