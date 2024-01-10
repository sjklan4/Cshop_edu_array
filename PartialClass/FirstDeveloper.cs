using System;

namespace PartiaClassDemo
{
    partial class PartialClassDemo 
    {
        public partial class Hello
        {
            public void Hi() => Console.WriteLine("FirstDeveloper.cs");
        }
    }
}