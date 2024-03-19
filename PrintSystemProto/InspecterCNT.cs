using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Threading;


namespace PrintSystemProto
{
    public partial class InspecterCNT : Form
    {
        public InspecterCNT()
        {
            InitializeComponent();
        }

        

        private void LOAD_btn_Click(object sender, EventArgs e)
        {
            VideoCapture video = new VideoCapture(0);
            Mat frame = new Mat();

            while (Cv2.WaitKey(33) != 'q')
            {
                video.Read(frame);
                //Cv2.ImShow("frame", frame);
                pictureBox1.Image = frame.ToBitmap();
            }
        
        }


    }
}
