﻿using System;


class BubleSort
{
    


    static void Main() 
    {
        int[] data = { 3, 2, 1, 5, 4 };
        Array.Sort(data);
        Console.WriteLine(string.Join(", ", data));
        

        Array.Reverse(data);
        Console.WriteLine(string.Join(", ", data));

        for (int i = 0; i < data.Length; i++)
        {
            for (int j = 0; j < data.Length; j++) 
            {
                if (data[i] > data[j])
                { 
                    int temp = data[i];
                    data[i] = data[j];
                    data[j] = temp;

                }
            }

        }

    }
}