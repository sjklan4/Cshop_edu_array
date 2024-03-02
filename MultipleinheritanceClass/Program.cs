//상속 :  부모 클래스에 정의된 기능을 다시 사용, 확장 및 수정하여 자식 클래스로 만들기
// object클래스로 부터 모든 기능을 상속 받도록 되어있다 각 클래스 뒤에는 : object가 생략된 상태
// 부모class안에 있는 기능 값등을 자식class에서 바로 사용 할 수 있도록 '.부모class 기능 이름' 형태로 만들어 주면 된다.
using System;

namespace DotnetInheritance
{
    public enum CarType { 전기, 내연기관}

    public abstract class CarPart
    {
        public abstract void Left(); // 추상 클래스의 추상 메서드, 본문 X, 시그니처 0 => 표준(강제) => 인터페이스
        public void Part() => Console.WriteLine("범퍼센서");
    }


    public abstract class CarBase //최초 클래스
    {
        public abstract void right();
        public void Back() => Console.WriteLine("후진하다");
        
    }

    public class Car :CarBase // 첫번째 상속
    {
        public override void right() => Console.WriteLine("우회전");
        public void Go() => Console.WriteLine("달리다");
        public CarType Style { get; private set; }
        public Car(CarType carstyle)
        {
            this.Style = carstyle;
        }
    }


    public class Benz : Car //상속 형태 - 두번째 상속
    {
        
        public Benz() : this(CarType.내연기관){}


        public Benz(CarType carType) : base(CarType.내연기관) { }
      
    }

    public class Tesla : Car //sub :Base / child : Parent, Child Extends Parent
    {
        public Tesla() :this(Car)
        {
               
        }

        public Tesla(CarType carType) : base(carType) { }
       
    }


    class IngeritanceNote : Object
    {
        static void Main()
        {
            Benz benz = new Benz(CarType.전기); benz.Go(); Console.WriteLine($"{benz.Style}"); benz.Back(); benz.right();
            Tesla tesla = new Tesla(); tesla.Go(); Console.WriteLine($"{tesla.Style}");
        }
    }
}