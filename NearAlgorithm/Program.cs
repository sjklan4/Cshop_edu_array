using System;
using System.Linq;
using static System.Console;

class NearAlgorithm
{
    static void Main()
    {
        //[0] 절댓밗 구하기 로컬 함수 : Math.Abs() 함수와 동일한 기능을 구현
        int Abs(int number) => (number < 0 ) ? -number : number;

        //[1] Initialize
        int min = int.MaxValue; // 차잇값의절대값의 최솟값이 담길 그릇
       

        //[2] Input
        int[] numbers = { 10, 20, 30, 27, 17 };
        int target = 25;
        int near = default; // 가까운 값을 담을 공간
        //[3] Process - 문 Algorithm
        for (int i = 0; i < numbers.Length; i++)
        {
            int abs = Abs(numbers[i] - target);
            if (abs < min)
            {
                min = abs; //차이값의 최솟값 알고리즘 적용
                near = numbers[i]; // 차잇값의 절댓값의 최소값을 때의 값 
            }
        }



        //[4] Output
        var minimum = numbers.Min(m => Math.Abs(m - target)); //차잇값의 최솟값
        var closest = numbers.First(n => Math.Abs(n - target) == minimum); // 근사값
         
        WriteLine($"{target}와 가장 가까운 값(식) : {closest}(차이 : 2) : {minimum}");
        var closest1Linq = numbers.First(o => Math.Abs(o - target) == numbers.Min(p => Math.Abs(p - target)));
        WriteLine($"{target}와 가장 가까운 값(Linq) : {closest1Linq}");
        WriteLine($"{target}와 가장 가까운 값(문 - alg) {near}차이{min}");
        
        




    }
}
