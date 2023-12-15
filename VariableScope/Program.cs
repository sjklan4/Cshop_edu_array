using System;

class VariableScop 
{
    static string globalVariable = "전역 변수"; // 필드 또는 멤버 변수

    static void Main()
    {
        string localVariable = "지역 변수"; // 지역 변수
        Console.WriteLine(localVariable);
        Console.WriteLine(globalVariable);  // 전역 변수
        Test();
    }
    static void Test() => Console.WriteLine(globalVariable); //전역 변수
}
