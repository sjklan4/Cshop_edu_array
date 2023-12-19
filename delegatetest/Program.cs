// 대리자(Delegate) : 함수 포인터, 메서드 대신 호출, 대리 운전
using System;

class DelegateSample
{
    static void GoForward() => Console.WriteLine("직진");
    delegate void CarDriver(); // 대리자 형식 생성
    static void Main()
    {
        GoForward(); // 내가 직접 운전
        CarDriver goHome = new CarDriver(GoForward); // 대리 운전
        goHome.Invoke();
        goHome();
    }
}