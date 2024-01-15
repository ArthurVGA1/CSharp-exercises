class ArrayAverage
{
    static void Main(string[] args)
    {
        int[] array = { 23, 22, 11, 65 };

        int result = 0;

        for (int i =0; i < array.Length; i++)
        {            
            result += array[i];
        }
        Console.WriteLine($"The average of the sum of numbers {array[0]}, {array[1]}, {array[2]}, {array[3]} = {result}");
    }
}