using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator!");

            while (true)
            {
                Console.WriteLine("Enter an operation (+, -, *, /, sqrt, log): ");
                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "sqrt":
                        Console.WriteLine("Enter a number: ");
                        double number = double.Parse(Console.ReadLine());
                        Console.WriteLine("The square root of " + number + " is " + Math.Sqrt(number));
                        break;
                    case "log":
                        Console.WriteLine("Enter a number: ");
                        number = double.Parse(Console.ReadLine());
                        Console.WriteLine("The log of " + number + " is " + Math.Log(number));
                        break;
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                        Console.WriteLine("Enter the first number: ");
                        double x = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the second number: ");
                        double y = double.Parse(Console.ReadLine());

                        if (operation == "+")
                        {
                            Console.WriteLine("The sum of " + x + " and " + y + " is " + (x + y));
                        }
                        else if (operation == "-")
                        {
                            Console.WriteLine("The difference of " + x + " and " + y + " is " + (x - y));
                        }
                        else if (operation == "*")
                        {
                            Console.WriteLine("The product of " + x + " and " + y + " is " + (x * y));
                        }
                        else if (operation == "/")
                        {
                            Console.WriteLine("The quotient of " + x + " and " + y + " is " + (x / y));
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid operator.");
                        break;
                }

                Console.WriteLine("Do you want to perform another operation? (y/n)");
                string again = Console.ReadLine();
                if (again != "y")
                {
                    break;
                }
            }

            Console.WriteLine("Thank you for using the calculator!");
        }
    }
}
