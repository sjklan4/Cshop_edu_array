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

    static int Max(int x, int y)
    {
        return (x > y) ? x : y;
    }

    static int Min(int x, int y)
    {
        if (x < y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }

    static double GetSum(double x, double y)
    {
        double r = x + y;
        return r;
    }

    static int ABS(int num)
    {
        return(num < 0) ? - num : num;
    }

    static int Addnumber(int a, int b) 
    { 
        return a + b;
    }




    static void Main()

    {
     
        int r = SquareFuntion(2);
        Console.WriteLine(r);
        Console.WriteLine("");

        Console.WriteLine(Max(3, 5));
        Console.WriteLine(Min(-3, -5));
        Console.WriteLine("");

        double result = GetSum(3, 0.14);
        Console.WriteLine(result);
        Console.WriteLine("");

        int num = - 21;
        int abs = ABS(num);
        Console.WriteLine(abs);
        Console.WriteLine("");

        int a = 3;
        int b = 5;
        int c = Addnumber(3, 5);
        Console.WriteLine($"{a} + {b} = {c}");
        Console.WriteLine("");
    }
    
 

}