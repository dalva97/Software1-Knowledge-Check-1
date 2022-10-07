using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void getErrorMessage()
        {
            Console.WriteLine("One or more of the numbers are not ints");
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();
            string number1;
            string number2;

            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter 2 integers to add");
                    var addNumber1 = Console.ReadLine();
                    var addNumber2 = Console.ReadLine();

                    if (int.TryParse(addNumber1, out int addNumOne) && int.TryParse(addNumber2, out int addNumTwo))
                    {
                        Console.Write($"{addNumber1} + {addNumber2} = ");
                        Console.Write(calculator.Add(addNumOne, addNumTwo));
                    }
                    else
                    {
                        getErrorMessage();
                    }
                    break;

                case "2":
                    Console.WriteLine("Enter 2 integers to subtract");
                     number1 = Console.ReadLine();
                     number2 = Console.ReadLine();

                    if (int.TryParse(number1, out int subNumOne) && int.TryParse(number2, out int subNumTwo))
                    {
                        Console.Write($"{number1} - {number2} = ");
                        Console.Write(calculator.Subtract(subNumOne, subNumTwo));
                    }
                    else
                    {
                        getErrorMessage();
                    }
                    break;

                case "3":
                    // Add code here for multiplication
                    Console.WriteLine("Enter 2 integers to multiply");
                     number1 = Console.ReadLine();
                     number2 = Console.ReadLine();

                    if (int.TryParse(number1, out int multNumOne) && int.TryParse(number2, out int multNumTwo))
                    {
                        Console.Write($"{number1} * {number2} = ");
                        Console.Write(calculator.Multiply(multNumOne, multNumTwo));
                    }
                    else
                    {
                        getErrorMessage();
                    }
                    break;

                case "4":
                    Console.WriteLine("Enter 2 integers to divide");
                    var divideNumber1 = Console.ReadLine();
                    var divideNumber2 = Console.ReadLine();

                    if (double.TryParse(divideNumber1, out double divNumOne) && double.TryParse(divideNumber2, out double divNumTwo))
                    {
                        Console.Write($"{divideNumber1} / {divideNumber2} = ");
                        Console.Write(calculator.Divide(divNumOne, divNumTwo));
                    }
                    else
                    {
                        getErrorMessage();
                    }
                    break;
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }
    }
}