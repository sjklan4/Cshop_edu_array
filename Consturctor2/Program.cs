using System;

public class Dog
{
    private string name;
    private string namein;
    private int agein;
    public Dog(string name)
    {
        this.name = name;
    }
    public string Cry()
    {
        return name + "이가 멍멍";
    }



    public Dog(string name, int age) 
    {
        this.namein = name;
        this.agein = age;
    }
    public void PrintDogin() 
    {
        Console.WriteLine($"이름 ; {this.namein}, 나이 : {this.agein}");
    }



    static void Main() 
    {
        Dog dog = new Dog("마스티프");
        Console.WriteLine( dog.Cry());
        Dog dog1 = new Dog("말티즈", 12);
        dog1.PrintDogin();
    }
}