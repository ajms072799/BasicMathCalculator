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
            int NumberOfTransaction, i;
            NumberOfTransaction = 1;
            i = 0;

            do
            {
                int ResultOfTheMathComputation = BasicMathComputation(); // Getting the return value and storing to this variable.

                Console.WriteLine("Basic Computation Result: " + ResultOfTheMathComputation); // Printting the variable that you get.

                Console.Write("Do you want another transaction?(Y/n): "); // input for getting the another transaction.
                char AnswerForAnotherTransaction = Convert.ToChar(Console.ReadLine()); // storing the answer for another transaction in this variable.

                if (AnswerForAnotherTransaction == 'Y' || AnswerForAnotherTransaction == 'y')
                {
                    NumberOfTransaction += NumberOfTransaction;
                }
                else {
                    Console.WriteLine("Thank you for using this Basic Math Calculator!");
                }
                i++;
            
            } while (i < NumberOfTransaction);
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
