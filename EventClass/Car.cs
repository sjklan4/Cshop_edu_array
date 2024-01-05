namespace EventAdnDelegateDemo
{
    class Car
    {
        // 이벤트 게시자
        private int _fuelGauge;
        private int fuleGauge
        { 
            get { return _fuelGauge; }
            set { _fuelGauge = value; } 
        
        }
        public Car()
        {
           _fuelGauge = 25; // 기본값 25%라고 가정
        }
        public void Go()
        {
            Console.WriteLine("운전");
            _fuelGauge -= 5;
        }
        public delegate void FuelEmptyNoitfication();
        public event FuelEmptyNoitfication FuelEmpty;
        public void OnFuelemty()
        {
            if (FuelEmpty != null)
            {
                FuelEmpty?.Invoke();
            }
        }
    }
}

