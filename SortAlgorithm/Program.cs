using System;


class SortAlgorithm 
{
    static void Main()
    {
        // Input
        int[] data = { 3, 2, 1, 4, 5,7,8,9 };
        int N = data.Length; //의사코드(슈도코드) 형태로 알고리즘 표현

        // Process : Selection Sort(선택 정렬)
        for (int j = 0; j < N; j++)
        {
            for (int k = j + 1 ; k < N; k++)
            {
                
                if (data[j] < data[k]) 
                {
                    int tmp = data[j];
                    data[j] = data[k];
                    data[k] = tmp;
                }
            }
            
        }


        //Output
        for (int i = 0; i < N; i++)
        {
            Console.Write($"{data[i]}\t");
        }
       
    }
    

}
