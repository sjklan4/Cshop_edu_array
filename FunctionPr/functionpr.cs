using System;

class FunctionCall
{
    //static void Hi()
    //{
    //    Console.WriteLine("안녕하세요");

    //}

    //static void Main()
    //{ 
    //    Hi(); Hi(); Hi(); Hi();
    //}




    // FunctionParameter.cs
    // 매개 변수(Parameter)가 있는 함수 만들고 호출하기 

    //static void ShowMessage(string message)
    //{ 
    //    Console.WriteLine(message); 

    //}

    //static void Main() 
    //{
    //    ShowMessage("매개 변수");
    //    ShowMessage("Parameter");
    //}

    //static string Getstring() 
    //{
    //    return "반환값(Return Value)";
    //}

    //static void Main()
    //{ 
    //    string retunrValue = Getstring();
    //    Console.WriteLine(retunrValue);
    //}

    // FunctionReturnValue.cs
    // 반환값이 있는 함수(메서드)

    static int SquareFuntion(int x)
    {
        int r = x * x;
        return r;
    
    }

    static void Main()
    {
        int r = SquareFuntion(2);
        Console.WriteLine(r);
    }

}