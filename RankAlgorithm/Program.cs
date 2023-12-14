using System;
using System.Linq;

//순위 알고리즘 : 점수 데이터에 대한 순위 구하기
class Rankalgorithm 
{
    static void Main()
    {
        int[] scores = { 90, 87, 100, 95, 80 };
        int[] rankings = Enumerable.Repeat(1,5).ToArray();
        

        for (int i = 0; i < scores.Length; i++)
        {
            rankings[i] = 1;
            for (int j = 0; j < scores.Length; j++)
            {
                if (scores[i] < scores[j])
                {
                    rankings[i]++;
                }
            }
        }

        for (int i = 0; i < scores.Length; i++)
        {
            Console.WriteLine($"{scores[i],3}점: {rankings[i]}등");
        }

    }
}
