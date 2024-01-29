using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNamesapceCode
{
    internal class Class1
    {
        public partial class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }

        public partial class Person
        {
            public void Print() => Console.WriteLine($"{Name} : {Age}");

        }

      
    }
}
