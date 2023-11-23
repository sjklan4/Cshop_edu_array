using System;

class FunctionNote
{
    // sum함수 선언 - 큰 의미 없으면 체이닝?
    // static void Sum() => Console.WriteLine("합계 :  "); 
    static void Sum(int first, int second) // 넘겨 주는 값  
    { 
        int sum = first + second;
        Console.WriteLine($"합계 :{sum}");
    }

   
        
    
    // static void Main() => Sum(값,값); 방식으로 사용 가능 
    static void Main(string[] args)
        {
           FunctionNote.Sum(3,5);
        }
}