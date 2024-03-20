using System;

public class Program
{ 
    public static void Main()

    {
        dynamic x;
        x = 1_234;
        Console.WriteLine($"{x} - {x.GetType()}");
    }

}