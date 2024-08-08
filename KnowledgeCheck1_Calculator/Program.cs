using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();

            switch (input)
            {
                case "1":
                    int addNumOne, addNumTwo;

                    if (TryGetIntegers(out addNumOne, out addNumTwo))
                    {
                        Console.Write($"{addNumOne} + {addNumTwo} = ");
                        Console.Write(calculator.Add(addNumOne, addNumTwo));
                    }
                    break;

                case "2":
                    int subNumOne, subNumTwo;

                    if (TryGetIntegers(out subNumOne, out subNumTwo))
                    {
                        Console.Write($"{subNumOne} - {subNumTwo} = ");
                        Console.Write(calculator.Subtract(subNumOne, subNumTwo));
                    }
                    break;

                case "3":
                    int multNumOne, multNumTwo;

                    if (TryGetIntegers(out multNumOne, out multNumTwo))
                    {
                        Console.Write($"{multNumOne} * {multNumTwo} = ");
                        Console.Write(calculator.Multiply(multNumOne, multNumTwo));
                    }
                    break;

                case "4":
                    double divNumOne, divNumTwo;

                    if (TryGetDoubles(out divNumOne, out divNumTwo))
                    {
                        Console.Write($"{divNumOne} / {divNumTwo} = ");
                        Console.Write(calculator.Divide(divNumOne, divNumTwo));
                    }
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }

        }
        static bool TryGetIntegers (out int numOne, out int numTwo)
        {
            Console.WriteLine("Enter two numbers:");
            string inputOne = Console.ReadLine();
            string inputTwo = Console.ReadLine();
            numOne = 0;
            numTwo = 0;
            return int.TryParse(inputOne, out numOne) && int.TryParse(inputTwo, out numTwo);
        }

        static bool TryGetDoubles (out double numOne, out double numTwo)
        {
            Console.WriteLine("Enter two numbers:");
            string inputOne = Console.ReadLine();
            string inputTwo = Console.ReadLine();
            numOne = 0.0;
            numTwo = 0.0;
            return double.TryParse(inputOne, out numOne) && double.TryParse(inputTwo,out numTwo);
        }
    }
}