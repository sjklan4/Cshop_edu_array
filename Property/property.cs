//속성 : 필드의 값을 읽거나 쓰거나 꼐산하는 방법을 제공하는 클래스의 속성을 나타내는 멥버
// C#의 모든 멤버는 대문자로 시작
using System;

class Car 
{
    private string name; //필드 
    public string Name  // 속성부분
    { 
        get { return name; } //name을 받고 - 선언된 private를 입력
        set { name = value; } // Main에 셋팅된 값을 받아오는 부분
    }
     // 위 부분을 대체 가능한 설정  = public string Name {get; set;} = "기본 값"; 의 모양으로 기본값을 정해줄수 있다.
    public void SetName(string name)
    { 
        this.name = name;
    }

    static void Main()
    { 
        Car car = new Car();
        car.Name = "My Car"; // = Car car = new Car() {Name = "My Car"}; -> Object initializer
       
        Console.WriteLine(car.Name);
    }
}
