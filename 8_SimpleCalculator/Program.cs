using System;
using SimpleCalculator_CSharp;
using SimpleCalculator_CSharp.Functions;

class Calculator
{
    static void Main(string[] args)
    {
        Functions functions = new Functions();

        bool loop = true;
        string option;

        while (loop)
        {
            Console.Clear();
            Console.WriteLine("Write 2 numbers:");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose one of the operations:\n+ - Sum.\n- - Subtract.\n* - Multiply.\n/ - Divide.\n^ - Potency.\n/2- Square root.\n0 - Back.\n00 - Close.");
            option = Console.ReadLine();

            switch (option)
            {
                case "+":
                    Console.WriteLine(functions.Sum(x, y));
                    Console.ReadLine();
                    break;

                case "-":
                    Console.WriteLine(functions.Subtract(x, y));
                    Console.ReadLine();
                    break; 

                case "*":
                    Console.WriteLine(functions.Multiply(x, y));
                    Console.ReadLine();
                    break;

                case "/":
                    Console.WriteLine(functions.Divide(x, y));
                    Console.ReadLine();
                    break;

                case "^":
                    Console.WriteLine(functions.Potency(x, y));
                    Console.ReadLine();
                    break;

                case "/2":
                    Console.WriteLine(functions.SquareRoot(x));
                    Console.ReadLine();
                    break;

                case "0":
                    loop = true;
                    break;

                case "00":
                    loop = false;
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    Console.ReadLine();
                    break;
            }
        }
    }
}