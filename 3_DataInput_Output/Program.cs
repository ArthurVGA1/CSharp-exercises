class DataInputOutput
{
    static void Main(string[] args)
    {
        Console.WriteLine("What your name?");
        string name = Console.ReadLine();
        Console.WriteLine("How old are you?");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("How many meters do you have?");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Name: {name}\nAge: {age} years old\nHeight: {height} meters");
    }
}