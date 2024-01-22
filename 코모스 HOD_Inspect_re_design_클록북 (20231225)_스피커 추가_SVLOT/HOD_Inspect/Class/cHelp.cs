#define Farpoint
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;
#if Farpoint
using FarPoint.Win.Spread;
using FarPoint.Win.Spread.Model;
#endif
using System.Drawing;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Sockets;
using System.Net;
using System.Drawing.Drawing2D;

internal static class cHelp
{
    [DllImport("user32.dll", EntryPoint = "SendMessage", CharSet = CharSet.Auto)]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    [DllImportAttribute("user32.dll")]
    public static extern int SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

    [DllImport("user32.dll", EntryPoint = "SendMessage", CharSet = CharSet.Auto)]
    public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, string lParam);

    [DllImport("user32.dll", EntryPoint = "ReleaseCapture", CharSet = CharSet.Auto)]
    public static extern bool ReleaseCapture();

    [DllImport("user32.dll", EntryPoint = "FindWindowEx", CharSet = CharSet.Auto)]
    public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);

    [DllImport("advapi32.dll")]
    public static extern void InitiateSystemShutdown(string lpMachineName, string lpMessage, int dwTimeout, bool bForceAppsClosed, bool bRebootAfterShutdown);

    public static List<bool> InttoBit(this int value, int count)
    {

        List<bool> bit = new List<bool>();
        int index = 1;
        for (int i = 0; i < count; i++)
        {
            bit.Add(((value & index) == index));
            index *= 2;
        }
        return bit;
    }

    public static List<bool> InttoBit(this string value, int count)
    {
        int A = Convert.ToInt32(value, 16);
        List<bool> bit = new List<bool>();
        int index = 1;
        for (int i = 0; i < count; i++)
        {
            bit.Add(((A & index) == index));
            index *= 2;
        }
        return bit;
    }
    public static byte[] Tobytes(this string Data)
    {
        List<byte> Bytes = new List<byte>();
        for (int i = 0; i < Data.Length / 2; i++)
        {
            Bytes.Add(byte.Parse(Data.Substring(i * 2, 2), System.Globalization.NumberStyles.HexNumber));
        }
        return Bytes.ToArray();
    }
    /// <summary>
    /// 조건이 충족 할때 까지 타임아웃 시간동안 메세지 펌프를 계속하며 대기한다.
    /// </summary>
    /// <param name="condition">대기를 멈추는 조건이 TRUE인 조건</param>
    /// <param name="timeout">타임아웃</param>
    /// <returns>조건을 충족하면 True 반환 타임아웃이면 False</returns>
    public static bool TO(Func<bool> condition, int timeout = 1000)
    {
        Thread T = new Thread(() =>
        {
            bool stop = true;
            while (stop)
            {
                stop = !condition();
                //Application.DoEvents();
                Thread.Sleep(10);
            }
        });
        T.Start();
        bool Ret = T.Join(timeout);
        T.Abort();
        return Ret;
    }

    public static void ShowVirtalKeyboard()
    {
        var processes = Process.GetProcesses();
        for (int i = 0; i < processes.Length; i++)
        {
            if (processes[i].ProcessName == "화상 키보드")
            {
                return;
            }
        }
        Process.Start("osk.exe");
    }
    /// <summary>
    /// 조건이 충족 할때 까지 타임아웃 시간동안 메세지 펌프를 계속하며 대기한다.
    /// </summary>
    /// <param name="condition">대기를 멈추는 조건이 TRUE인 조건</param>
    /// <param name="timeout">타임아웃</param>
    /// <param name="cycle">메소드 반복 주기</param>
    /// <returns>조건을 충족하면 True 반환 타임아웃이면 False</returns>
    public static bool TO(Func<bool> condition, int timeout, int cycle)
    {
        Thread T = new Thread(() =>
        {
            DateTime now = DateTime.Now;
            bool stop = true;
            while (stop)
            {
                if (DateTime.Now.Subtract(now).TotalMilliseconds > cycle)
                {
                    now = DateTime.Now;
                    stop = !condition();
                }
                Thread.Sleep(10);
            }
        });
        T.Start();
        bool Ret = T.Join(timeout);
        T.Abort();
        return Ret;
    }
    public static readonly int WM_NLBUTTONDOWN = 0xA1;
    public static readonly int HT_CAPTION = 0x2;
    public static readonly int WM_USER = 0x400;
    public static readonly int WM_SETTEXT = 0x000C;
    public static IntPtr noteHandle = IntPtr.Zero;
    public static void WriteMemoLog(this string text)
    {
        bool isrun = false;
        Process p = new Process();
        foreach (var pc in Process.GetProcesses())
        {
            if (pc.ProcessName == "notepad")
            {
                p = pc;
                isrun = true;
                break;
            }
        }
        if (!isrun)
        {
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.FileName = "notepad.exe";
            p.Start();
            Thread.Sleep(100);

        }
        if (noteHandle == IntPtr.Zero)
            noteHandle = FindWindowEx(p.MainWindowHandle, IntPtr.Zero, "Edit", null);
        //string msg = text + Environment.NewLine;
        SendMessage(noteHandle, WM_SETTEXT, 0, text);
    }

    #region 에니메이션 효과 폼
    //왼쪽에서 오른쪽 
    public const int AW_HOR_POSITIVE = 0x1;
    //오른쪽에서 왼쪽 
    public const int AW_HOR_NEGATIVE = 0x2;
    //위에서 아래 
    public const int AW_VER_POSITIVE = 0x4;
    //아래에서 위로 
    public const int AW_VER_NEGATIVE = 0x08;
    //안쪽에서 접히면서(무너지면서) 
    public const int AW_CENTER = 0x10;
    //숨김 
    public const int AW_HIDE = 0x10000;
    //펼쳐지는 효과 
    public const int AW_ACTIVATE = 0x20000;
    //효과 설정 
    public const int AW_SLIDE = 0x40000;
    //흐려지는 효과 
    public const int AW_BLEND = 0x80000;

    [DllImport("user32.dll")]
    public static extern int AnimateWindow(IntPtr hwand, int dwTime, int dwFlags);
    #endregion


    public static IList<T> Clone<T>(this IList<T> listToClone) where T : ICloneable
    {
        return listToClone.Select(item => (T)item.Clone()).ToList();
    }
    public static void Txt(this Control c, string text)
    {
        if (c.InvokeRequired)
        {
            c.Invoke(new MethodInvoker(() => { c.Text = text; }));
        }
        else c.Text = text;
    }
    public static void Txt(this Control c, string text, Color forecolor)
    {
        if (c.InvokeRequired)
        {
            c.Invoke(new MethodInvoker(() => { c.Text = text; c.ForeColor = forecolor; }));
        }
        else c.Text = text;
    }
    public static void Txt(this Control c, string text, Color forecolor, Color backcolor)
    {
        if (c.InvokeRequired)
        {
            c.Invoke(new MethodInvoker(() => { c.Text = text; c.ForeColor = forecolor; c.BackColor = backcolor; }));
        }
        else c.Text = text;
    }
    public static void UI(this Control c, System.Action method)
    {
        if (c.InvokeRequired)
        {
            c.Invoke(method);
        }
        else method();
    }
    public static void UI(this Form c, System.Action method)
    {
        if (c.InvokeRequired)
        {
            c.Invoke(method);
        }
        else method();
    }

    public static T DeSerializer<T>(this T Target, byte[] data)
    {
        T R = default(T);
        XmlSerializer X = new XmlSerializer(Target.GetType());
        MemoryStream MS = new MemoryStream(data);
        try
        {
            R = (T)X.Deserialize(MS);
        }
        finally
        {
            MS.Close();
        }
        return R;
    }
    public static byte[] Serializer<T>(this T Target)
    {
        XmlSerializer X = new XmlSerializer(Target.GetType());
        MemoryStream MS = new MemoryStream();
        X.Serialize(MS, Target);
        return MS.ToArray();
    }
    public static void Serialize<T>(this T Target, string Filename)
    {
        if (File.Exists(Filename))
        {
            File.Delete(Filename);
        }
        XmlSerializer X = new XmlSerializer(Target.GetType());
        FileStream FS = new FileStream(Filename, FileMode.OpenOrCreate);
        try
        {
            X.Serialize(FS, Target);
        }
        finally
        {
            FS.Close();
        }
    }
    public static T DeSerialize<T>(this T Target, string Filename)
    {
        T R = default(T);
        XmlSerializer X = new XmlSerializer(Target.GetType());
        if (File.Exists(Filename))
        {
            FileStream FS = new FileStream(Filename, FileMode.OpenOrCreate);
            try
            {
                R = (T)X.Deserialize(FS);
            }
            catch { }
            finally
            {
                FS.Close();
            }
        }
        return R;
    }
    
    /// <summary>
    /// 숫자인지 확인.
    /// </summary>
    public static bool isNumber(this string S)
    {
        int N = 0;
        return int.TryParse(S, out N);
    }
    /// <summary>
    /// 정수로 변환.
    /// </summary>
    public static int ToInt(this string S)
    {
        int N = 0;
        return int.TryParse(S, out N) ? N : 0;
    }
    /// <summary>
    /// 정수로 변환.
    /// </summary>
    public static int ToInt(this object O)
    {
        int N = 0;
        return int.TryParse((O == null ? 0 : O).ToString(), out N) ? N : 0;
    }

    /// <summary>
    /// double 변환.
    /// </summary>
    public static double ToDouble(this string S)
    {
        double N = 0f;
        return double.TryParse(S, out N) ? N : 0f;
    }
    /// <summary>
    /// float 변환.
    /// </summary>
    public static float ToFloat(this string S)
    {
        float N = 0f;
        return float.TryParse(S, out N) ? N : 0f;
    }
    /// <summary>
    /// double 변환.
    /// </summary>
    public static double ToDouble(this object S)
    {
        double N = 0f;
        return double.TryParse(S.ToString(), out N) ? N : 0f;
    }
    /// <summary>
    /// Boolean으로 변환.
    /// </summary>
    public static bool ToBOOL(this string S)
    {
        bool B = false;
        return bool.TryParse(S, out B) ? B : false;
    }
    /// <summary>
    /// Boolean으로 변환.
    /// </summary>
    public static bool ToBOOL(this object S)
    {
        bool B = false;
        return bool.TryParse(S.ToString(), out B) ? B : false;
    }

    public static string ToHexString(this byte[] hex)
    {
        if (hex == null) return null;
        if (hex.Length == 0) return string.Empty;

        var s = new StringBuilder();
        foreach (byte b in hex)
        {
            s.Append(b.ToString("x2"));
        }
        return s.ToString();
    }
    /// <summary> 기존 배열의 일정 부분을 참조한다. </summary>
    /// <param name="i"> 앞에서부터 Skip할 길이 </param>
    /// <param name="len"> 사용할 길이 </param>
    public static T[] Sub<T>(this T[] data, int index, int length)
    {
        T[] result = new T[length];
        Array.Copy(data, index, result, 0, length);
        return result;
    }
    /// <summary> 문자열의 개수를 짝수로 맞춘다. </summary>
    public static string FitToEven(this string str)
    {
        return str + (str.Length % 2 == 1 ? " " : "");
    }

    /// <summary>
    /// 디스크의 남은 용량 비율을 가져온다.
    /// </summary>
    /// <param name="drivename">대상 디스크 이름 예> C</param>
    /// <returns>남은 용량 비율</returns>
    public static double GetFreeDiskSpace(string drivename)
    {
        DriveInfo df = new DriveInfo(drivename);
        double free = df.TotalFreeSpace;
        double total = df.TotalSize;
        return Math.Round((free / total) * 100, 2);
    }
    /// <summary>
    /// 폴더를 압축한다.
    /// </summary>
    /// <param name="srcpath">압축할폴더경로</param>
    /// <param name="dstfilename">대상 파일경로 및 이름</param>
    public static void CompressFolder(string srcpath, string dstfilename)
    {
        //ZipFile.CreateFromDirectory(srcpath, dstfilename, CompressionLevel.Optimal, true);
    }

    /// <summary>
    /// 압축파일을 폴더로 압축해제한다.
    /// </summary>
    /// <param name="srcfilename">압축 파일 경로 및 이름</param>
    /// <param name="dstpath">대상 폴더경로</param>
    public static void DeCompressFolder(string srcfilename, string dstpath)
    {
        //ZipFile.ExtractToDirectory(srcfilename, dstpath);
    }


    /// <summary> 데이터 압축 </summary>
    /// <param name="buffer">압축할 대상</param>
    /// <returns>압축된 byte배열</returns>
    public static byte[] Zip(byte[] buffer)
    {
        MemoryStream ms = new MemoryStream();
        GZipStream zip = new GZipStream(ms, CompressionMode.Compress, true);
        zip.Write(buffer, 0, buffer.Length);
        zip.Close();
        ms.Position = 0;

        MemoryStream outStream = new MemoryStream();

        byte[] compressed = new byte[ms.Length];
        ms.Read(compressed, 0, compressed.Length);

        byte[] gzBuffer = new byte[compressed.Length + 4];
        Buffer.BlockCopy(compressed, 0, gzBuffer, 4, compressed.Length);
        Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, gzBuffer, 0, 4);
        return gzBuffer;
    }

    /// <summary>
    /// 데이터 압축해제
    /// </summary>
    /// <param name="gzBuffer">압축해제할 대상</param>
    /// <returns>압축해제된 byte배열</returns>
    public static byte[] Unzip(byte[] gzBuffer)
    {
        MemoryStream ms = new MemoryStream();
        int msgLength = BitConverter.ToInt32(gzBuffer, 0);
        ms.Write(gzBuffer, 4, gzBuffer.Length - 4);

        byte[] buffer = new byte[msgLength];

        ms.Position = 0;
        GZipStream zip = new GZipStream(ms, CompressionMode.Decompress);
        zip.Read(buffer, 0, buffer.Length);

        return buffer;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct DEVMODE1
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string dmDeviceName;
        public short dmSpecVersion;
        public short dmDriverVersion;
        public short dmSize;
        public short dmDriverExtra;
        public int dmFields;

        public short dmOrientation;
        public short dmPaperSize;
        public short dmPaperLength;
        public short dmPaperWidth;

        public short dmScale;
        public short dmCopies;
        public short dmDefaultSource;
        public short dmPrintQuality;
        public short dmColor;
        public short dmDuplex;
        public short dmYResolution;
        public short dmTTOption;
        public short dmCollate;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string dmFormName;
        public short dmLogPixels;
        public short dmBitsPerPel;
        public int dmPelsWidth;
        public int dmPelsHeight;

        public int dmDisplayFlags;
        public int dmDisplayFrequency;

        public int dmICMMethod;
        public int dmICMIntent;
        public int dmMediaType;
        public int dmDitherType;
        public int dmReserved1;
        public int dmReserved2;

        public int dmPanningWidth;
        public int dmPanningHeight;
    };

    class User_32
    {
        [DllImport("user32.dll")]
        public static extern int EnumDisplaySettings(string deviceName, int modeNum, ref DEVMODE1 devMode);
        [DllImport("user32.dll")]
        public static extern int ChangeDisplaySettings(ref DEVMODE1 devMode, int flags);

        public const int ENUM_CURRENT_SETTINGS = -1;
        public const int CDS_UPDATEREGISTRY = 0x01;
        public const int CDS_TEST = 0x02;
        public const int DISP_CHANGE_SUCCESSFUL = 0;
        public const int DISP_CHANGE_RESTART = 1;
        public const int DISP_CHANGE_FAILED = -1;
    }

    /// <summary> 주 스크린의 시스템 해상도를 변경한다. 윈7 이상은 즉시 적용가능, xp 이하는 재부팅해야만 적용됨 </summary>
    public static bool ResolutionFix(int width, int height)
    {
        bool result = false;

        DEVMODE1 dm = new DEVMODE1() { dmDeviceName = new string(new char[32]), dmFormName = new string(new char[32]) };
        dm.dmSize = (short)Marshal.SizeOf(dm);

        //현재 디스플레이설정에서 스크린이 0개가 아닐 떄
        if (User_32.EnumDisplaySettings(null, User_32.ENUM_CURRENT_SETTINGS, ref dm) != 0)
        {
            //지정된 해상도로 설정하고
            dm.dmPelsWidth = width;
            dm.dmPelsHeight = height;

            //해상도 변경을 시도한다.
            if (User_32.ChangeDisplaySettings(ref dm, User_32.CDS_TEST) != User_32.DISP_CHANGE_FAILED)
            {
                //해상도 변경에 성공했으면 재부팅 시에도 적용된 해상도를 사용하도록 레지스트리에 기록
                if (User_32.ChangeDisplaySettings(ref dm, User_32.CDS_UPDATEREGISTRY) == User_32.DISP_CHANGE_SUCCESSFUL)
                {
                    result = true;
                }
            }
        }
        return result;
    }


    public static T ToEnum<T>(this string value) where T : struct
    {
        return (T)Enum.Parse(typeof(T), value);
    }

    /// <summary> 개체를 Xml파일로 저장한다. </summary>
    public static T Export<T>(T Obj, string FileName)
    {
        using (StreamWriter sw = new StreamWriter(FileName)) new XmlSerializer(typeof(T)).Serialize(sw, Obj);
        return Obj;
    }

    /// <summary> Xml파일을 개체로 불러온다. </summary>
    public static T Import<T>(string FileName)
    {
        using (StreamReader sr = new StreamReader(FileName)) return (T)new XmlSerializer(typeof(T)).Deserialize(sr);
    }
    /// <summary> 개체를 바이너리 포메터로 저장한다. </summary>
    public static void ExportB<T>(this T Target, string FileName)
    {
        using (FileStream sw = new FileStream(FileName, FileMode.OpenOrCreate))
        {
            BinaryFormatter Bf = new BinaryFormatter();
            Bf.Serialize(sw, Target);
        }
    }
    /// <summary> 바이너리파일을 개체로 불러온다. </summary>
    public static T ImportB<T>(this T Target, string FileName)
    {
        using (FileStream sr = new FileStream(FileName, FileMode.Open))
        {
            BinaryFormatter Bf = new BinaryFormatter();
            return (T)Bf.Deserialize(sr);
        }
    }
    /// <summary> Xml파일을 개체로 불러온다. </summary>
    public static void Import<T>(string FileName, out T Obj)
    {
        using (StreamReader sr = new StreamReader(FileName)) Obj = (T)new XmlSerializer(typeof(T)).Deserialize(sr);
    }

    /// <summary> WOL 해당 물리주소를 사용하여 원격 부팅을 시도 </summary>
    public static void Wol(string macAddress)
    {
        //구분자기호 제거
        macAddress = macAddress.Replace("-", "");
        // 매직패킷 생성
        string hexMagicPacket = string.Concat(Enumerable.Repeat("FF", 6)) + string.Concat(Enumerable.Repeat(macAddress, 16));
        // 매직패킷을 바이트배열로 변경
        byte[] magicPacket = Enumerable.Range(0, hexMagicPacket.Length).Where(x => x % 2 == 0).Select(x => Convert.ToByte(hexMagicPacket.Substring(x, 2), 16)).ToArray();

        using (UdpClient udpClient = new UdpClient())
        {
            // 9번포트 브로드캐스팅으로 연결
            udpClient.Connect(IPAddress.Broadcast, 9);
            // 매직패킷 전송
            udpClient.Send(magicPacket, magicPacket.Length);
        }
    }
#if Farpoint
    /// <summary>
    /// 스프레드 커스터마이징.
    /// </summary>
    public static void fpSpreadSet(this FpSpread sender, int HeaderCount, string[] HeaderNanme)
    {

        FpSpread myspread = sender;

        myspread.Font = new Font("맑은고딕", 10F, FontStyle.Bold);
        myspread.ActiveSheet.ColumnHeader.DefaultStyle.Font = new Font("맑은고딕", 10F, FontStyle.Bold);

        myspread.ActiveSheet.ColumnHeader.Rows[0].Height = 25;
        myspread.ActiveSheet.ColumnHeader.RowCount = 1;
        myspread.ActiveSheet.SelectionUnit = SelectionUnit.Row;
        myspread.ActiveSheet.OperationMode = OperationMode.ExtendedSelect;
        myspread.ActiveSheet.ColumnCount = HeaderCount;
        myspread.ActiveSheet.AlternatingRows[0].BackColor = Color.White;
        myspread.ActiveSheet.AlternatingRows[1].BackColor = Color.AliceBlue;

        for (int i = 0; i < HeaderCount; i++)
        {
            myspread.ActiveSheet.ColumnHeader.Cells[0, i].Text = HeaderNanme[i];
        }
    }
    /// <summary> 그리드 컬럼 너비 자동 조정 </summary>
    public static void GetPreferredWidth(this FpSpread spread, int columnInt, int rowHeight,int basesize = 100)
    {
        FpSpread mySpread = spread;
        float[] size = new float[columnInt];

        int i;
        for (i = 0; i < columnInt; i++)
        {
            Column col;
            col = mySpread.ActiveSheet.Columns[i];
            size[i] = mySpread.ActiveSheet.Columns[i].GetPreferredWidth();
            if (size[i] > basesize)
            {
                col.Width = size[i] + 70;
            }
            else
            {
                col.Width = basesize;
            }
        }
        mySpread.ActiveSheet.Columns[-1].VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
        mySpread.ActiveSheet.Columns[-1].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
        for (int j = 0; j < mySpread.ActiveSheet.Rows.Count; j++)
        {
            mySpread.ActiveSheet.Rows[j].Height = rowHeight;
        }
    }
    public static void GetPreferredWidth1(this FpSpread spread, int columnInt, int rowHeight, int basesize = 100)
    {
        FpSpread mySpread = spread;
        float[] size = new float[columnInt];

        int i;
        for (i = 0; i < columnInt; i++)
        {
            Column col;
            col = mySpread.ActiveSheet.Columns[i];
            size[i] = mySpread.ActiveSheet.Columns[i].GetPreferredWidth();
            if (i != 1)
            {
                if (size[i] > basesize)
                {
                    col.Width = size[i] + 50;
                }
                else
                {
                    col.Width = basesize;
                }
            }
            else
            {
                if (size[i] > 140)
                {
                    col.Width = size[i] + 50;
                }
                else
                {
                    col.Width = 140;
                }
            }
        }
        mySpread.ActiveSheet.Columns[-1].VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
        mySpread.ActiveSheet.Columns[-1].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
        for (int j = 0; j < mySpread.ActiveSheet.Rows.Count; j++)
        {
            mySpread.ActiveSheet.Rows[j].Height = rowHeight;
        }
    }
#endif

    public static string MilSetFilename = Application.StartupPath + @"\MilConfig.bin";

    #region 좌표변환
    /// <summary>
    /// 클라이언트 영역의 이미지 좌표와 클라이언트좌표의 변환. 포인트를 반환한다.
    /// </summary>
    /// <param name="srcPoint">변환할 포인트</param>
    /// <param name="Imagesize">이미지해상도 X, Y 사이즈</param>
    /// <param name="clientSize">클라이언트 영역 X, Y사이즈 </param>
    /// <returns>변환된 값 리턴.</returns>
    public static Point ConvertImagePoint(this Point srcPoint, Size Imagesize, Size clientSize)
    {
        double X = srcPoint.X;
        double Y = srcPoint.Y;
        double IWidth = Imagesize.Width;
        double cWidth = clientSize.Width;
        double iHeight = Imagesize.Height;
        double cHeight = clientSize.Height;
        double NewX = X * (cWidth / IWidth);
        double NewY = Y * (cHeight / iHeight);
        return new Point((int)NewX, (int)NewY);
    }

    /// <summary>
    /// 클라이언트 영역의 이미지 좌표와 클라이언트좌표의 변환. 사이즈를 반환한다.(Right좌표,Bottom좌표)
    /// </summary>
    /// <param name="srcSize">변환할 사이즈</param>
    /// <param name="Imagesize">이미지해상도 X, Y 사이즈</param>
    /// <param name="clientSize">클라이언트 영역 X, Y사이즈</param>
    /// <returns>변환된 값 리턴</returns>
    public static Size ConvertImagePoint(this Size srcSize, Size Imagesize, Size clientSize)
    {
        double X = srcSize.Width;
        double Y = srcSize.Height;
        double IWidth = Imagesize.Width;
        double cWidth = clientSize.Width;
        double iHeight = Imagesize.Height;
        double cHeight = clientSize.Height;
        double NewX = X * (cWidth / IWidth);
        double NewY = Y * (cHeight / iHeight);
        Size Ret = new Size((int)NewX, (int)NewY);
        return Ret;
    }

    /// <summary>
    /// 클라이언트 영역의 이미지 좌표와 클라이언트좌표의 변환. 포인트를 반환한다.
    /// </summary>
    /// <param name="srcPoint">변환할 포인트</param>
    /// <param name="Imagesize">이미지해상도 X, Y 사이즈</param>
    /// <param name="clientSize">클라이언트 영역 X, Y사이즈 </param>
    /// <returns>변환된 값 리턴.</returns>
    public static Point ConvertClientPoint(this Point srcPoint, Size Imagesize, Size clientSize)
    {
        double X = srcPoint.X;
        double Y = srcPoint.Y;
        double IWidth = Imagesize.Width;
        double cWidth = clientSize.Width;
        double iHeight = Imagesize.Height;
        double cHeight = clientSize.Height;
        double NewX = X * (IWidth / cWidth);
        double NewY = Y * (iHeight / cHeight);
        return new Point((int)NewX, (int)NewY);
    }

    /// <summary>
    /// 클라이언트 영역의 이미지 좌표와 클라이언트좌표의 변환. 사이즈를 반환한다.(Right좌표,Bottom좌표)
    /// </summary>
    /// <param name="srcSize">변환할 사이즈</param>
    /// <param name="Imagesize">이미지해상도 X, Y 사이즈</param>
    /// <param name="clientSize">클라이언트 영역 X, Y사이즈</param>
    /// <returns>변환된 값 리턴</returns>
    public static Size ConvertClientPoint(this Size srcSize, Size Imagesize, Size clientSize)
    {
        double X = srcSize.Width;
        double Y = srcSize.Height;
        double IWidth = Imagesize.Width;
        double cWidth = clientSize.Width;
        double iHeight = Imagesize.Height;
        double cHeight = clientSize.Height;
        double NewX = X * (IWidth / cWidth);
        double NewY = Y * (iHeight / cHeight);
        Size Ret = new Size((int)NewX, (int)NewY);
        return Ret;
    }
    public static int ToClientCoordinateX(this int src, Size Imagesize, Size clientSize)
    {
        double ClientX = (double)clientSize.Width / (double)Imagesize.Width;
        double NewX = (double)src * ClientX;
        return (int)NewX;
    }
    public static int ToClientCoordinateY(this int src, Size Imagesize, Size clientSize)
    {
        double ClientY = (double)clientSize.Height / (double)Imagesize.Height;
        double NewY = (double)src * ClientY;
        return (int)NewY;
    }
    #endregion

    #region 영역 좌표 변환
    /// <summary>
    /// 클라이언트 영역을 이미지 영역좌표계로 변환한다.
    /// </summary>
    /// <param name="srcRect">변경할 영역</param>
    /// <param name="Imagesize">변경의 기준이 되는 이미지 사이즈</param>
    /// <param name="clientSize">클라이언트 영역 사이즈</param>
    /// <returns>변경된 영역값</returns>
    public static Rectangle ConvertImageRect(this Rectangle srcRect, Size Imagesize, Size clientSize)
    {
        double ClientX = (double)Imagesize.Width / (double)clientSize.Width;
        double ClientY = (double)Imagesize.Height / (double)clientSize.Height;
        double NewX = srcRect.X * ClientX;
        double NewY = srcRect.Y * ClientY;
        double NewWidth = srcRect.Width * ClientX;
        double NewHeight = srcRect.Height * ClientY;
        Rectangle Ret = new Rectangle((int)NewX, (int)NewY, (int)NewWidth, (int)NewHeight);
        return Ret;
    }
    /// <summary>
    /// 이미지 영역을 클라이언트 영역좌표계로 변환한다.
    /// </summary>
    /// <param name="srcRect">변경할 영역</param>
    /// <param name="Imagesize">변경의 기준이 되는 이미지 사이즈</param>
    /// <param name="clientSize">클라이언트 영역 사이즈</param>
    /// <returns>변경된 영역값</returns>
    public static Rectangle ConvertCientRect(this Rectangle srcRect, Size Imagesize, Size clientSize)
    {
        double ClientX = (double)clientSize.Width / (double)Imagesize.Width;
        double ClientY = (double)clientSize.Height / (double)Imagesize.Height;
        double NewX = srcRect.X * ClientX;
        double NewY = srcRect.Y * ClientY;
        double NewWidth = srcRect.Width * ClientX;
        double NewHeight = srcRect.Height * ClientY;
        Rectangle Ret = new Rectangle((int)NewX, (int)NewY, (int)NewWidth, (int)NewHeight);
        return Ret;
    }
    #endregion
   
 
    public static float GetAngle(this Point pt)
    {
        return (float)(Math.Atan2(pt.X, pt.Y) * 180 / Math.PI);
    }

    public static Point SetAngle(this Point pt, double angle)
    {
        var rads = angle * (Math.PI / 180);
        var dist = Math.Sqrt(pt.X * pt.X + pt.Y * pt.Y);
        pt.X = (int)(Math.Sin(rads) * dist);
        pt.Y = -((int)((Math.Cos(rads) * dist)));
        return pt;
    }

    public static Point Transformation(this Point sourcePoint, Point centerPoint, double rotateAngle)
    {
        Point targetPoint = new Point();

        double radian = rotateAngle * (Math.PI / 180);

        targetPoint.X = (int)(Math.Cos(radian) * (sourcePoint.X - centerPoint.X) - Math.Sin(radian) * (sourcePoint.Y - centerPoint.Y) + centerPoint.X);
        targetPoint.Y = (int)(Math.Sin(radian) * (sourcePoint.X - centerPoint.X) + Math.Cos(radian) * (sourcePoint.Y - centerPoint.Y) + centerPoint.Y);

        return targetPoint;
    }

 
 
    #region 중복실행방지
    private static System.Threading.Mutex OnlyOne = null;
    public static bool GetOnlyOneRunning()
    {
        bool StartOne = false;
        OnlyOne = new System.Threading.Mutex(true, "OneStart", out StartOne);
        return StartOne;
    }
    public static void ReleaseMutex()
    {
        OnlyOne.ReleaseMutex();
    }
    #endregion

    #region 로그기록
    public static string SavePath = @"C:\LOGTEXT";
    public static string SaveFilename = "log.txt";
    /// <summary>
    /// 로그로 사용할 메세지를 입력한다. 
    /// </summary>
    /// <param name="str">로그로 지정 될 내용지정 </param>
    public static void AddLogText(string str)
    {
        DirectoryInfo Di = new DirectoryInfo(SavePath);
        if (!Di.Exists)
        {
            Di.Create();
        }
        lock (SaveFilename)
        {
            FileStream logfile = new FileStream(SavePath + @"\" + SaveFilename, FileMode.Append);
            StreamWriter SW = new StreamWriter(logfile);
            try
            {

                if (logfile.CanWrite)
                {
                    SW.WriteLine("[" + DateTime.Now.ToString("yy/MM/dd HH:mm:ss") + "]=> " + str);
                    SW.Flush();
                }

            }
            finally
            {
                SW.Close();
                logfile.Close();
            }
        }

    }

    
    public static string SaveFilename1 = "Pass.txt";
    public static void SavePassWord(string str)
    {
        lock (SaveFilename1)
        {
            FileStream logfile = new FileStream(Application.StartupPath + @"\" + SaveFilename1, FileMode.Append);

            StreamWriter SW = new StreamWriter(logfile);
            try
            {
                if (logfile.CanWrite)
                {
                    SW.WriteLine(str);
                    SW.Flush();
                }

            }
            finally
            {
                SW.Close();
                logfile.Close();
            }
        }

    }

    public static string GetPassWord()
    {
        lock(SaveFilename1)
        {
            //FileStream logfile = new FileStream(Application.StartupPath + @"\" + SaveFilename1, FileMode.Append);
            StreamReader SR = new StreamReader(Application.StartupPath + @"\" + SaveFilename1);
            try
            {
               return SR.ReadLine();
            }
            finally
            {
                SR.Close();
                //logfile.Close();
            }
        }

    }
    #endregion

}


