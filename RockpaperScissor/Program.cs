using System;

class RockPaperScissors
{
    static void Main()
    {
        int iRandom = 0; // random이라는 숫자를 받는 변수 선언
        int iSelection = 0; //iSelection이라는 숫자를 받는 변수 선언
        string[] choice = { "가위", "바위", "보" }; // 문자 배열을로된 choice라는 배열 값 안에 가위 바위 보 라는 배열 값을 줌

        iRandom = (new Random()).Next(1, 4); //iRandom을 new 를 사용해서 초기화(인스턴스 생성) next(1,4)는 하안 1포함 상한 4 미포함으로 1,2,3만을 랜덤 생성 

        Console.Write("1(가위), 2(바위), 3(보) 입력 : _\b"); 
        iSelection = Convert.ToInt32(Console.ReadLine()); // iSelection에 입력되는 값을 숫자 값으로 받도록 convert시킨다.

        Console.WriteLine("\n 사용자 : {0}" , choice[iSelection - 1]); 
        Console.WriteLine("컴퓨터 : {0}\n", choice[iRandom - 1]);

        if (iSelection == iRandom)
        {
            Console.WriteLine("비김");
        }
        else
        {
            switch(iSelection)
            {
                case 1: Console.WriteLine((iRandom == 3) ? "승" : "패"); break;
                case 2: Console.WriteLine((iRandom == 2) ? "승" : "패"); break;
                case 3: Console.WriteLine((iRandom == 1) ? "승" : "패"); break;
            }

        }
    }
}