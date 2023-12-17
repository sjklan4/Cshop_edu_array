using System;

class Car
{

    public void Map(params string[] title) //가변 길이
    {
        foreach (var t in title)
        {
            Console.WriteLine(t);
        }   
    }
}
