using System;
using System.Diagnostics;

class FunctionNote
{
    // sum함수 선언 - 큰 의미 없으면 체이닝?
    // static void Sum() => Console.WriteLine("합계 :  "); 
    static int Sum(int first, int second) // 넘겨 주는 값  
    { 
        
        int sum = first + second;
        return sum;
        //Console.WriteLine($"합계 :{sum}");
    }

   
        
    
    // static void Main() => Sum(값,값); 방식으로 사용 가능 
    static void Main(string[] args)
        {
            int result = Sum(3, 5);
            Console.WriteLine(result);
           //FunctionNote.Sum(3,5);
        }
    //위 함수 부분을 별도로 체이닝 식으로 변경 가능

    //static int Sum(int first, int second) => (first + second);

    //static void Main() => Console.WriteLine(Sum(3,5));
}
