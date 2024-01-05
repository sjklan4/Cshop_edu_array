using System;

namespace EventAdnDelegateDemo
{
    //이벤트 구독자
    class EventAndDelegate
    {
        static void Main()
        { 
            Car car = new Car();
            car.FuelEmpty += Car_FuelEmpty;
            car.FuelEmpty -= Car_FuelEmpty;
            car.FuelEmpty += () => 
            { 
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("연료부족");
                Console.ResetColor();
            
            };
            car.Go();
            car.OnFuelemty();
        }

        // 이벤트 처리기(핸들러)
        private static void Car_FuelEmpty() =>
        
            Console.WriteLine( "연료 부족");
        
    }
}

