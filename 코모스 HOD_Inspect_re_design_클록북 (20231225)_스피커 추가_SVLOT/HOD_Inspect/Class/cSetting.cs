using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOD_Inspect // namespace를 이용 해서 클래스 구분 - 각 클래스들의 소속을 지정
{
    public static class cSetting
    {
        public static cProgramSet Set = new cProgramSet();

        public static bool Load()
        {
            string file = $@"{Application.StartupPath}\ProgramSet.xml";
            if (File.Exists(file))
            {
                Set = Set.DeSerialize(file);
                return true;
            }
            else return false;
        }
        public static void Save()
        {
            string file = $@"{Application.StartupPath}\ProgramSet.xml";
            if (File.Exists(file))
            {
                File.Copy(file, $@"{Application.StartupPath}\ProgramSet.bak", true); // Copy
                File.Delete(file);
            }
            Set.Serialize(file);
        }
    }

    [Serializable]
    public class cProgramSet
    {
        public int Work_Time = 30;
        public double MIN = 0;
        public double MAX = 500;
        public double D_MIN = 0;
        public double D_MAX = 500;

        // 20230915 JHLEE
        public double MIN2 = 0;
        public double MAX2 = 500;
        public double D_MIN2 = 0;
        public double D_MAX2 = 500;

        public double R_MIN = 3;
        public double R_MAX = 8;
        public bool PrintUSE = false;
        public bool LCRUSE = false;

        public string isIEE = "IEE";      // JHLEE 20240116  IEE 이면 check (TRUE), JOYSON  이면 false.

        public string PLCCOM = "COM5";
        public string LCRCOM = "COM6";
        public string PrintCOM = "COM3";
        public string ScanCOM = "COM4";
        public string LCRIP = "192.168.1.101";
        public string MAINIP = "192.168.68.103";
        public string X = "0";
        public string Y = "0";
        public int MIN_V = 5;
        public bool DbCheck = false;
        public bool Word_Loc = false;
        public string Word = "K";
    }

    
}
