using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;

namespace HOD_Inspect
{
    public static class BPrint
    {
        private static SerialPort Sp = null;
        //private static List<ProductInfo> info;
        private static string filename = $@"{Application.StartupPath}\ProductInfo.xml";
        public static bool ISOPEN = false;

        public static void Init(string com, int baudrate)
        {
            Sp = new SerialPort(com, baudrate);
            //Sp.DataBits = 8;
            //Sp.Parity = Parity.None;
            //Sp.StopBits = StopBits.One;
            //Sp.RtsEnable = false;

            var s = SerialPort.GetPortNames();
            foreach (var m in s)
            {
                if ((m == com) && (!Sp.IsOpen))
                    Sp.Open();
            }
            ISOPEN = Sp.IsOpen;
        }

        public static void Write(string script)
        {
            if (Sp.IsOpen)
                Sp.Write(script);
        }

        /// <summary>
        /// 최종 바코드 라벨을 출력한다.
        /// </summary>
        /// <param name="alc">ALC 코드</param>
        /// <param name="ModelName">모델명</param>
        /// <param name="serial">시리얼번호</param>
        /// <param name="partno">파트넘버</param>
        /// <peram name="PrdCount">순번</peram>
        public static void DoPrint(string serial, string partno,string Car, string Spec)
        {
            var S = serial.Substring(serial.Length - 5);
            string script = string.Empty;
            //script = $"^XA^FDtest^FS^XZ";
#if (KOMOS_MX5_SIJAK)
            // K (cSetting.Set.Word) 를 붙이는 위치를 바코드 전 , 후 (cSetting.Set.Word_Loc) 에 붙이도록 선택할수 있다.
            script = $"^XA^PON^LH{cSetting.Set.X},{cSetting.Set.Y}^FO50,10^BQN,2,4^FDMM,A{(!cSetting.Set.Word_Loc ? cSetting.Set.Word : "")}{partno}{(cSetting.Set.Word_Loc ? cSetting.Set.Word :"")}^FS"; //2
#else
            //script = $"^XA^PON^LH{cSetting.Set.X},{cSetting.Set.Y}^FO50,10^BQN,2,4^FDMM,A{partno}^FS"; //// 20230918 JHLEE  K 를 제외하고 발행하는 스크립트 울산공장 시작실 외 모든곳에 사용

            // 20231010 JHLEE 프린터 QR 내용에 로트정보추가 -> 56111P66700NNB23092900001
            script = $"^XA^PON^LH{cSetting.Set.X},{cSetting.Set.Y}^FO50,10^BQN,2,4^FDMM,A{partno}{DateTime.Now.ToString("yyMMdd")}{S}^FS";
#endif
            /*  // 20231010 JHLEE 이전 데이타 작은 QR
            //script += $"^FWB^FO140,30^A2,20,5^FDHOD OK:{DateTime.Now.ToString("yyMMdd")}-{S}^FS"; //3
            script += $"^FWB^FO140,40^A2,20,5^FDHOD OK^FS"; //3
            script += $"^FWB^FO160,25^A2,20,5^FD{DateTime.Now.ToString("yyMMdd")}-{S}^FS"; //3
            //script += $"^FWB^FO140,45^A2,20,5^FD{DateTime.Now.ToString("yyMMdd")}^FS"; //3
            script += $"^FWB^FO180,80^A2,20,5^FD{Car}^FS"; //4
            script += $"^FWB^FO180,30^A2,20,5^FD{Spec}^FS^PQ1^XZ"; //4
            */
            /* // 20231023 바코드 수정 HOD 제외하고 한칸 업
            script += $"^FWB^FO160,50^A2,20,5^FDHOD OK^FS"; //3
            script += $"^FWB^FO180,30^A2,20,5^FD{DateTime.Now.ToString("yyMMdd")}-{S}^FS"; //3            
            script += $"^FWB^FO200,90^A2,20,5^FD{Car}^FS"; //4
            script += $"^FWB^FO200,25^A2,20,5^FD{Spec}^FS^PQ1^XZ"; //4
            */
            script += $"^FWB^FO160,30^A2,20,5^FD{DateTime.Now.ToString("yyMMdd")}-{S}^FS"; //3            
            script += $"^FWB^FO180,90^A2,20,5^FD{Car}^FS"; //4
            script += $"^FWB^FO180,25^A2,20,5^FD{Spec}^FS^PQ1^XZ"; //4

            //  ^XA ^ PON ^ LH260,10 ^ FO50,80 ^ BQN,2,4 ^ FDMM,AS56111DO100EMA ^ FS
            //^FWB ^ FO140,80 ^ A0,30,10 ^ FDHOD OK: 20230621 - 00001 ^ FS
            //        ^ FWB ^ FO170,150 ^ A0,30,10 ^ FDMV1 ^ FS
            //             ^ FWB ^ FO170,90 ^ A0,30,10 ^ FDEMA HTD ^ FS ^ XZ

            if (Sp.IsOpen)
                Sp.Write(script);
        }

        internal static void DoManualPrintMat(string alc, string serial, string partno, string a, string b)
        {
            string script = string.Empty;
            script = $"^XA^PON^LH260,10^FO50,10^BQN,2,4^FDMM,A{alc}_VISION^FS"; //2
            script += $"^FO150,20^AD,54,24^FD{alc}^FS"; //3
            script += $"^FO140,90^AD,15,12^FD{partno}^FS"; //4
            script += $"^FO40,145^AD,10,10^CI13^FR^FD{DateTime.Now.ToString("yyyy-MM-dd")}^FS"; //5
            script += $"^FO165,145^AD,10,10^CI13^FR^FD{DateTime.Now.ToString("HH:mm:ss")}^FS"; //6
            script += $"^FO40,115^AD,15,12^FD{alc}{DateTime.Now.ToString("yyyyMMdd")}M^FS^PQ1^XZ";

            if (Sp.IsOpen)
                Sp.Write(script);
            cnt++;
        }

        public static int cnt = 1;
        public static void DoManualPrint(string alc, string serial, string partno, bool ManualPrint = false)
        {
            string script = string.Empty;

            // 2020.10.01 VISION OK로 변경
            //script = $"^XA^PON^LH260,10^FO40,10^BQN,2,4^FDMM,A{alc}^FS"; //2
            // script += $"^FO135,45^AC,30,10^FD{alc}^FS"; //3
            // script += $"^FO40,125^AD,15,12^FD{partno}^FS"; //4
            // script += $"^FO40,165^AD,10,10^CI13^FR^FD{DateTime.Now.ToString("yyyy-MM-dd")}^FS"; //5
            // script += $"^FO165,165^AD,10,10^CI13^FR^FD{DateTime.Now.ToString("HH:mm:ss")}^FS"; //6
            // script += $"^FO40,145^AD,15,12^FD{serial}M^FS^PQ1^XZ";


            //script = $"^XA^PON^LH260,10^FO40,10^BQN,2,4^FDMM,A{alc}^FS"; //2
            // script += $"^FO135,45^AC,30,10^FD{alc}^FS"; //3
            // script += $"^FO40,125^AD,15,12^FD{partno}^FS"; //4
            // script += $"^FO40,165^AD,10,10^CI13^FR^FD{DateTime.Now.ToString("yyyy-MM-dd")}^FS"; //5
            // script += $"^FO165,165^AD,10,10^CI13^FR^FD{DateTime.Now.ToString("HH:mm:ss")}^FS"; //6
            // script += $"^FO40,145^AD,15,12^FD{serial}M^FS^PQ1^XZ";

            script = $"^XA^LH260,10^FO40,50 ^AD,54,24 ^FDVISION OK^FS";
            script += $"^FO40,145^AD,10,10^CI13^FR^FD{DateTime.Now.ToString("yyyy-MM-dd")}^FS"; //5
            script += $"^FO40,165^AD,10,10^CI13^FR^FD{DateTime.Now.ToString("HH: mm: ss")}^FS^XZ";

            if (Sp.IsOpen)
                Sp.Write(script);
        }
         
        // jhlee 20210211  SBW 부품바코드 3개 적용 하도록 수정.
        /// <summary>
        /// HMC바코드
        /// </summary>
        /// <param name="Serial"></param>
        /// <param name="PartNo"></param>
        /// <param name="ALC"></param>
        /// <param name="Manual"></param>
        /// <returns></returns>
        static public bool HMCBarcode(string Serial, string PartNo, string ALC, List<string> RBar = null, bool Manual = false)
        {
            if(RBar != null)
              Console.WriteLine($"Read BarCode Count = {RBar.Count}");

            var S = PartNo.Split('-');
            string script = string.Empty;
            if (RBar.Count == 1)
            {
                Console.WriteLine($"RBar Count 1 실행");
                var R1 = RBar[0].Split((Convert.ToChar(0x1D)));

                script = $"^XA^LH260,10";
                script += $"^FO10,30^BXN,3,200,0,0,1,~^FH\\^FD[)>\\1E06\\1DVAIY1\\1DP{PartNo.Replace("-","")}\\1DSQ019{ALC}\\1DEHS2L0314\\1DT{DateTime.Now.ToString("yyMMdd")}M1APA{Serial}\\1D\\1E\\04";
                //script += $"#[)>\\1E06\\1D{R1[1]}\\1D{R1[2]}\\1D{R1[3]}\\1D{R1[4]}\\1D\\1E\\04^FS";
                script += $"#[)>\\1E06\\1D{R1[1]}\\1D{R1[2]}\\1D{R1[3]}\\1D\\1E\\04^FS";
                script += $"^FWN^FO10,170^AD30,30^FD{ALC}^FS";
                script += $"^FWB^FO150,30^AP10,10^FD{PartNo.Replace("-", "")}^FS";
                script += $"^FWB^FO170,30^AP5,5^FD{Serial}^FS";
                script += $"^FWB^FO190,30^AB10,10^FD{DateTime.Now.ToString("yyyy-MM-dd")}^FS";
                if (Manual) script += $"^FWB^FO210,60^AB10,10^FD#^FS";
                script += $"^FWB^FO210,30^AB10,10^FD{DateTime.Now.ToString("HH:mm:ss")}^FS^XZ";
                
            }
            else if (RBar.Count == 2)
            {
                var R1 = RBar[0].Split((Convert.ToChar(0x1D)));
                var R2 = RBar[1].Split((Convert.ToChar(0x1D)));

                script = $"^XA^LH260,10";
                script += $"^FO10,30^BXN,2,200,0,0,1,~^FH\\^FD[)>\\1E06\\1DVAIY1\\1DP{PartNo.Replace("-", "")}\\1DSQ019{ALC}\\1DEHS2L0314\\1DT{DateTime.Now.ToString("yyMMdd")}M1APA{Serial}\\1D\\1E\\04";
                script += $"#[)>\\1E06\\1D{R1[1]}\\1D{R1[2]}\\1D{R1[3]}\\1D\\1E\\04";
                script += $"#[)>\\1E06\\1D{R2[1]}\\1D{R2[2]}\\1D{R2[3]}\\1D\\1E\\04^FS";
                script += $"^FWN^FO10,165^AD30,30^FD{ALC}^FS";
                script += $"^FWB^FO150,30^AP10,10^FD{PartNo.Replace("-", "")}^FS";
                script += $"^FWB^FO170,30^AP5,5^FD{Serial}^FS";
                script += $"^FWB^FO190,30^AB10,10^FD{DateTime.Now.ToString("yyyy-MM-dd")}^FS";
                if (Manual) script += $"^FWB^FO210,60^AB10,10^FD#^FS";
                script += $"^FWB^FO210,30^AB10,10^FD{DateTime.Now.ToString("HH:mm:ss")}^FS^XZ";
            }
            //PSW 2021.02.11 바코드 3개 출력으로 수정
            else if (RBar.Count == 3)
            {
                Console.WriteLine($"RBar Count 3 실행");
                var R1 = RBar[0].Split((Convert.ToChar(0x1D)));
                var R2 = RBar[1].Split((Convert.ToChar(0x1D)));
                var R3 = RBar[2].Split((Convert.ToChar(0x1D)));
                Console.WriteLine($"R1 - {R1[1]} , {R1[2]} , {R1[3]} , {R1[4]}");
                Console.WriteLine($"R2 - {R2[1]} , {R2[2]} , {R2[3]} , {R2[4]}");
                Console.WriteLine($"R3 - {R3[1]} , {R3[2]} , {R3[3]} , {R3[4]}");
                script = $"^XA^LH260,10";
                script += $"^FO20,30^BXN,3,200,0,0,1,~^FH\\^FD[)>\\1E06\\1DVAIY1\\1DP{PartNo.Replace("-", "")}\\1DSQ019{ALC}\\1DEHS2L0314\\1DT{DateTime.Now.ToString("yyMMdd")}M1APA{Serial}\\1D\\1E\\04";
                script += $"#[)>\\1E06\\1D{R1[1]}\\1D{R1[2]}\\1D{R1[3]}\\1D\\1E\\04";
                script += $"#[)>\\1E06\\1D{R2[1]}\\1D{R2[2]}\\1D{R2[3]}\\1D\\1E\\04";
                script += $"#[)>\\1E06\\1D{R3[1]}\\1D{R3[2]}\\1D{R3[3]}\\1D\\1E\\04^FS";
                script += $"^FWN^FO180,145^AD30,30^FD{ALC}^FS";
                script += $"^FWB^FO180,30^AP10,10^FD{PartNo.Replace("-", "")}^FS";
                script += $"^FWB^FO200,30^AP5,5^FD{Serial}^FS";
                script += $"^FWB^FO220,30^AB10,10^FD{DateTime.Now.ToString("yyyy-MM-dd")}^FS";
                if (Manual) script += $"^FWB^FO240,60^AB10,10^FD#^FS";
                script += $"^FWB^FO240,30^AB10,10^FD{DateTime.Now.ToString("HH:mm:ss")}^FS^XZ";
                Console.WriteLine(script);

            }

            // var R3 = RBar[2].Split((Convert.ToChar(0x1D)));
            //var R4 = RBar[3].Split((Convert.ToChar(0x1D)));


            //string script = $"^XA^LH{X},{Y}^FO20,20^AD20,20^FD{serial}^FS";
            //script += $"^FO20,40^BY3^BCN,70,N,N,N^FD{alc}^FS";
            //script += $"^FO20,115^AD55,55^FD{alc}^FS";
            //script += $"^FO135,115^AD20,20^FD{DateTime.Now.ToString("yyyy-MM-dd")}^FS";
            //script += $"^FO135,135^AD20,20^FD{DateTime.Now.ToString("HH:mm:ss")}^FS";
            //script += $"^XZ";
            //GS 1D    RS 1E
            //[)>06VEJJ7P467W0S1100SPPJT200907ABB1A0020   sbw
            //[)>06VKM54P97250S2JA0 PPJSQ051SJAJT200910CS21A2009105336    heater 


            //[)>06VAIY1P84604 - S2480XHHSG48HEHS2L0314T201011M1APAG48H2010110001#[)>06VKM54P97250S2JA0 PPJSQ051SJAJT200910CS21A2009105343#[)>06VEJJ7P467W0S1100SPPJT200907ABB1A0018

            try
            {
                //print.Write($"^XA^LH{INI.Read("Print", "LH_X")},{INI.Read("Print", "LH_Y")}^FO100,100^BQN,2,3^FDQA,{Serial}^FS^XZ");
                
                Sp.Write(script);
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        public static void Close()
        {
            if (Sp.IsOpen)
                Sp.Close();
        }
    }

    [Serializable]
    public class ProductInfo
    {
        public string ALC = string.Empty;
        public int PrdCount = 0;
    }
}