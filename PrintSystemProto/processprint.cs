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
            barX.Text = "55";
            barY.Text = "220";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void processprint_Load(object sender, EventArgs e)
        {
           
            serialcombo.DataSource = SerialPort.GetPortNames(); 
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
            string modelbx = modeltx.Text;
            string ALCbx = ALCtx.Text;
            int xpo = Convert.ToInt32(xposibx.Text);
            int ypo = Convert.ToInt32(yposibx.Text);
            int barx = Convert.ToInt32(barX.Text);
            int bary = Convert.ToInt32(barY.Text);
            string datenow = datetext.Text;
            string ProcessCode = string.Empty;

            ProcessCode = "^XA";

            ProcessCode += "^CF0,25,20";
            ProcessCode += "^FO20,25^GB360,270,3,,2^FS";
            ProcessCode += "^FO55,60^FDmodel: "+ modelbx + "^FS";
            ProcessCode += "^FO55,90^FDALC: "+ ALCbx + "^FS";
            ProcessCode += "^FO55,120^FDDATE:" + datenow + "^FS";
            ProcessCode += "^FO"+ xpo + ","+ ypo + "^BQN,,2^FDmodel:model,ALC: ALC,DATE: DATE^FS";
            ProcessCode += "^FO" + barx + "," + bary + "^BY1,2^BCN,50,N,N,N^FDmodel:model,ALC: ALC^FS";
            ProcessCode += "\r\n^XZ";

            return ProcessCode;
        }

        private void portselect_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
