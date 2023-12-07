using System;
using static System.Console;

class LinqAverage
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3 };
        double average = numbers.Average();
        WriteLine($"{nameof(numbers)} 배열 요소의 평균 : {average:#,###.##}");
    }
}