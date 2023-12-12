using System;
using System.Linq;

class AverageAlgorith 
{
    static void Main()
    {
        int[] data = { 90, 65, 78, 50, 95 };
        int sum = 0;
        int cnt = 0;

        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] >= 80 && data[i] <= 95) 
            { 
                
                sum += data[i];
                cnt++;
            }

        }
        
        double avg = (double)sum / cnt;
        Console.WriteLine(avg.ToString("F2"));

        // linq사용시 암시적 형식에 대한 것을 미리 설정하지 않으면 구동 되지 않음. 아래 구문은int로 표현이 안되는 소수점을 포함한 수기 때문에 
        // double로 변수 선언 해야됨
        double linqavg = (new int[] { 50, 65, 78, 90, 95 }).Where( d => d >= 80 && d <= 95 ).Average();
        Console.WriteLine(linqavg);
    }
}
