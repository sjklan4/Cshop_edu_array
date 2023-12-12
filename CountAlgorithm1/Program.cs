using System;
using System.Linq;
using System.Runtime.Intrinsics.X86;

class ConutAlgorithm
{
    static void Main()
    {
        int count = Enumerable.Range(1,1000).Where(n => n % 13 == 0).Count(); //linq형식
                

        Console.WriteLine(count);
        Console.WriteLine("----------------------------------------------------");
        
        int cnt = 0;
        for (int i = 1; i <= 1000; i++)
        {
            
            if (i % 13 == 0) 
            {
                cnt++;
            }

            
        }
        Console.WriteLine("13의 배수개수: " + cnt);

    
        

        //아래 sumalgorithm 빌드 문제로 예시 옮겨서 실행
        //Linq? 가능?
        //int[] numbers = { 100, 75, 50, 37, 90, 95 };
        //int sumnumber = numbers.Where(n => n >= 80).Sum();

        //Console.WriteLine(sumnumber);
        //Console.WriteLine("");

        ////linq가설 2번째

        //int sumnumber2 = new[] { 100, 75, 50, 37, 90, 95 }.Where(n => n >= 80).Sum();
        //Console.WriteLine($"{sumnumber}.");
    }

}