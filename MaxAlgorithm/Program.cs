using System;
using System.Linq;

class MaxAlgorithm
{
    static void Main()
    {
        // Intitialzie

        // input
        int[] numbers = { -2, -5, -3, -7, -1 };
        // process :MAx




        // Output
        Console.WriteLine( $"쵀댓값 : {numbers.Max()}"); //Linq방식

        //문 사용법
        int max = int.MinValue; // 정수형 데이터 중 가장 작은 값으로 초기화

        int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7 };

        for (int i = 0; i < numbers1.Length; i++)
        {
            if (numbers1[i] > max)
            {
                max = numbers1[i]; // MAX알고리즘으로 더큰 값으로 할당
            }
        }
        Console.WriteLine($"최대 값은? : {max}");


    }
}