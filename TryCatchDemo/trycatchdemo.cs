using System;

class tryCatchDemo
{
    static void Main()
    {
        try
        {
            int now = DateTime.Now.Second;
            Console.WriteLine($"[0] 현재 초 : {now}");

            int result = 2 / (now % 2);
            Console.WriteLine("[1] 홀수 초에서는 정상 처리");

        }
        catch 
        {
            Console.WriteLine("[2] 짝수 초에서는 런타임 에러 발생");        
        }
    }
}