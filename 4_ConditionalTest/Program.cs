class ConditionalTest
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number");
        int number = Convert.ToInt32(Console.ReadLine());

        if(number == 0) 
        {
            Console.WriteLine("The number is 0");
        }
        else if(number < 0)
        {
            Console.WriteLine("The number is positive");
        }
        else if (number > 0) 
        {
            Console.WriteLine("The number is negative");
        }
    }
}