using System;
using System.Threading;

class Fibonacci_Fatorial
{
    static void Main(string[] args)
    {
        string option;
        bool loop = true;

        while (loop)
        {
            Console.Clear();
            Console.WriteLine("Choose an option:\n1 - Fibonacci.\n2 - Factorial.\n3 - Close.");
            option = Console.ReadLine();

            Console.Clear();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Enter the number of repetitions to have the Fibonacci sequence:");
                    int quantity = Convert.ToInt32(Console.ReadLine());

                    Fibonacci(quantity);

                    Console.WriteLine("\nDo you wish to continue? (y/n)");
                    option = Console.ReadLine();

                    switch (option)
                    {
                        case "y":
                            
                            break;

                        case "n":
                            loop = false;
                            break; 

                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                    break;

                case "2":                   
                    Console.WriteLine("Enter the number of repetitions to have the Factorial sequence:");
                    int number = Convert.ToInt32(Console.ReadLine());

                    Factorial(number);

                    Console.WriteLine("\nDo you wish to continue? (y/n)");
                    option = Console.ReadLine();

                    switch (option)
                    {
                        case "y":
                            
                            break;

                        case "n":
                            loop = false;
                            break;

                        default:
                            Console.WriteLine("Invalid option.");
                            break;
                    }
                    break;

                case "3":
                    loop = false;
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    Console.ReadLine();
                    break;

            }
        }
    }
    static void Fibonacci(int quantity)
    {
        int sum = 1, previous = 0, next = 1;

        for (int i = 0; i <= quantity; i++)
        {
            Console.WriteLine($"Position {i} = {previous}");
            sum = next + previous;
            previous = next;
            next = sum;

            Thread.Sleep(300);
        }
    }

    static void Factorial(int number)
    {
        if (number < 0)
        {
            Console.WriteLine("Factorial is not defined for negative numbers.");

            Thread.Sleep(1000);
        }

        if (number == 0 || number == 1)
        {
            Console.WriteLine("The factorial of 0 and 1 will always be 1");

            Thread.Sleep(1000);
        }

        long result = 1;

        for(int i = 2; i  <= number; i++)
        {
            Console.WriteLine($"Position {i} = {result}");
            result *= i;

            Thread.Sleep(300);
        }
    }
}