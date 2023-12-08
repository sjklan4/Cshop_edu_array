// LINQ : C#언어에 직접 쿼리 기능을 통합하는 방식을 기반으로 하는 기술 집합 이름
// 미리 만들어져 있는 Method들을 사용할 수 있게 해주는 기능
using System;
using System.Linq;

class Linqsum
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3 };
        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Console.WriteLine(sum);
    }
}