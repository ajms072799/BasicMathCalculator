using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathCalculator
{
    class Program
    {
        static int ComputationResult;

        static void Main(string[] args)
        {
            int ResultOfTheMathComputation = BasicMathComputation();

            Console.WriteLine(ResultOfTheMathComputation);
            
            // <~ End of the program
            Console.ReadLine();
        }
        static int BasicMathComputation()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("\t\t Basic Math Calculator");
            Console.WriteLine("------------------------------------------------------------");
            Console.Write("Select an Math Operator(+, -, *, /): ");
            char MathOperator = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter your first number: ");
            int FirstNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Enter your second number: ");
            int SecondNumber = Int32.Parse(Console.ReadLine());

            switch (MathOperator)
            { 
                case '+':
                    ComputationResult = FirstNumber + SecondNumber;
                    break;
                case '-':
                    ComputationResult = FirstNumber - SecondNumber;
                    break;
                case '*':
                    ComputationResult = FirstNumber * SecondNumber;
                    break;
                case '/':
                    ComputationResult = FirstNumber / SecondNumber;
                    break;
            }

            return ComputationResult;
        }
    }
}
