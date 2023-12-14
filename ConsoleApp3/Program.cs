using System;


//병합 알고리즘 : 
class MergeAlgorithm 
{
    static void Main()
    {
        // input
        int[] first = { 1, 3, 5 };
        int[] second = { 2, 4 };
        int M = first.Length;  //슈도 - 각 길이를 담아주는 변수
        int N = second.Length; // M:N관행
        int[] merge = new int[M + N]; // 병합된 배열을 담을 그릇 
        int i = 0;
        int j = 0;
        int k = 0; // i,j,k 관행

        // process
        while (i<M && j<N)  //둘중 하나라도 배열의 끝에 도달할 때까지 
        {
            if (first[i] <= second[j])  //더 작은값을 merge배열에 저장
            {
                
                merge[k++] = first[i++];

            }
            else 
            { 
                merge[k++] = second[j++];
                
            }

        }
        //while (i<M) // 첫 번째 배열이 끝까지 도달할 때까지
        //{
        //    merge[k++] = first[i++];

        //}
        //while (j < N)// 두 번째 배열이 끝까지 도달할 때까지
        //{
        //    merge[k++] = second[j++];

        //}
    


        // OutPut
        foreach (var m in merge)
        {
            Console.Write($"{m}\t");
        }
        Console.WriteLine();
    }

}

//람다 방식(체이닝 식)
// int[] merge = (from o in first select o).Union(from t in second select t).OrderBy(m => m).ToArray();
