﻿using System;
using System.Text;

//class StringPerformance
//{
//    static void Main()
//    { 
//        DateTime start = DateTime.Now;

//        string msg = "";
//        for (int i = 0; i < 10000; i++) 
//        {
//            msg += "안녕하세요";        
//        }
//        DateTime end = DateTime.Now;
//        double exec = (end - start).TotalMilliseconds;
//        Console.WriteLine(exec);

//    }
//}

class StringBuiderPerformance
{
    static void Main()
    { 
        DateTime start = DateTime.Now;
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 10000; i++)
        {
            sb.Append("안녕하세요.");
        }

        DateTime end = DateTime.Now;
        double exec = (end - start).TotalMilliseconds;
        Console.WriteLine(exec);
    }
}
