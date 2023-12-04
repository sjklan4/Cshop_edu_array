using System;

class RandomClass
{
    static void Main()
    {
        Console.Write("추천 번호 : ");
        Random ran = new Random();
        int[] arr = new int[6];
        int temp = 0;
        for (int i = 0; i < 6; i++)
        {
            temp = ran.Next(45) + 1;
            bool flag = false;
            if (i > 0 && i < 6)
            {
                for (int j = 0; j <= i; j++) 
                {
                    if (arr[j] == temp)
                    {
                        flag = true;
                    }
                }

            }
            if (flag)
            {
                --i;
            }
            else 
            {
                arr[i] = temp;
            }

        }
        for (int i = 0; i < 6; i++)
        {
            Console.Write(" {0} ", arr[i]);
        }
        Console.WriteLine();

    }
}