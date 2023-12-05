//예외 처리 

using System;

//상세 오류 상태 보기 
//class TryCatch
//{
//    static void Main()
//    {
//        try
//        {
//            int[] arr = new int[2];
//            arr[100] = 1234;

//        }
//        catch (Exception ex) 
//        {
//            Console.WriteLine(ex.Message);
//        }
//    }
//}


// 예외 메세지를 사용자가 직접 정한다.
class TryCatch
{
    static void Main()
    {
        try
        {
            int[] arr = new int[2];
            arr[100] = 1234;

        }
        catch
        {
            Console.WriteLine("에러가 발생했습니다.");
        }
    }
}