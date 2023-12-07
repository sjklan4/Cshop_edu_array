using System;
using System.Collections.Generic;
using System.Linq;

class LinqMin 
{
    static void Main()
    {
        var numbers = new List<double> { 0.78,1, 2.5, 3.2, 4.5, 5.7 };
        var min = numbers.Min();

        Console.WriteLine($"{nameof(numbers)} 리스트이 최솟값 : {min :0.00}");

    }
}