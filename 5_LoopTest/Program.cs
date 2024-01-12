using System;
using System.Threading;

class Countdown
{ 
    static void Main(string[] args)
    {
        Console.WriteLine("Press enter to start the countdown");
        string countdown = Console.ReadLine();


        for(int i = 10;i >= 0;i--)
        {
            Console.Clear();

            int leftOffset = (Console.WindowWidth - i.ToString().Length) / 2;
            int topOffset = Console.WindowHeight / 2;

            Console.SetCursorPosition(leftOffset, topOffset);

            Console.WriteLine(i);

            Thread.Sleep(1000);
        }
    }
}