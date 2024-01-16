using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static PrintSystemProto.ModelINFT;

namespace PrintSystemProto
{
    using static MAIN;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;

    public partial class processprint : Form
    {
        public processprint()
        {
            InitializeComponent();
            xposibx.Text = "55";
            yposibx.Text = "150";
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void processprint_Load(object sender, EventArgs e)
        {
           
    
            //검사 일자 데이터 생성
            DateTime today = DateTime.Now;
            datetext.Text = string.Format("{0:s}",today);
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modeltx_TextChanged(object sender, EventArgs e)
        {

        }

        public void SetData(processchkdata data)
        {
            modeltx.Text = data.Pr_model;
            ALCtx.Text = data.Pr_alc;
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
            try
            {
                serialcombo.DataSource = SerialPort.GetPortNames();
                serialPort1.PortName = serialcombo.Text;
                serialPort1.BaudRate = 9600;
                serialPort1.DataBits = 8;
                serialPort1.StopBits = StopBits.One;
                serialPort1.Parity = Parity.None;

                serialPort1.Open();
                serialcombo.Enabled = false;

                serialPort1.Write(Getprdata());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally { 
            
            serialPort1.Close();
            }
        }

        public string Getprdata()
        {
           
            string ProcessCode = string.Empty;

            ProcessCode = "^XA";

            ProcessCode += "^CF0,25,20";
            ProcessCode += "^FO20,25^GB360,270,3,,2^FS";
            ProcessCode += "^FO55,60^FDmodel: "+modeltx+"^FS";
            ProcessCode += "^FO55,90^FDALC: "+ ALCtx +"^FS";
            ProcessCode += "^FO55,120^FDDATE:" + datetext + "^FS";
            ProcessCode += "^FO"+xposibx+","+yposibx+"^BQN,,2^FDmodel:model,ALC: ALC,DATE: DATE^FS";
            ProcessCode += "^FO55,220^BY1,2^BCN,50,N,N,N^FDmodel:model,ALC: ALC^FS";
            ProcessCode += "\r\n^XZ";

            return ProcessCode;
        }

        private void portselect_Click(object sender, EventArgs e)
        {
            
        }
    }
}
