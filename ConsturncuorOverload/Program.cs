using System;

class ConsturctorLog
{ 
    public ConsturctorLog() 
    {
        Console.WriteLine("기본 생성자 실행");
    }

    public ConsturctorLog(string message)
    { Console.WriteLine("오버러드된 생성자 실행 : " + message); }

    class ConstructorOverload 
    { 
        static void Main()
        {
            ConsturctorLog log1 = new ConsturctorLog();
            ConsturctorLog log2 = new ConsturctorLog("C#");
            ConsturctorLog log3 = new ConsturctorLog("ASP.NET");
        }
    }
}