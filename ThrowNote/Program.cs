using System;

//class ThrowNote
//{
//    static void Main()
//    { 
//        throw new Exception(); 
//        throw new ArgumentException();
//    }
//}

class TryFinallyDemo 
{
    static void Main()
    {
        int a = 3;
        int b = 0;


        try
        {
            a = a / b;
        }
        catch(Exception ex) 
        { 
            Console.WriteLine($"예외 가 발생됨 : {ex.Message}");
        }

        finally
        {
            Console.WriteLine("try구문 종료");
        }
    }
}