using System;
using System.Collections.Generic;

class NearAll 
{
    static void Main()
    {
        int[] data = { 10, 20, 23,24, 27, 17 };
        int target = 25;
        List<int> nears = new List<int>();
        int min = Int32.MaxValue; // 가장 가까운 차이 값을 넣기 위한 준비문

        for (int i = 0; i < data.Length; i++)  // data배열에 있는 값들을 하나씩 가져옴
        {
            if (Math.Abs(data[i] - target) < min) // 절대값으로 data[i]의 값에서 tagrget값의 차이가 min 값의 값보다 작으면 
            { 
                min = Math.Abs(data[i] - target); // min값안에 data[i] 값과 target값과의 차이를 반환
            }
        } //위 작업을 반복해서 목표 값과 배열값사이에 가장 작은 차이가 있는 즉 근사값을 찾는다. - 이 구문에서는 근사값과의 차이를 구한다.

        Console.WriteLine($"차이의 최솟값 : {min}");

        for (int i = 0; i < data.Length; i++) // data길이 만큼 반복 시작
        {
            if (Math.Abs(data[i] - target) == min) // data[i]와 target값과의 차이가 min값과 같으면 아래 nears 항목에 그 값을 반환 시킨다.
            {
                nears.Add(data[i]);
            }
        }

        foreach (var n in nears) //nears값에 있는 값들을 n에 담아서 있는 만큼 전부 반환
        {
            Console.WriteLine(n);
        }
    
    }

}