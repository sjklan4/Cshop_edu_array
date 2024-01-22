using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HOD_Inspect
{
    public class cScaner
    {
        public SerialPort SP;

        public event Action<string> vReceive;
        public bool ISOPEN = false;
        public cScaner(string com, int baudrate)
        {
            SP = new SerialPort(com, baudrate);
            SP.NewLine = $"{Convert.ToChar(0x0d)}";
            SP.DataReceived += SP_DataReceived;
            SP.ReadTimeout = 1000;
            var s = SerialPort.GetPortNames();
            foreach (var m in s)
            {
                if ((m == com) && (!SP.IsOpen))
                    SP.Open();
            }
            ISOPEN = SP.IsOpen;
        }

        private void SP_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string CR = $"{Convert.ToChar(0x0D)}";
            try
            {
                string data = SP.ReadLine();
                
                vReceive?.Invoke(data);
            }catch
            {

            }
        }

        public void Close()
        {
            if (SP.IsOpen) SP.Close();
        }
    }
}
