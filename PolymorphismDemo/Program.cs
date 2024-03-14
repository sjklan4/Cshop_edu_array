using System;

namespace PolymorphismDemo
{
    public abstract class Animal
    {
        public abstract string Cry();
    
    }

    public class Dog : Animal
    {
        public override string Cry() => "짖는다.";
        
    }

    public class Cat : Animal
    {
        public override string Cry() => "운다";


    }

    public class Trainer
    {
        public void DoCry(Animal animal)
        { 
            Console.WriteLine("{0}", animal.Cry());
        
        }
    }

    class PolymorphismDemo
    {
        static void Main(string[] args)
        { 
            
        }
    }
}