using System;

namespace ObjectNpte 
{
    public class Counter
    {
        public void GetTodayVisitCount()
        {
            Console.WriteLine("확인용");
        }
    }
    class ObjectNote 
    {
        static void Main() 
        { 
            Counter counter = new Counter();
            counter.GetTodayVisitCount();
        }
    }

}
