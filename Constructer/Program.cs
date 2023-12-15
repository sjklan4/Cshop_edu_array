using System;

public class Car
{ 
    public Car() 
    {
        // 기본 생성자

        Console.WriteLine( "자동차 개체를 생성함");
    }

}

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
    }
}