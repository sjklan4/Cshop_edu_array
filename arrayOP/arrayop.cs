// 배열(Array) : 하나의 이름으로 같은 데이터 형식을 여러 개 보관해 놓는 그릇

using System;

class arrayOne 
{
    static void Main() {
        string arr = "C#8";
        Console.WriteLine(arr[1]);

        //int[] numbers = new int[3];
        //numbers[0] = 1;
        //numbers[1] = 2;
        //numbers[2] = 3;
        int[] numbers = {1,2,3,4,5};
   
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        int[,] numbers2 = { { 1, 2, 3, 4 }, { 4, 5, 6, 7 } };
        for (int i = 0;i < numbers2.GetLength(0); i++)
        { 
            for (int j = 0; j < numbers2.GetLength(1); j++) 
            {
                Console.Write($"{numbers2[i,j]}\t");
            }
            Console.WriteLine();
        }
    }

}
