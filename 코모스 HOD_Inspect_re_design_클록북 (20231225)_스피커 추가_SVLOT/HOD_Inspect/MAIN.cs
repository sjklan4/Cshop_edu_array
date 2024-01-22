using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOD_Inspect
{
    static class MAIN
    {
        public static fmMain fmain;
        public static event Action<string, string> v_Changed;
        public static bool Running = true;
        public static bool ModelSelect = false;
        public static List<bool> M = new List<bool>();
        public static bool PLCsts = false;
        public static double MT_V = 0;
        public static double MT_D = 0;
        public static double MT_R = 0;
        public static cLCR_pF LCR;
        public static AutoResetEvent LCR_SET = new AutoResetEvent(false);
        public static AutoResetEvent R_SET = new AutoResetEvent(false);
        public static bool ModelSelection = false;
        public static string SelCar = string.Empty;
        public static string Status = string.Empty;
        public static cScaner SCAN;

        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            fmain = new fmMain();
            v_Changed += fmain.ModelChange;

            cSetting.Load();

            Db.MAIN_IP = cSetting.Set.MAINIP;

            cCublock.Init(cSetting.Set.PLCCOM, 19200);
            cCublock.vReceive += CCublock_vReceive;

            BPrint.Init(cSetting.Set.PrintCOM, 9600);

            LCR = new cLCR_pF(cSetting.Set.LCRIP, 5025);
            LCR.Connect();
            LCR.vReceive += LCR_vReceive;

            cLCR.Init(cSetting.Set.LCRCOM, 9600);
            cLCR.vReceive += CLCR_vReceive;

            SCAN = new cScaner(cSetting.Set.ScanCOM, 9600);

            Application.Run(fmain);
        }

        private static void CCublock_vReceive(string obj)
        {
            Status = obj;
        }

        private static void CLCR_vReceive(double obj)
        {
            MT_R = Math.Round(obj, 2);
            R_SET.Set();
        }

        private static void LCR_vReceive(string arg1, byte[] arg2)
        {
            var V = arg1.Split(',');
            var M = V[0].Split('E');

            var M1 = V[1].Split('E');
            string D1 = Convert.ToDouble(V[0]).ToString("f12");
            string D2 = Convert.ToDouble(V[1]).ToString("f12");

            MT_V = D1.ToDouble();
            for (int i = 0; i < 4; i++)
            {
                MT_V *= 1000;
            }
            //MT_V = Math.Round(M[0].ToDouble() * 1000, 2);
            //MT_D = Math.Round(M1[0].ToDouble(), 2);
            //MT_V = D1.ToDouble();
            MT_D = Math.Round(D2.ToDouble(), 5);
            LCR_SET.Set();
        }

        private static void CMKPLC_vRECEIVE(int arg1, int[] arg2)
        {
            PLCsts = true;
            if (arg1 == 0)
            {
                M = arg2[0].InttoBit(16);
            }
        }

        public static void OnModelChange(string Car ,string PartNo)
        {
            v_Changed?.Invoke(Car, PartNo);
        }
    }
}
