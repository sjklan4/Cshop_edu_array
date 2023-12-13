using System;

//순위 알고리즘 (Rank Algorithm) : 점수 데이터에 대한 순위 구하기


class RankAlgorithm
{
    static void Main()
    {
        //Input
        int[] scores = { 90, 87, 100, 95, 80 }; // 순위 : 3,4,1,2,5
        int[] rankings = Enumerable.Repeat(1, 5).ToArray(); // 모두 1로 초괴화 = 1,1,1,1,1 5번 인식

        // Process : RANK
        for (int i = 0; i < scores.Length; i++)
        {
            rankings[i] = 1; // 1등으로 초기화, 순위 배열을 매 회전마다 1등으로 초기화
            for (int j = 0; j < scores.Length; j++)
            {
                if (scores[i] < scores[j]) // 현재(i) 와 나머지들(j)를 비교
                {
                    rankings[i]++; // RANK : 나 보다 큰 점수가 나오면 순위 1증가
                }
            }
        }

        // Output
        for (int i = 0; i < rankings.Length; i++) 
        {
            Console.WriteLine($"{scores[i],3}점: {rankings[i]}등");
        }


    }
}