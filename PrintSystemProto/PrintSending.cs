using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using MesSystem;

namespace PrintSystemProto
{
    public partial class PrintSending : Form
    {
        public PrintSending()
        {
            InitializeComponent();
        }

        private void PrintSending_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = SerialPort.GetPortNames(); //콤보박스에서 시리얼 포트 이름 가져오기
        }

        // 시리얼 포트 연결시키는 버튼 기능 구문
        public void connet_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = comboBox1.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Parity = Parity.None;
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);

                serialPort1.Open();

                serialchk.Text = "포트가 연결되었습니다.";
                comboBox1.Enabled = false; //com포트설정 콤보박스 비활성시킴 : 
            }
        }
        //충돌 방지용
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(MySerialReceived)); //메인 쓰레드와 수신 쓰레드의 충돌방지 별도 작업으로 분리 시킴
        }

        // 데이터 수신 관련 함수 부분 수신한 데이터 처리 문
        private void MySerialReceived(object s, EventArgs e)  //여기에서 수신 데이타를 사용자의 용도에 따라 처리한다.
        {
            /* int ReceiveData = serialPort1.ReadByte();  //시리얼 버퍼에 수신된 데이타를 ReceiveData 읽어오기
             receivebox.Text = receivebox.Text + string.Format("{0:X2}", ReceiveData);  //int 형식을 string형식으로 변환하여 출력*/
            int bytesRead = serialPort1.BytesToRead;
            byte[] buffer = new byte[bytesRead];
            serialPort1.Read(buffer, 0, bytesRead);

            string receivedData = Encoding.UTF8.GetString(buffer);
            receivebox.Text += receivedData;

        }

        // 프린터 기로 데이터를 읽도로 만드는 구문 - 사용 안함. - 단순 전송용으로만 사용 중 - send버튼
        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write(sendtxbox.Text);
        }

        private void nonconnet_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();

                serialchk.Text = "연결 해제";
                comboBox1.Enabled = true;
            }
            else
            {
                serialchk.Text = "포트가 이미 닫혀 있습니다.";
            }
        }

        // 라벨 데이터를 출력하도록 만드는 구문
        private void button2_Click(object sender, EventArgs e)
        {
            /*  PrintDialog pd = new PrintDialog();
              pd.PrinterSettings = new PrinterSettings();*/

            serialPort1.Write(getPrintcode());
           // string PrintCode = getPrintcode();

           /* if (!(RawPrinterHelper.SendStringToPrinter(pd.PrinterSettings.PrinterName, PrintCode)))
            {
                msglable.Text = "출력 오류";
            }
            else
            {

            }*/
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public string getPrintcode()
        {
            string PrintCode = string.Empty;

       
            PrintCode += "^XA";
            PrintCode += "^CW1,KFONT3.FNT^FS";
            PrintCode += "^SEE:UHANGUL.DAT^FS";
           // PrintCode += "^CI26";  
            PrintCode += "^FO9,10^GB350,260,3,,3^FS";


            //PrintCode += "^CI28";
            //PrintCode += "^CFJ,22";
            PrintCode += "^FO20,20^A1N,15,15^FD회사명 : " + Copnm.Text + "^FS";
            PrintCode += "^FO20,44^A1N,15,15^FD주소 : 608 room,^FS";
            PrintCode += "^FO25,70^FD212, 1gongdan-ro,Gumi-si,^FS";
            PrintCode += "^FO15,100^FDGyeongsangbuk-do, ROKorea^FS";
            PrintCode += "^FO15,140^FD이름 : 박상준^FS";
            PrintCode += "^FO15,170^FDTEL. : 010-2956-2593^FS";
            PrintCode += "^FO270,185^BQN,,2^FDCop. : FDS,Adress : 608 room,212, 1gongdan-ro,Gumi-si,Gyeongsangbuk-do, Republic of KoreaNAME : SANG JOON PARK, TEL. : 010-2956-2593^FS";
            PrintCode += "^FO25,225^BY1,2^BCN,50,N,N,N^FDTEL01029562593^FS";
            PrintCode += "^CI0";
            PrintCode += "\r\n^XZ";




            return PrintCode;
        }

        private void sendtx_Click(object sender, EventArgs e)
        {

        }
    }
}
