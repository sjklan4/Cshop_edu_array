using System;
using System.Linq;


class Minalgorithm
{
    static void Main()
    {
        int min = int.MaxValue;
        int[] numbers = { 0b0010, 0B_0101, 0b0011, 0B_0111, 0b0000_0001 };

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min && numbers[i] % 2 == 0 )
            {
                min = numbers[i];
            }
        }
        Console.WriteLine($"짝수 최솟값(식): {numbers.Where(n => n % 2 == 0).Min()}");
        Console.WriteLine($"짝수 최솟값(문) : {min}");
    }
}