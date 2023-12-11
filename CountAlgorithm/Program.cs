using System;
using System.Linq;

class ConutAlgorithmP
{
    static void Main() 
    { 
        var numbers = Enumerable.Range(1,1000).ToArray();
        int count = default;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 13 == 0)
            { 
                count++;
            }
        }
        Console.WriteLine(count);
    }

}