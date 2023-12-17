using System;
using System.Runtime.InteropServices;

namespace Desturctor
{
    class Car
    {
        private string _name;
        public Car() : this("기본자동차") { }
        public Car(string name)
        {
            _name = name;
            Console.WriteLine($"{this._name} 생성, 조립 , 시동");
        }
        public void Go() => Console.WriteLine($"{this._name}달리다");
        ~Car() 
        {
            Console.WriteLine($"{this._name}소멸");
        }

      
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Go();
            Car car2 = new Car("람보르기니");
            car2.Go();

        }
    }
}
