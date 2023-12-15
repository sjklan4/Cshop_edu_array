using System;
using Foo; //다른 클래스를 참조 하기 위한 구문




namespace MyNamespace   //클레스 이름 충돌 방지용 기능
{
    class MyClass 
    {
        static void Main(string[] args)
        {
            Foo.Car car1 = new Foo.Car(); //참조되는 클래스 이름은 프로젝트 이름과 같아야 한다. Foo.Car.cs파일 형식 사용
            car1.Go();

            Bar.Car car2 = new Bar.Car();
            car2.Go();
        }
    }
}