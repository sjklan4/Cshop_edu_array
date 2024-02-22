using static System.Console;

namespace InterfaceNote
{
    abstract class KS
    {
        public abstract void Back();
    }

    partial class MyCar : KS // 동일 이름의 클래스를 나눠서 개발 가능 - 분할 클래스 =  부분 클래스
    {

    }

    partial class MyCar : KS
    {
        public void Right() => WriteLine("우회전");
    }
     //앞에 sealed를 붙이면 상속이 안되도록 막을수 있다.
    class Car : MyCar
    {
        public void Run() => WriteLine("직진");
    }

    class SpyCar : Car
    { 
        
    }
    class InterfaceNote
    {
        
        static void Main()
        {
            Car car = new Car();
            car.Run(); car.Right();
            SpyCar spy = new SpyCar(); spy.Run();
        }
    }
}