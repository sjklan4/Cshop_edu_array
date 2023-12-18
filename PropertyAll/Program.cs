using System;

namespace PropertyAll 
{
    public class Car 
    {
        private string color; // 필드

        public Car()   // 생성자
        { 
            this.color = "Black";
        }

        //메서드로 외부공개
        public void SetColor(string color)
        {
            this.color = color; //this.필드 = 매개변수;
        }

        public string GetColor()
        {
            return color;
        }

        //속성
        public string Color
        {
            get
            {
                return color;
            }
            set
            { 
                color = value;
            }


        }
        // 읽기 전용 속성
        public string Make
        {
            get
            {
                return "벤비아제";
            }

        }

        //쓰기 전용 속성
        private string _Type;
        public string Type
        {
            set
            {
                _Type = value;
            }
        }
        public string Name { get; set; }
    }
    class PropertyAll
    {
        static void Main()
        { 
            // Set과 Get 메서드 사용
            Car car1 = new Car();
            car1.SetColor("RED");
            Console.WriteLine(car1.GetType());

            // 속성을 사용
            Car whiteCar = new Car();
            whiteCar.Color = "White";           //set {}
            Console.WriteLine(whiteCar.Color);  //get {}

            // 쓰기 전용 속성
            Car car = new Car();
            car.Type = "중형";                // 쓰기만 가능

            // 축약형 속성
            Car myCar = new Car();
            myCar.Name = "좋은차";
            Console.WriteLine(myCar.Name);
        }
    }

}