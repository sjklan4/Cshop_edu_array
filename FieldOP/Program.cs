//Read-Only 필드 : public readonly deciaml Price - 대문자로 시작 가능 
// 클래스 내에 선언된 상수와 비슷하나 선언과 동시에 초기화 또는 생성자를 통해서 초기화
// public 액세스 한정자 지정 가능 - 필드는 private 액세스 한정자 권장

using System;
using System.Threading.Channels;

public class Car
{
    public string color = "RED"; // Car 클래스 안에 있는 필드
    private int CC = 2000;

    public string GetColor => color;
    public void EnginVol()
    { 
        Console.WriteLine(this.CC);
    }

}



public class Say 
{
    private string message = "확인합니다."; // 필드
    public void Hi()
    {
        Console.WriteLine(this.message); 
    }

}


public class Person 
{
    private string name = "박상준";
    private const int m_age = 21; // 필드 = 맴버 변수, 전역 변수
    private readonly string _NickName = "sjklan";
    private string[] _websites = { "PHP", "Laravel" };

    public void ShowProfile() => Console.WriteLine($"{name} - {string.Join(",", _websites)}");
}
class Program
{
    private static string message = "안녕하세요"; //필드, 전역 변수
    public static void Hi() => Console.WriteLine(message);
    static void Main(string[] args)
    {
        int number = 1_234; //지역 변수
        Console.WriteLine(number);
        Console.WriteLine(message);
        Hi();

        // Say class에 있는 Hi 매서드를 호출하기 위한 구문 
        Say say = new Say();
        say.Hi();

        Car car = new Car();
        Console.WriteLine(car.color);
   
        Car cc = new Car();
        cc.EnginVol();

        Car car1 = new Car();
        Console.WriteLine(car.GetColor);

        Person my = new Person();
        my.ShowProfile();

    }
}