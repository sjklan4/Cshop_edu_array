using System;

public class Car
{

    private string name; //=private readonly string name;
    public Car() 
    {
        // 기본 생성자, 생성자 메서드

        //Console.WriteLine( "자동차 개체를 생성함, 시동 걸기");

        name = "기본 자동차";
    }
    public Car(string name)  // = public Car(string name) => this.name = name;방식도 같은 형식(람다형식)
    {
        this.name = name; // this.필드 = 매개변수 
    }
    public void Go() => Console.WriteLine($"{name}가 달리다");

}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car(); // = (new Car()).Go();도 같은 형식의 코드.
        car.Go();
        Car my =  new Car("좋은 자동차");  //이 자리의 car에 arg를 주기 위해서 위에 public car부분에(string name)추가 string name을 받아 놓기 위해 private name 필드 생성
        my.Go();
    }
}