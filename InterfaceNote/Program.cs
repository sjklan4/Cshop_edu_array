using static System.Console;

namespace InterfaceNote
{
    public interface ICarStandard
    {
        void Left();

    }


    abstract class KS // 추상 클래스 매서드 시그니쳐만 제공 , 상속받는 모든 매서드에서 주어진 이름(지금은 back)으로 정의해서 사용하라는 의미
    {
        public abstract void Back();
        public void Fly() => WriteLine("날다");
    }

    partial class MyCar : KS // 동일 이름의 클래스를 나눠서 개발 가능 - 분할 클래스 =  부분 클래스
    {
        public override void Back() => WriteLine("후진"); //추상 매서드는 정확한 표시가 필요함으로 public 다음 override라는 표시를 해야 된다.
    }

    partial class MyCar : KS
    {
        public void Right() => WriteLine("우회전");
    }
     //앞에 sealed를 붙이면 상속이 안되도록 막을수 있다.
    sealed class Car : MyCar, ICarStandard // 연속 상속시에 interface를 통해서 추가적인 상속을 진행할 수 있다. - 중복 상속
    {
        public void Left() => WriteLine("좌회전");
       

        public void Run() => WriteLine("직진");
    }

  /*  class SpyCar : Car
    { 
        
    }*/
    class InterfaceNote
    {
        
        static void Main()
        {
            Car car = new Car();
            car.Run(); car.Right(); car.Back(); car.Left();
            car.Fly();
            //SpyCar spy = new SpyCar(); spy.Run();
        }
    }
}