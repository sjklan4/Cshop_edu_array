namespace EventAdnDelegateDemo
{
    class Car
    {
        // 이벤트 게시자
        private int _fuelGauge;
        private int fuleGauge
        { 
            get { return _fuelGauge; }
            set 
            { 
                _fuelGauge = value;
                OnFuelemty();
            } 
        
        }
        public Car()
        {
           _fuelGauge = 25; // 기본값 25%라고 가정
        }
        public void Go()
        {
            Console.WriteLine("운전");
            fuleGauge -= 5;
        }
    /*    public delegate void FuelEmptyNoitfication(); //대리자
        public event FuelEmptyNoitfication FuelEmpty;*/ //
        // 위구문을 대신할 수 있는 구문 - 2줄을 대신 하는 구문
        public event Action FuelEmpty;
        public void OnFuelemty()
        {
            Console.WriteLine($"연료 상태 : {_fuelGauge}%");
            if (_fuelGauge < 20)
            {    
                if (FuelEmpty != null)
                {
                    FuelEmpty?.Invoke();
                }
            }
        }
    }
}

