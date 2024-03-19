// 확장 메서드는 특정 행위 값에 내가 원하는 메서드(확장 메서드)를 만들어서 사용 하는 방식

using System;
using System.Runtime.CompilerServices;

namespace MyExtensions
{
    static class StringExtension
    {
        public static string Five(this string message) => message.Substring(0, 5);
        public static string Ten(this string message) => message.Substring(0, 10);
    
    }
    class MyExtensionsDemo
    {
        static void Main()
        {
            string message = "안녕하세요. 반갑습니다.";   
            Console.WriteLine(message.Five().Ten());
        }
    }
}