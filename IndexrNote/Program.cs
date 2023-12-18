using System;

class Catalog 
{ 
    public string this[int index]
    { 
        get
        { return (index % 2 == 0) ? $"{index} : 짝수 반환" : $"{index} : 홀수 반환"; }
    }
}

class IndexrNote
{
    static void Main()
    { 
        Catalog catalog = new Catalog();
        Console.WriteLine(catalog[0]);
        Console.WriteLine(catalog[1]);
        Console.WriteLine(catalog[2]);
    }
}