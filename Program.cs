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

                Console.WriteLine("+ : Add");
                Console.WriteLine("- : Subtract");
                Console.WriteLine("* : Multiply");
                Console.WriteLine("/ : Divide");
                Console.WriteLine("Choose an operator: ");
                string op = Console.ReadLine();

                Console.WriteLine("Enter first number: ");
                no1 = Convert.ToDouble(Console.ReadKey());

                Console.WriteLine("Enter second number: ");
                no2 = Convert.ToDouble(Console.ReadKey());

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
                Console.Write("Would you like to restart? (y/n): ");
            } while (Console.ReadLine() == "y");
        
            Console.WriteLine("Goodbye!");
            Console.ReadKey();
        }
    }
}
