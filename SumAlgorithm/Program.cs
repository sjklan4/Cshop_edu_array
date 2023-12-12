using System;
using System.Linq;

class SumAlgorithm
{
    static void Main()
    {
        int[] scores = { 100, 75, 50, 37, 90, 95 };
        int sum = 0;

        for (int i = 0; i < scores.Length; i++) //int배열에 있는 6개 를 반복해서 실행
        {
            if (scores[i] >= 80)  // 만약 scores값이 80이상이면 sum구문 실행 다시 위 for문을 구동 - 80인값 +  반복
            {
                sum += scores[i];
            }


        }
        Console.WriteLine(sum); //최종 출력
        Console.WriteLine("");
        ////Linq? 가능?
        //int[] numbers = { 100, 75, 50, 37, 90, 95 };
        //int sumnumber = numbers.Where(n => n >= 80).Sum();

        //Console.WriteLine(sumnumber);
        //Console.WriteLine("");
        ////linq가설 2번째

        //int sumnumber1 = new[] { 100, 75, 50, 37, 90, 95 }.Where(n => n >= 80).Sum();
        //Console.WriteLine($"{sumnumber}.");

    }
}