// 구조체 : 하나 이상의 변수를 또는 배열을 묶어서 관리
using System;
struct Point // 구조의 이름 정의
{
    public int X; // public(공용)

    public int Y;

    private int Z; // private(전용)

}

struct BusinessCard
{
    public string Name;
    public int Age;
    public string Address;
}

class StructDemo
{
    static void Main() {
        Point point;
        point.X = 100;
        point.Y = 200;
        Console.WriteLine($" X: {point.X}, Y:{point.Y}");
        Console.WriteLine("");

        BusinessCard my;
        my.Name = "Test";
        my.Age = 33;
        my.Address = "경북 경산시 압독3로 2길 11-3";
        Console.WriteLine($" Name : {my.Name}, Age : {my.Age}, Address : {my.Address}");

    }

}

