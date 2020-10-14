using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Basic Math Calculator App
            PromptingTheMathOperator();

            // <~ End of the program
            Console.ReadLine();
        }

        static char PromptingTheMathOperator()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("\t\t Basic Math Calculator");
            Console.WriteLine("------------------------------------------------------------");
            Console.Write("Select an Operator(+, -, *, /): ");
            char mathOperator = Convert.ToChar(Console.ReadLine());

            return mathOperator;
        }
    }
}
