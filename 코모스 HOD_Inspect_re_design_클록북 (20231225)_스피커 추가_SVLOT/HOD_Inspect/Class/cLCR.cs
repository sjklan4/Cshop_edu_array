using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HOD_Inspect
{
    public static class cLCR
    {
        public static event Action<double> vReceive;
        private static SerialPort SP;
        public static void Init(string com, int baudrate)
        {
            SP = new SerialPort();
            SP.PortName = com;
            SP.BaudRate = baudrate;
            SP.DataBits = 8;
            SP.StopBits = StopBits.One;
            SP.Parity = Parity.None;
            SP.NewLine = $"{Convert.ToChar(0x0a)}";
            var s = SerialPort.GetPortNames();
            foreach (var m in s)
            {
                if ((m == com) && (!SP.IsOpen))
                {
                    SP.DataReceived += SP_DataReceived;
                    SP.Open();
                }
            }
        }

        public static bool ReadRun = true;
        public static void Stop()
        { 
            ReadRun= false; 
        }

        public static void Read()
        {
            if (SP != null && SP.IsOpen)
            {
                SP.Write($"MEAS:RES?{Convert.ToChar(0x0d)}{Convert.ToChar(0x0a)}");
                //SP.Write($"FETCh:MONitor?{Convert.ToChar(0x0d)}{Convert.ToChar(0x0a)}");
            }
        }
        public static double Z = 0;
        public static double R = 0;

        private static void SP_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = SP.ReadLine();
            double D = double.Parse(data, System.Globalization.NumberStyles.Float);// Data.ToDouble();

            data = D.ToString();
            //var splitdatas = data.Split(',');
            R = data.ToDouble();
            vReceive?.Invoke(R);
            //Console.WriteLine($"{Z} - {R}");
        }

        public static void DisConnect()
        {
            ReadRun = false;
            Thread.Sleep(1000);
            if (SP != null && SP.IsOpen)
                SP.Close();
        }
    }
}

