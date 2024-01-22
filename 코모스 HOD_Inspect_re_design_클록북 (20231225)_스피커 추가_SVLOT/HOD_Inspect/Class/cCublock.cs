using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOD_Inspect
{
    public static class cCublock
    {
        public static event Action<string> vReceive;
        private static SerialPort Sp = null;
        public static bool ISOPEN = false;

        public static void Init(string com, int baudrate)
        {
            Sp = new SerialPort(com, baudrate);
            Sp.NewLine = $"{Convert.ToChar(0x0a)}";

            var s = SerialPort.GetPortNames();
            foreach (var m in s)
            {
                if ((m == com) && (!Sp.IsOpen))
                {
                    Sp.DataReceived += Sp_DataReceived;
                    Sp.Open();
                }
            }
            ISOPEN = Sp.IsOpen;
        }

        private static void Sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string MSG = Sp.ReadLine();
            MSG = MSG.Replace("\r", "");
            vReceive?.Invoke(MSG);
        }

        public static void Write(string script)
        {
            if (Sp.IsOpen)
                Sp.Write(script);
        }

        public static void Close()
        {
            if (Sp.IsOpen)
                Sp.Close();
        }
    }
}
