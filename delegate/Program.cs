//대리자는 delegate 키워드를 사용
//대리자는 함수 자체를 데이터 하나로 보고 의미 그대로 다른 메서드를 대신 실행
//한 번에 하나 이상을 대신해서 호출할 수 있는 개념


using System;

class DelegateDemo
{
    static void Hi() => Console.WriteLine("안녕하세요");

    delegate void SayDelegate();

    static void Main()
    {
        SayDelegate say = Hi;
        say();

        var hi = new SayDelegate(Hi);
        hi();
    }
}