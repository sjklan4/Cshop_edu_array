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
        numberStack.Push(51);
        numberStack.Push(101);
        numberStack.Push(42);
        nameStack.Push("John Doe");
        nameStack.Push("Json");

        // 스택에서 값 팝
        int poppedNumber2 = numberStack.Pop();
        int poppedNumber1 = numberStack.Pop();
        int poppedNumber = numberStack.Pop();
        string poppedName = nameStack.Pop();
        string poppedName1 = nameStack.Pop();

        // 콘솔에 출력
        Console.WriteLine("Popped Number: " + poppedNumber2);
        Console.WriteLine("Popped Number: " + poppedNumber1);
        Console.WriteLine("Popped Number: " + poppedNumber);
        Console.WriteLine("Popped Name: " + poppedName);
        Console.WriteLine("Popped Name: " + poppedName1);
    }
}
//stack 출력 방식은 데이터를 순서대로 쌓은다음 위에서 부터 차례로 출력 또는 사용 하는 것으로 쌓여 있는것을 위에서 부터 사용 후입선출법으로 출력된다.
// 두 개의 서로 다른 타입을 갖는 스택 객체를 생성
//MyStack<int> numberStack = new MyStack<int>();
//MyStack<string> nameStack = new MyStack<string>();