// 설명 예시 
//enum Animal { Mouse, Cow, Lion} - enum 의 이름과 {}안에 항목들을 입력
//Animal animal = Animal.Cow; - enum의 이름에 대한 변수 선언 $animal = Cow(php변수해석기준) 
//                              animal은 Cow를 의미
//animal - animal을 호출 시키면 Cow가 출력됨 
// 정리 : enum은 항목들의 이름을 지정해서 그 이름안에 항목 내용들을 담은 다음 변수이름을 
//          지정해서 그 값을 지정하면 그 항목안에 있는 내용을 호출해서 그 값을 직접 부르거나 
//          '(int)값이름' 형식을통해서 그 항목값의 위치 번호를 반환 시킬수도 있다. 


using System;

enum Priority
{ 
    High,
    Normal,
    Low
}

class EnumrationDemo
{
    static void Main()
    {
        Priority high = Priority.High;
        Priority normal = Priority.Normal;
        Priority low = Priority.Low;

        Console.WriteLine($"{high}, {normal}, {low}");
    }
}