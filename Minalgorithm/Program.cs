using System;
using System.Linq;
using static System.Console;

class Minalgorithm
{
    static void Main()
    {
        var min = Int32.MaxValue;
        int[] numbers = { 0b001, 0B_0101, 0b0011, 0B_0111, 0b0000_001 };

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < min && numbers[i] % 2 == 0)
            {
                min = numbers[i];
            }
        }
        WriteLine($"짝수 최솟값(식): {numbers.Where(n => n % 2 == 0).Min()}");
        WriteLine($"짝수 최솟값(문) : {min}");
    }
}