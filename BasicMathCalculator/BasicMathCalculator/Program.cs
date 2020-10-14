using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathCalculator
{
    class Program
    {
        static int computationResult;

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
        
        static int BasicMathComputation(char mathOperator)
        {
            // Input number
            Console.Write("Enter the first number: ");
            int firstNumber = Int32.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int secondNumber = Int32.Parse(Console.ReadLine());

            switch (mathOperator)
            { 
                case '+':
                    computationResult = firstNumber + secondNumber;
                    break;
                case '-':
                    computationResult = firstNumber - secondNumber;           
                    break;
                case '*':
                    computationResult = firstNumber * secondNumber;
                    break;
                case '/':
                    computationResult = firstNumber / secondNumber;
                    break;
                default:
                    Console.WriteLine("Invalid Math Operator!");
                    break;
            }
            return computationResult;
        }
    }
}
