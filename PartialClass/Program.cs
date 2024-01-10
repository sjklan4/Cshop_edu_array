using System;
//partial class는 하나의 클래스 안에서 여러 method를 나눠서 사용 하기 위한 기능?
namespace PartiaClassDemo
{
    partial class PartialClassDemo 
    {
        // 하나의 Class안에서 멤버들을 구분해서 관리 하기 위함.
        static void Main()
        {
            var hello = new Hello(); // - hello라는 class를 초기화 시켜서 그안에 구분된 public 들의 이름을 기준으로 구별해서 사용
            hello.Hi(); //firstDeveloper
            hello.Bye(); //secondDeveloper

        }
    }
}