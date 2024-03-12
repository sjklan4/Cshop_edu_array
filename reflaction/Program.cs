

using System;
using System.Diagnostics;
using System.Reflection;

namespace AttributeDeom
{
    public class LuxuryAttribute : Attribute 
    {
        public LuxuryAttribute() => Console.WriteLine("럭셔리1!");
    }
    [LuxuryAttribute]
    class Car
    {
        [Obsolete("다음 버전에서 제거 예정")] // 아래 있는 메서드를 더이상 하용 하지 않도록 만드는 기능 - 기존 프로그램에서 메서드를 사용 하지 않으면서 프로그램의 구조에 영향을 주지 않을수 있다.
        public void Manual() => Console.WriteLine("수동");
        public void Auto() => Console.WriteLine("자동 운전");
        [Conditional("DEBUG")]public void Test() => Console.WriteLine("테스트 운전"); //DEBUG로 해당 메서드를 인식하도록 해준다.
        [Conditional("RELEASE")] public void Test2() => Console.WriteLine("테스트 운전");
    }
    class AttributeDeomo
    {
        static void Main()
        { 
            Car car = new Car();
            car.Manual();
            car.Auto(); // car.Manual();
            car.Test();
            Attribute.GetCustomAttributes(typeof(Car)); // 
            typeof(Car).GetCustomAttributes(false);
            var carType = (new Car()); 
            Type myCar = carType.GetType();
            MethodInfo info = myCar.GetMethod("AUTO");
            info.Invoke(carType, null);



        }
    }
}