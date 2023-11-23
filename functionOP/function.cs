using System;

class FunctionDemo 
{
    static void Show()
    {
        Console.WriteLine("확인용");
    }

    static void arraytest()
    {
        int[] numbers = { 1, 2, 3 };

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }

    static void Main() 
    {
        arraytest();
        Show();
    }

}