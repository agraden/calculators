using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {

                double no1 = 0;
                double no2 = 0;
                double result = 0;

                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.WriteLine("\nChoose an operator: ");
                string op = Console.ReadLine();

                Console.WriteLine("Enter first number: ");
                no1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter second number: ");
                no2 = Convert.ToDouble(Console.ReadLine());

                switch (op)
                {
                    case "+":
                        result = no1 + no2;
                        Console.WriteLine($"Your result: {no1} + {no2} = " + result);
                        break;
                    case "-":
                        result = no1 + no2;
                        Console.WriteLine($"Your result: {no1} + {no2} = " + result);
                        break;
                    case "*":
                        result = no1 + no2;
                        Console.WriteLine($"Your result: {no1} + {no2} = " + result);
                        break;
                    case "/":
                        result = no1 + no2;
                        Console.WriteLine($"Your result: {no1} + {no2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }
                Console.Write("\t\nWould you like to restart? (y/n): ");
            } while (Console.ReadLine() == "y");

            Console.WriteLine("Goodbye!");
            Console.ReadKey();
        }
    }
}
