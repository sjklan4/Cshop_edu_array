using System;

class ConsoleColorDemo
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Blue");
        Console.ResetColor();

        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor= ConsoleColor.Yellow;
        Console.WriteLine("Enumtesting");
        Console.ResetColor();
    }
}

