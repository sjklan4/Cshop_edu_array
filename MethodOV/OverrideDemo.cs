//오버로드 : 같은 이름의 매서드를 여러번 호출 시켜서 매개변수에 따라서 사용하는 방법 - 오버해서 로딩 시켰다.
//오버라이드 : 부모클래스(상위 클래스)에서 정의된 것을 다시 자시클래스(하위 클래스)에서 정의해서 사용한다. - 하위가 상위한테 올라 탔다
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MethodOV
{

    class Parent
    {
        protected void say() => System.Console.WriteLine("부모_안녕하세요."); //protected설정시 자식 클래스에서만 사용 가능
        protected void Run() => System.Console.WriteLine("부모_달린다.");
        public virtual void Walk() => System.Console.WriteLine("부모_걷다."); //virtual 은 상속시 변경을 혀옹 시켜준다.
        public virtual void Work() => System.Console.WriteLine("부모_프로그래머."); //virtual 은 상속시 변경을 혀옹 시켜준다.

    }

    class child : Parent 
    {
        public void say() => System.Console.WriteLine("다시 정의한 안녕하세요"); //부모 클래스에 정의 된것을 자식 클래스에서 다시 같은 이름을 가지고 정의 할 수 있다.
        public new void Run() => System.Console.WriteLine("자식_달린다."); //부모 클래스 함수를 다시 정의 하기 위해서 new를 추가 한다.
        //public new void Work() => System.Console.WriteLine("자식_프로게이머.");
        public override void Walk() => base.Walk(); // 부모 클래스 기능을 그대로 사용 한 경우
        public override void Work() => System.Console.WriteLine("자식_프로게이머"); //부모 클래스 기능을 가져와서 다시 정의 해서 사용 
       
    }

    class Override 
    { 
        static void Main()
        { 
            child ch = new child(); 
            ch.say();
            ch.Run();
            ch.Work();
            ch.Walk();
        }
    }
}
