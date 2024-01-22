using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
public static class cMKPLC
{
    //PLC SerialPort
    private static System.IO.Ports.SerialPort PLC;

    private static readonly string ENQ = ((char)0x05).ToString(); //Enquire[프레임시작코드]
    private static readonly string EOT = ((char)0x04).ToString(); //End of Text[요구용 Asc]
    private static readonly string ACK = ((char)0x06).ToString(); //Acknowledge[응답 시작]
    private static readonly string ETX = ((char)0x03).ToString(); //End Text [응답용Asc]
    private static readonly string NAK = ((char)0x15).ToString(); //Not Acknoledge[에러응답시작]
    private static readonly string STX = ((char)0x02).ToString();

    public static int ReadDCount = 0;
    public static int ReadMCount = 0;
    private static string[] strBitAdd = null;
    private static int ReadID = 0;
    private static bool RecOK = false;

    private static ConcurrentDictionary<int, string> ReadDic = new ConcurrentDictionary<int, string>();
    private static ConcurrentQueue<string> WritePLC = new ConcurrentQueue<string>();

    public static event Action<int, int[]> vRECEIVE;
    public static event Action<string> vLogDATA;

    private static bool isWrite = false;
    public enum PLCDIVISION { WORD, BIT };
    public static bool InitPlcCom(string PORTNAME = "COM1", int BAUDRATE = 9600)
    {
        if (PLC == null) PLC = new System.IO.Ports.SerialPort();
        PLC.PortName = PORTNAME;
        PLC.BaudRate = BAUDRATE;
        PLC.DataBits = 8;
        PLC.Parity = System.IO.Ports.Parity.None;
        PLC.StopBits = System.IO.Ports.StopBits.One;

        PLC.DataReceived += PLC_DataReceived;
        try
        {
            if (!PLC.IsOpen && PLC != null)
                PLC.Open();
        }
        catch
        {
            return false;
        }
        return true;

    }
    private static string TempPlc = string.Empty;
    private static void PLC_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
    {
        TempPlc += PLC.ReadExisting();
        if (!TempPlc.Contains(ETX)) return;

        if (vLogDATA != null) vLogDATA(TempPlc);

        //불량 응답 
        if (TempPlc.Contains("NAK"))
        { TempPlc = string.Empty; RecOK = true; }

        //정상 응답 
        if (TempPlc.Contains(ACK) && !isWrite)
        {
            try
            {
                int QACKLoc = TempPlc.IndexOf("ACK") + 4;

                if (isWrite) { isWrite = false; return; }
                int count = TempPlc.Substring(6).ToString().Replace(ETX, "").Substring(0, 2).ToInt();
                string str = TempPlc.Substring(8).ToString().Replace(ETX, "");
                int[] itemVal = new int[count];
                int ival = 0;
                for (int i = 0; i < count; i++)
                {
                    int start = str.Substring(ival, 2).ToInt();
                    string strr = str.Substring(2 + ival, start * 2);
                    long val = Convert.ToInt16(strr, 16);
                    //Console.WriteLine(val);
                    itemVal[i] = (int)val;
                    ival += 2 * 2 + start;
                }
                vRECEIVE?.Invoke(ReadID, itemVal);
            }
            catch { }
        }
        else
        {
            isWrite = false;

        }

        //리시브 받은 버퍼 클리어,,
        TempPlc = string.Empty;
        //리시브가 정상 처리됐으므로 쓰기 대기중 플래그 ON 
        RecOK = true;
    }
    public static void SetReadAdd(int ID, string[] Device)
    {
        ReadDic.TryAdd(ID, SetReadPLC(Device));
    }
    public static void SetWriteAdd(string Address, int Value)
    {
        WritePLC.Enqueue(setWrite(Address, Value));
    }
    private static string SetReadPLC(string[] Device)
    {

        char ENQ = (char)0x05;
        char ETX = (char)0x03;
        char CR = (char)0x0D;
        char LF = (char)0x0A;
        //F80000FF03FF0000 040600000204D * 0003200001D * 0003100001M * 0018400001M * 0018500001M * 0018600001M * 0018610001
        string strHeader = ENQ + "00";
        string strCommand = "R"; // RANDOM READ
        string strSubCommand = "SS"; //ReadRandom일때는 워드로 읽기
        string strDeviceLenth = Device.Count().ToString("X2");

        int iWordDeviceCount = 0;
        int iBitDeviceCount = 0;

        strBitAdd = Device.Where(c => c.Contains("M")).ToArray();

        string strReadProtocol = "";
        int idx = 0;
        foreach (string forStr in Device)
        {
            string TempStr = string.Empty;
            switch (forStr.Substring(0, 1))
            {
                case "M":
                    iBitDeviceCount++;
                    TempStr = (forStr.Length + 2).ToString("X2")+@"%" + forStr.Insert(1,"W");
                    strReadProtocol += TempStr;
                    break;
                case "D":
                    iWordDeviceCount++;
                    TempStr = (forStr.Length + 2).ToString("X2")+@"%" + forStr.Insert(1, "W");
                    strReadProtocol += TempStr;
                    break;
            }
            idx++;
        }
        ReadDCount = iWordDeviceCount;
        ReadMCount = iBitDeviceCount;

        return strHeader + strCommand + strSubCommand + strDeviceLenth +
                         //    iWordDeviceCount.ToString("X2") + iBitDeviceCount.ToString("X2") +
                         strReadProtocol + EOT;
    }

    private static string setWrite(string Device, int Value)
    {
        char ENQ = (char)0x05;
        char ETX = (char)0x03;
        char CR = (char)0x0D;
        char LF = (char)0x0A;
        //F80000FF03FF0000 040600000204D * 0003200001D * 0003100001M * 0018400001M * 0018500001M * 0018600001M * 0018610001
        string strHeader = ENQ + "00";
        string strCommand = "W"; // RANDOM READ
        string strSubCommand = "SS"; //ReadRandom일때는 워드로 읽기

        int iWordDeviceCount = 0;
        int iBitDeviceCount = 0;

        string strWriteProtocol = "";
        string TempStr = "01" + (Device.Length + 2).ToString("X2") + "%" + Device.Insert(1, (Device.Substring(0, 1) == "M" ? "X" : "W")) + Value.ToString((Device.Substring(0, 1) == "M" ? "X2" : "X4"));
        strWriteProtocol += TempStr;
        switch (TempStr.Substring(0, 1))
        {
            case "M":
                iBitDeviceCount++;
                break;
            case "D":
                iWordDeviceCount++;
                break;
        }


        return strHeader + strCommand + strSubCommand +
                        strWriteProtocol + EOT;//+ Value.ToString("0");
    }
    //private static string setWrite(string Device, int Value)
    //{
    //    char ENQ = (char)0x05;
    //    char ETX = (char)0x03;
    //    char CR = (char)0x0D;
    //    char LF = (char)0x0A;
    //    //F80000FF03FF0000 040600000204D * 0003200001D * 0003100001M * 0018400001M * 0018500001M * 0018600001M * 0018610001
    //    string strHeader = ENQ + "00";
    //    string strCommand = "W"; // RANDOM READ
    //    string strSubCommand = "SS"; //ReadRandom일때는 워드로 읽기

    //    int iWordDeviceCount = 0;
    //    int iBitDeviceCount = 0;

    //    string strWriteProtocol = "";
    //    string TempStr = "01" + (Device.Length + 2).ToString("X2") + "%" + Device.Insert(1,"X") + Value.ToString("X2");
    //    strWriteProtocol += TempStr;
    //    switch (TempStr.Substring(0, 1))
    //    {
    //        case "M":
    //            iBitDeviceCount++;
    //            break;

    //        case "D":
    //            iWordDeviceCount++;
    //            break;
    //    }


    //    return strHeader + strCommand + strSubCommand +
    //                    strWriteProtocol + EOT;//+ Value.ToString("0");
    //}


    private static bool ReadFlag = true;
    public static void ReadStart()
    {
        int ReadTime = 0;
        ReadFlag = true;
        Task.Run(() =>
        {

            while (ReadFlag)
            {
                if (PLC.IsOpen)
                {
                    try
                    {
                        foreach (string str in ReadDic.Values)
                        {

                            if (WritePLC.Count > 0)
                            {
                                string WriteVal = string.Empty;
                                WritePLC.TryDequeue(out WriteVal);
                                isWrite = true;

                                //System.Windows.Forms.MessageBox.Show(WriteVal);

                                PLC.Write($@"{WriteVal}");
                            }
                            else
                            {
                                ReadID = ReadDic.Where(x => x.Value == str).Select(item => item.Key).Max();
                                isWrite = false;
                                PLC.Write($@"{str}");
                            }

                            while (true)
                            {

                                // 정상 리시브 대기,응답없을 경우 대략 5000카운트 후 다시 전송 
                                if ((RecOK) || ReadTime == 5000) { if (vLogDATA != null && (ReadTime == 5000)) vLogDATA("RESET"); RecOK = false; ReadTime = 0; break; }
                                ReadTime++;
                                System.Threading.Thread.Sleep(1);
                                System.Windows.Forms.Application.DoEvents();
                            }

                        }
                    }
                    catch (Exception ee) { System.Windows.Forms.MessageBox.Show(ee.Message); }
                }

                System.Windows.Forms.Application.DoEvents();
                System.Threading.Thread.Sleep(1);
            }

        });
    }

    public static void Close()
    {
        if (PLC.IsOpen)
            PLC.Close();
    }

}
