using System;
using System.Collections.Generic;
using System.Transactions;

class MyStack<T>
{
    T[] elements;
    int pos = 0;

    public MyStack()
    {
        elements = new T[100];
    }

    public void Push(T element)
    {
        elements[++pos] = element;
    }

    public T Pop()
    {
        return elements[pos--];
    }

}
class Program
{
    static void Main()
    {
        MyStack<int> numberStack = new MyStack<int>();
        MyStack<string> nameStack = new MyStack<string>();

        // 스택에 값 푸시
        numberStack.Push(101);
        numberStack.Push(42);
        nameStack.Push("John Doe");

        // 스택에서 값 팝
        int poppedNumber1 = numberStack.Pop();
        int poppedNumber = numberStack.Pop();
        string poppedName = nameStack.Pop();

        // 콘솔에 출력
        Console.WriteLine(poppedNumber1);
        Console.WriteLine("Popped Number: " + poppedNumber);
        Console.WriteLine("Popped Name: " + poppedName);
    }
}
// 두 개의 서로 다른 타입을 갖는 스택 객체를 생성
//MyStack<int> numberStack = new MyStack<int>();
//MyStack<string> nameStack = new MyStack<string>();