using System;

class arrayOPer
{
    static void Main()
    {
        int[,] array = { { 1, 2, 3, 4, }, { 5, 6, 7, 8 } };
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]}\t");
            }
            Console.WriteLine();
        }

        string[] names = { "C#", "ASP.NET" };
        string[] names1 = { "C#", "Windows Forms", "ASP.NET" };
        for (int k = 0; k < names1.Length; k++) //배열 길이만큼 반복 C#  Windows Forms  ASP.NET 
        {
            Console.WriteLine(names1[k]); 
        }

        Console.WriteLine("");

        foreach (var name in names1) // 배연 안에 값이 있으면 출력 반복  C#  Windows Forms  ASP.NET
        {
            Console.WriteLine(name);
        }
    }
}