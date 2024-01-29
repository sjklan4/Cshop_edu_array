using ClassNamesapceCode;
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

    public partial class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public partial class Person
    {
        public void Print() => Console.WriteLine($"{Name} : {Age}");

    }

  
    class ObjectNote 
    {
        static void Main() 
        { 
            Counter counter = new Counter();
            counter.GetTodayVisitCount();

            Person person = new Person();

            person.Name = "C#";
            person.Age = 29;

            person.Print();
        }
    }

}
