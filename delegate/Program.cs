//대리자는 delegate 키워드를 사용
//대리자는 함수 자체를 데이터 하나로 보고 의미 그대로 다른 메서드를 대신 실행
//한 번에 하나 이상을 대신해서 호출할 수 있는 개념


using System;

class DelegateDemo
{
    static void Goforward() => Console.WriteLine("직진");
    static void Goleft() => Console.WriteLine("좌회전");
    static void Gofast() => Console.WriteLine("과속");
    delegate void CarDriver(); //대리자 형식 생성


    static void Main()
    {
        Goforward(); //직접 호출
        //CarDriver goHome = new CarDriver(Goforward); // 대리 운전
        CarDriver goHome = Goforward;
        goHome += Goleft; goHome += Gofast; goHome -= Gofast;
        //goHome += delegate () { Console.WriteLine("우회전"); }; //무명 메서드 / 익명함수
        goHome += () => Console.WriteLine("후진"); //람다 식
        goHome();
        
        // 내장된 대리자 형식을 통해서 직접 대리자 개체 생성
        Action driver = Goforward;
        driver += Goleft;
        driver += () => Console.WriteLine("후진");
        driver();

        Action go = () => Console.WriteLine("운전");
        go();

        
    }
}